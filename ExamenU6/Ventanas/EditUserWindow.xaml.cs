using ExamenU6.Modulos;
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
    /// Ventana para editar un usuario existente
    /// </summary>
    public partial class EditUserWindow : Window
    {
        private string name;
        private string address;
        private string rfid = "";
        private List<User> Usuarios;
        private int user;
        private Tools Arduino;
        private Thread thread;
        public EditUserWindow(List<User> Users, int selectedUser)
        {
            InitializeComponent();
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);

            thread = new Thread(new ThreadStart(LeerRFID));

            this.Usuarios = Users;
            this.user = selectedUser;

            nombre.Text = Usuarios[user].Name;
            direccion.Text = Usuarios[user].Address;
            RFID.Text = Usuarios[user].Rfid;
            this.rfid = Usuarios[user].Rfid;
        }
        private void nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nombre.Text != null)
            {
                this.name = nombre.Text;
            }
            else
            {
                this.name = null;
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
                this.address = null;
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
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if(this.rfid!="" && this.rfid!="Arduino desconectado!!") 
            {
                Usuarios[user].Name = this.name;
                Usuarios[user].Address = this.address;
                Usuarios[user].Rfid = this.rfid;
                MessageBox.Show($"Usuario {Usuarios[user].Name} editado.", "Editar usuario", MessageBoxButton.OK, MessageBoxImage.Information);
                Arduino.closePort();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes añadir una tarjeta RFID!", "Editar usuario", MessageBoxButton.OK, MessageBoxImage.Warning);
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
