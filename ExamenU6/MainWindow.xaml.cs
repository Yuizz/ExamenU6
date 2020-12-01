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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenU6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> Users = new List<User>();
        List<Book> Books = new List<Book>();
        public MainWindow()
        {
            InitializeComponent();
            Books.Add(new Book() { Title = "Razer y la patatus del poder", Author = "JK Rowling", Editorial = "Salamandra", Taken = true, OwnedBy = "Jugo" });
            Books.Add(new Book() { Title = "El juego de ender", Author = "JK Rowling", Editorial = "Salamandra", Taken = false, OwnedBy = "" });
            Books.Add(new Book() { Title = "Harry Potter", Author = "JK Rowling", Editorial = "Salamandra", Taken = true, OwnedBy = "Jugo" });
            Users.Add(new Student("Jugo", "Tangamandapio", " 0C 74 56 08", "17260671"));
            Users.Add(new Teacher("Julian Gonzalez", "Cima 2", " 0C 68 56 08", "Metal mecánica"));
        }
       
        private void menuUsuarios_Selected(object sender, RoutedEventArgs e)
        {
            MostrarContenido(new UsuariosUserControl(Users));
        }

        private void menuLibros_Selected(object sender, RoutedEventArgs e)
        {
            MostrarContenido(new LibrosUserControl(Books, Users));
        }

        private void menudevLibro_Selected(object sender, RoutedEventArgs e)
        {
            MostrarContenido(null);
        }

        private void menutomarLibro_Selected(object sender, RoutedEventArgs e)
        {
            MostrarContenido(null);
        }
        private void MostrarContenido(UserControl Control)
        {
            Contenedor.Content = null;
            Contenedor.Content = Control;
        }
    }
}
