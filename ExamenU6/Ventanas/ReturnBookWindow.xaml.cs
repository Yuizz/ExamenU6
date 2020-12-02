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

namespace ExamenU6.Ventanas
{
    /// <summary>
    /// Ventana que se encarga de regresar un libro seleccionado
    /// </summary>
    public partial class ReturnBookWindow : Window
    {
        private List<User> Usuarios;
        private List<Book> Libros;
        private string rfid;
        private Tools Arduino;
        private Thread thread;
        public ReturnBookWindow(List<User> Users, List<Book> Books)
        {
            InitializeComponent();
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);

            thread = new Thread(new ThreadStart(LeerRFID));

            this.Usuarios = Users;
            this.Libros = Books;
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
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("La tarjeta no pertenece a ningún usuario, registrala primero", "Devolver libro", MessageBoxButton.OK, MessageBoxImage.Error);
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
        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            Arduino.closePort();
            this.Close();
        }
        private void actualizarTabla()
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                listLibros.ItemsSource = null;
                listLibros.ItemsSource = Usuarios.Find(usuario => usuario.Rfid == this.rfid).LendedBooks;
                usuario.Text = null;
                usuario.Text = $"Nombre del usuario: {Usuarios.Find(usuario => usuario.Rfid == this.rfid).Name}";
            }));
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Arduino.closePort();
            thread.Abort();
        }
    }
}
