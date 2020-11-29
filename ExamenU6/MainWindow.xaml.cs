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
            Users.Add(new Student("Jugo", "Tangamandapio", "172606", "17260671"));
            AddUserWindow AddUser = new AddUserWindow(Users);
            AddUser.Show();
        }
        public static void ReceiveList(List<User> Usrs)
        {
            //Users = Usrs;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
