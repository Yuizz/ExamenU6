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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenU6.Modulos
{
    /// <summary>
    /// Lógica de interacción para UsuariosUserControl.xaml
    /// </summary>
    public partial class UsuariosUserControl : UserControl
    {
        private List<User> Usuarios;
        public UsuariosUserControl(List<User> Users)
        {
            InitializeComponent();
            this.Usuarios = Users;
            listUsuarios.ItemsSource = Users;
        }
        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow AddUser = new AddUserWindow(Usuarios);
            AddUser.Show();
        }

        private void editUser_Click(object sender, RoutedEventArgs e)
        {
            int selectedUser = listUsuarios.SelectedIndex;
            if (selectedUser != -1)
            {
                EditUserWindow EditUser = new EditUserWindow(Usuarios, selectedUser);
                EditUser.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
