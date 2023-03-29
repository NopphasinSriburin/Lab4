namespace ClassRoom_Objact
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // input textbox to list
            string iName = tbName.Text;
            string iYear = tbBirth.Text;
            string iGpa = tbGPA.Text;
            int Year = Int32.Parse(iYear);
            double Gpa = Double.Parse(iGpa);

            Person person = new Person(iName, Year, Gpa);

            this.classroom.addPerson2Class(person);
            Alldataname.Text = classroom.showAllPersoninClasss();
            AllAgebox.Text = classroom.SumAllYearClass();
            GpaAvg.Text = classroom.avgMaxGPA();
            GpaMax.Text = classroom.MaxGPA();
            GpaMin.Text = classroom.MinGPA();
            Namemax.Text = classroom.maxGPAName1();
            Namemin.Text = classroom.minGPAName1();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}