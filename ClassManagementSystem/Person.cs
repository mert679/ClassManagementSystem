using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    public class Person
    {
        private string _name;
        private string _surname;
        private int _age;
        private string _gender;
        
        public int Age {
            set {
                if (value < 0) {
                    Console.WriteLine("olamaz"); 
                }
                else { this._age = value; }
                
            }
            get { 
                return this._age;
            }
        }        
        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }
        public string Surname
        {
            set { this._surname = value; }
            get { return this._surname; }
        }
        public string Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }
        public Person(string name, string surname, string gender)
        {
            this._name = name;
            this._surname = surname;
            this._gender = gender;
        }
        public Person(string name,string surname)
        {
            this._name = name;
            this._surname = surname;
        }
        public Person(){}
        public void SuccessMessage()
        {
            Console.WriteLine("{0} {1} isimli kişi kayıt edilmiştir",Name,Surname);
        } 
    }
}
