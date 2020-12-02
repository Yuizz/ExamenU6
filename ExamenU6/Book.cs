using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU6
{
    public class Book
    {
        private string title;
        private string author;
        private string editorial;
        private Boolean taken;
        private string ownedBy;
        public Book(string title, string author, string editorial)
        {
            this.title = title;
            this.author = author;
            this.editorial = editorial;
        }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public Boolean Taken { get => taken; set => taken = value; }
        public string OwnedBy { get => ownedBy; set => ownedBy = value; }
        public string Status { 
            get {
                if (this.taken == true) return "Prestado";
                else return "En biblioteca";
            }
            set { this.editorial = value; }
        }
    }
}
