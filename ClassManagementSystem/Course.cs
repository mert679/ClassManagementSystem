using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    public class Course
    {
        private string _name;
        private int _capacity = 20;
        public int Capacity { get { return this._capacity; } set { this._capacity = value; } }
        public string Name { get { return this._name; }
            set { if (value == null) {
                    Console.WriteLine("You have to fill!");
                }
                else
                {
                    this._name = value;
                }

            }
        }
        public Course(string name){
                this._name = name;
          }

    }
}
