using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_Objact
{
    public class Person
    {
        private string Name;
        private int Age;
        private int BirthYear;
        private double GPA;

        public Person(string name, int iBY , double gpa) 
        {
            this.Name = name;
            this.BirthYear = iBY;
            this.Age = 2566 - iBY;
            this.GPA = gpa ;
        }
        public int getAge() 
        {
            return this.Age;
        }
        public string getName() 
        {
            return this.Name;
        }
        public double getGPA()
        {
            return GPA;
        }

    }
}
