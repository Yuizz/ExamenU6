using ExamenU6.Ventanas;
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
    /// Lógica de interacción para LibrosUserControl.xaml
    /// </summary>
    public partial class LibrosUserControl : UserControl
    {
        private List<Book> Libros;
        private List<User> Usuarios;
        public LibrosUserControl(List<Book> Books, List<User> Users)
        {
            InitializeComponent();
            this.Libros = Books;
            this.Usuarios = Users;
            listLibros.ItemsSource = this.Libros;
        }

        private void lendBook_Click(object sender, RoutedEventArgs e)
        {
            int selection = listLibros.SelectedIndex;
            if (selection != -1)
            {
                if (Libros[selection].Taken==false)
                {
                    LendBookWindow lendBook = new LendBookWindow(Usuarios, Libros, selection);
                    lendBook.Show();
                }
                else
                {
                    MessageBox.Show("Ese libro ya está prestado", "Libros", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un libro primero", "Libros", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void returnBook_Click(object sender, RoutedEventArgs e)
        {
            ReturnBookWindow returnBook = new ReturnBookWindow(Usuarios, Libros);
            returnBook.Show();
        }

        private void updateList_Click(object sender, RoutedEventArgs e)
        {
            listLibros.ItemsSource = null; 
            listLibros.ItemsSource = this.Libros;
        }
    }
}
