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
using System.Threading;

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
        private string rfid = "";
        private Tools Arduino;
        private Thread thread;
        public LendBookWindow(List<User> Users, List<Book> Books, int selectedBook)
        {
            InitializeComponent();
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);

            thread = new Thread(new ThreadStart(LeerRFID));

            this.Usuarios = Users;
            this.Libros = Books;
            this.selectedBook = selectedBook;
        }
        private void TarjetaRFID_Click(object sender, RoutedEventArgs e)
        {
            if (!thread.IsAlive)
            {
                thread = new Thread(new ThreadStart(LeerRFID));
                thread.Start();
            }
        }
        private void cardValidator()
        {
            if (this.rfid != "" && this.rfid != "Arduino desconectado!!")
            {
                if (Usuarios.Exists(usuario => usuario.Rfid == this.rfid))
                {
                    Usuarios.Find(usuario => usuario.Rfid == this.rfid).RequestedBook(Libros, selectedBook);
                    string name = Usuarios.Find(usuario => usuario.Rfid == this.rfid).Name;
                    MessageBox.Show($"Libro {Libros[selectedBook].Title} prestado al usuario {name}.");
                    Arduino.closePort();
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        this.Close();
                    }));
                }
                else
                {
                    MessageBox.Show("La tarjeta no pertenece a ningún usuario, registrala primero", "Prestar libro", MessageBoxButton.OK, MessageBoxImage.Error);
                    Arduino.closePort();
                }
            }
        }
        private void LeerRFID()
        {
            this.rfid = "";
            do
            {
                this.rfid = Arduino.ReadSerial();
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    RFID.Text = this.rfid;
                }));
            }
            while (this.rfid == "" || this.rfid == "Arduino desconectado!!");
            Arduino.closePort();
            cardValidator();
        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Arduino.closePort();
            thread.Abort();
        }
    }
}
