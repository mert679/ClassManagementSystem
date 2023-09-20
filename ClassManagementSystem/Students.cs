using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ClassManagementSystem
{
    class Students:Person
    {
        private static int nextId = 1;
        private int _id;
        
        public int Id {  get { return _id; } 
            set { _id = value; }
        }
        public Students(string name,string surname,string gender):base(name,surname,gender)
        {
            Id = nextId++;
        }
        public Students(int id, string name, string surname, string gender) : base(name, surname, gender)
        {
            Id = id;
        }

    }
}
