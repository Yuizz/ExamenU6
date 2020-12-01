using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenU6
{
    /// <summary>
    /// Lógica de interacción para LendBookWindow.xaml
    /// </summary>
    public partial class LendBookWindow : Window
    {
        private List<User> Usuarios;
        private List<Book> Libros;
        private int selectedBook;
        private Tools Arduino;
        public LendBookWindow(List<User> Users, List<Book> Books, int selectedBook)
        {
            InitializeComponent();
            this.Usuarios = Users;
            this.Libros = Books;
            this.selectedBook = selectedBook;
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);
        }

        private void scanCard_Click(object sender, RoutedEventArgs e)
        {
            string RFID = "";
            RFID = Arduino.ReadSerial();
            RFIDBox.Text = RFID;
            if (RFID != "" && RFID != "Arduino desconectado!!")
            {
                if (Usuarios.Exists(usuario => usuario.Rfid == RFID))
                {
                    Usuarios.Find(usuario => usuario.Rfid == RFID).RequestedBook(Libros, selectedBook);
                    MessageBox.Show($"Libro {Libros[selectedBook].Title} prestado.");
                    Arduino.closePort();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La tarjeta no pertenece a ningún usuario, registrala primero", "Prestar libro", MessageBoxButton.OK, MessageBoxImage.Error);
                    Arduino.closePort();
                    this.Close();
                }
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Arduino.closePort();
            this.Close();
        }
        void LendBookWindow_Closing(object sender, CancelEventArgs e)
        {
            Arduino.closePort();
        }
    }
}
