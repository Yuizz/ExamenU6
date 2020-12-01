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
using ExamenU6.Modulos;

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
        public EditUserWindow(List<User> Users, int selectedUser)
        {
            InitializeComponent();
            Arduino = new Tools();
            Arduino.OpenPort("COM4", 9600);

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
            this.rfid = Arduino.ReadSerial();
            RFID.Text = this.rfid;
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
            Arduino.closePort();
            this.Close();
        }
        void EditUserWindow_Closing(object sender, CancelEventArgs e)
        {
            Arduino.closePort();
        }
    }
}
