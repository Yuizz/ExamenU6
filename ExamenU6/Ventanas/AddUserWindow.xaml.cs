using System;
using System.Collections.Generic;
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
using System.ComponentModel;
using System.Threading;

namespace ExamenU6
{
    /// <summary>
    /// Ventana para agregar un nuevo usuario, con lectura de RFID por medio de la clase Tools
    /// </summary>
    public partial class AddUserWindow : Window
    {
        private string name;
        private string address;
        private string rfid="";
        private string dato4;
        private string tipo;
        private List<User> Usuarios;
        private Tools Arduino;
        private Thread thread;
        public AddUserWindow(List<User> Users)
        {
            InitializeComponent();
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);

            thread = new Thread(new ThreadStart(LeerRFID));

            this.Usuarios = Users;
        }
        private void nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nombre.Text != null)
            {
                this.name = nombre.Text;
            }
            else
            {
                this.name = "";
            }
        }
        private void direccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (direccion.Text != null)
            {
                this.address = direccion.Text;
            }
            else
            {
                this.address = "";
            }
        }
        private void boxDato4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxDato4.Text != null)
            {
                this.dato4 = boxDato4.Text;
            }
            else
            {
                this.dato4 = "";
            }
        }
        private void TarjetaRFID_Click(object sender, RoutedEventArgs e)
        {
            if (!thread.IsAlive)
            {
                thread = new Thread(new ThreadStart(LeerRFID));
                thread.Start();
            }
        }
        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            this.tipo = "Student";
            Dato4.Text = "Numero de control:";
            boxDato4.Visibility = Visibility.Visible;
        }
        private void btnTeacher_Click(object sender, RoutedEventArgs e)
        {
            this.tipo = "Teacher";
            Dato4.Text = "Departamento:";
            boxDato4.Visibility = Visibility.Visible;
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (this.tipo != null)
            {
                if (this.rfid != "" && this.rfid!="Arduino desconectado!!")
                {
                    if (tipo == "Student")
                    {
                        Usuarios.Add(new Student(this.name, this.address, this.rfid, this.dato4));
                    }
                    else if (tipo == "Teacher")
                    {
                        Usuarios.Add(new Teacher(this.name, this.address, this.rfid, this.dato4));
                    }
                    MessageBox.Show($"Usuario {this.name} añadido.", "Añadir usuario", MessageBoxButton.OK, MessageBoxImage.Information);
                    Arduino.closePort();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debes añadir una tarjeta RFID!", "Añadir usuario", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un tipo de usuario!", "Añadir usuario", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Arduino.closePort();
            thread.Abort();
        }
    }
}
