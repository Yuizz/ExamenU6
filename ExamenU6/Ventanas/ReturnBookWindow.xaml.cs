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

namespace ExamenU6.Ventanas
{
    /// <summary>
    /// Lógica de interacción para ReturnBookWindow.xaml
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        private List<User> Usuarios;
        private List<Book> Libros;
        private Tools Arduino;
        private string rfid;
        public ReturnBookWindow(List<User> Users, List<Book> Books)
        {
            InitializeComponent();
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);
            this.Usuarios = Users;
            this.Libros = Books;
        }

        private void scanCard_Click(object sender, RoutedEventArgs e)
        {
            this.rfid = Arduino.ReadSerial();
            RFIDBox.Text = this.rfid;
            if (this.rfid != "" && this.rfid != "Arduino desconectado!!")
            {
                if (Usuarios.Exists(usuario => usuario.Rfid == this.rfid))
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("La tarjeta no pertenece a ningún usuario, registrala primero", "Prestar libro", MessageBoxButton.OK, MessageBoxImage.Error);
                    Arduino.closePort();
                    this.Close();
                }
            }
        }

        private void devolverLibro_Click(object sender, RoutedEventArgs e)
        {
            int indexBook = listLibros.SelectedIndex;
            if (indexBook != -1)
            {
                int indexUsuario = Usuarios.FindIndex(usuario => usuario.Rfid == this.rfid);
                Usuarios[indexUsuario].ReturnBook(this.Libros, indexBook);
                MessageBox.Show("Libro devuelto", "Devolver libro", MessageBoxButton.OK, MessageBoxImage.Information);
                actualizarTabla();
            }
            else
            {
                MessageBox.Show("Primero selecciona un libro", "Devolver libro", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            Arduino.closePort();
            this.Close();
        }
        void ReturnBookWindow_Closing(object sender, CancelEventArgs e)
        {
            Arduino.closePort();
        }
        private void actualizarTabla()
        {
            listLibros.ItemsSource = null;
            listLibros.ItemsSource = Usuarios.Find(usuario => usuario.Rfid == this.rfid).LendedBooks;
        }
    }
}
