using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU6
{
    class Book
    {
        private string title;
        private string author;
        private string editorial;
        private Boolean taken;
        private string ownedBy;
        /*public Book(string title, string author, string editorial)
        {
            this.title = title;
            this.author = author;
            this.editorial = editorial;
        }*/
        public string Title { get; set; }
        public string Author { get; set; }
        public string Editorial { get; set; }
        public Boolean Taken { get; set; }
        public string OwnedBy { get; set; }
        public string Status { 
            get {
                if (this.taken == true) return "Prestado";
                else return "";
            }
            set { this.editorial = value; }
        }
    }
}
