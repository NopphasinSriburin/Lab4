using System;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            string input_name = this.Name1.Text;
            string input_year = this.BirthYear.Text;
            int iYear = Int32.Parse(input_year);
            //create object from Person class
            Person person = new Person(input_name, iYear);
            this.classroom.addPerson2Class(person);
            //display person
            this.tbListofPerson.Text =
                this.classroom.showAllPersoninClass();
            //display total age of class
            this.tbTotal.Text = "";
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}