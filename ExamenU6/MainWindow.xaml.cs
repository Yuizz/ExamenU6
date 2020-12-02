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
            Books.Add(new Book("Breve Historia de la Ingeniería Mecánica", "Oscar Mauricio Barajas", "Aleta Ediciones"));
            Books.Add(new Book("Mantenimiento Industrial", "Belén Muñoz Abella", "Editorial Espasa" ));
            Books.Add(new Book("Matemática aplicada al área de la mecánica", "G. Zorzoli", "Austral Editori"));
            Books.Add(new Book("Apuntes de fundamentos físicos de la ingeniería", "Enrique Drake Moyano", "Alpha Decay"));
            Books.Add(new Book("Introducción a la Mecatrónica y los sistemas de medición", "David G. Alciatore", "AlfaOmega"));
            Users.Add(new Student("Julian Gonzalez", "Calle Primera de mayo #3", " 0C 74 56 08", "17260671"));
        }
        private void menuUsuarios_Selected(object sender, RoutedEventArgs e)
        {
            MostrarContenido(new UsuariosUserControl(Users));
        }

        private void menuLibros_Selected(object sender, RoutedEventArgs e)
        {
            MostrarContenido(new LibrosUserControl(Books, Users));
        }
        private void MostrarContenido(UserControl Control)
        {
            Contenedor.Content = null;
            Contenedor.Content = Control;
        }
    }
}
