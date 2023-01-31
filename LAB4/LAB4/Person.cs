using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Person
    {
        private string name;
        private int age;
        private int birthYear;

        public Person(string name, int bYear)
        {
            this.name = name;
            this.birthYear = bYear;
            this.age = 2565 - bYear;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
