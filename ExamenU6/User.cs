using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU6
{
    public class User
    {
        private string name;
        private string address;
        private string rfid;
        List<Book> lendedBooks = new List<Book>();
        public User(string name, string address, string rfid)
        {
            this.name = name;
            this.address = address;
            this.rfid = rfid;
        }
        public void RequestedBook(List<Book> Books, int selectedBook)
        {
            Books[selectedBook].Taken = true;
            Books[selectedBook].OwnedBy = this.name;
            this.lendedBooks.Add(Books[selectedBook]);
        }
        public void ReturnBook(List<Book> Books, int selectedBook)
        {
            this.lendedBooks[selectedBook].Taken = false;
            this.lendedBooks[selectedBook].OwnedBy = "";
            int indexLibro = Books.FindIndex(libro => libro.Title == lendedBooks[selectedBook].Title);
            Books[indexLibro] = lendedBooks[selectedBook];
            lendedBooks.Remove(lendedBooks[selectedBook]);
        }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Rfid { get => rfid; set => rfid = value; }
        public List<Book> LendedBooks { get => lendedBooks; set => lendedBooks = value; }
    }
    public class Student:User
    {
        private string ctrlNum;
        public Student(string name, string address, string rfid, string ctrlNum):base(name, address, rfid)
        {
            this.ctrlNum = ctrlNum;
        }
        public string CtrlNum { get => ctrlNum; set => ctrlNum = value; }
    }
    public class Teacher : User
    {
        private string deparment;
        public Teacher(string name, string address, string rfid, string deparment) : base(name, address, rfid)
        {
            this.deparment = deparment;
        }
        public string Deparment { get => deparment; set => deparment = value; }
    }
}
