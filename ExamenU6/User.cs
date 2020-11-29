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
        public User(string name, string address, string rfid)
        {
            this.name = name;
            this.address = address;
            this.rfid = rfid;
        }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Rfid { get => rfid; set => rfid = value; }
    }
    class Student:User
    {
        private string ctrlNum;
        public Student(string name, string address, string rfid, string ctrlNum):base(name, address, rfid)
        {
            this.ctrlNum = ctrlNum;
        }
        public string CtrlNum { get => ctrlNum; set => ctrlNum = value; }
    }
    class Teacher : User
    {
        private string deparment;
        public Teacher(string name, string address, string rfid, string deparment) : base(name, address, rfid)
        {
            this.deparment = deparment;
        }
        public string Deparment { get => deparment; set => deparment = value; }
    }
}
