using PersonClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4._2
{
    
    public partial class Form1 : Form
    {
        List<PersonClass.Persona> PersonasList = new List<PersonClass.Persona>();
        DataBase Base = new DataBase();

        public Form1()
        {
            InitializeComponent();

            string a = "Abiturient";
            string s = "Student";
            string t = "Teacher";
            string n = "none";
            PersonCheck.Items.Add(a);
            PersonCheck.Items.Add(s);
            PersonCheck.Items.Add(t);
            PersonCheck.Items.Add(n);

            courseBox.Items.Add(0);
            courseBox.Items.Add(1);
            courseBox.Items.Add(2);
            courseBox.Items.Add(3);
            courseBox.Items.Add(4);
            

        }

      

        public void PersonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e) //ADD_-------------------------------------------------
        {
            int course = 0;
            if(courseBox.SelectedItem != null)
            {
                course = int.Parse(courseBox.SelectedItem.ToString());
            }
            int.TryParse(expBox.Text, out int exxp);
            
            string person = PersonCheck.SelectedItem as string;
            string name = PersonName.Text;
            string fac = textBox1.Text;
            string titl = title.Text;
            DateTime data = BirthDatePick.Value;
            DateTime today = dateTimePicker1.Value;

            if (PersonCheck.SelectedIndex == 0)
            {
                Abiturient ab = new Abiturient();
                ab.addInfoAb(name, data, fac);
                Base.add(ab);
            }
            if (PersonCheck.SelectedIndex == 1)
            {
                Student st = new Student();
                st.addInfoSt(name, data, fac, course);
                Base.add(st);
            }
            if (PersonCheck.SelectedIndex == 2)
            {
                Teacher th = new Teacher();
                th.addInfoTh(name, data, fac, exxp, titl);
                Base.add(th);
            }

        }

        private void PersonCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //facultet
        {

        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void expBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e) //FIND-----------------------------------------
        {
            int? course = courseBox.SelectedItem as int?;
            int.TryParse(expBox.Text, out int exxp);
            string person = PersonCheck.SelectedItem as string;
            string name = PersonName.Text;
            string fac = textBox1.Text;
            string titl = title.Text;
            DateTime data = BirthDatePick.Value;
            DateTime today = dateTimePicker1.Value;

            List<string> inffo = new List<string>();

            if (PersonCheck.SelectedIndex != 3)
            {

                if (PersonCheck.SelectedIndex == 0)
                {
                    PersonasList = Base.FindAbiturient(fac);

                }
                if (PersonCheck.SelectedIndex == 1)
                {
                    PersonasList = Base.FindStudent(course);

                }
                if (PersonCheck.SelectedIndex == 2)
                {
                    PersonasList = Base.FindTeacher(titl, exxp);
                }
            }
            else
            {
                PersonasList = Base.Find(name, data, fac);
                foreach(var item in Base.getAll())
                {
                    if (Base.FindAbiturient(fac).Count != 0)
                    {
                        PersonasList = Base.FindAbiturient(fac);
                    }
                    if (Base.FindStudent(course).Count != 0)
                    {
                        PersonasList = Base.FindStudent(course);
                    }
                    if (Base.FindTeacher(titl, exxp).Count != 0)
                    {
                        PersonasList = Base.FindTeacher(titl, exxp);
                    }
                }
            }
               

            string Information = "";

            foreach (var item in PersonasList)
            {
                Information += item.Info(today) + "\r\n\n";
            }

            foundPerson.Text = Information;
        }

        private void foundPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthDatePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e) //SHOW------------------------------------------
        {
            DateTime today = dateTimePicker1.Value;

            PersonasList = Base.getAll();

            string Information = "";

            foreach (var item in PersonasList)
            {
                Information += item.Info(today) + "\r\n\n";
            }

            foundPerson.Text = Information;
        }

        private void expBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            foundPerson.Clear();
        }

        private void FindByAge_Click(object sender, EventArgs e)
        {
            DateTime today = dateTimePicker1.Value;
            if ((int.TryParse(From.Text, out int from) && (int.TryParse(To.Text, out int to)))){

                foreach (var item in Base.getAll())
                {

                    PersonasList = Base.Find(null,null,null,from,to,today);

                }
            }

            string Information = "";

            foreach (var item in PersonasList)
            {
                Information += item.Info(today) + "\r\n\n";
            }

            foundPerson.Text = Information;
        }

        private void From_TextChanged(object sender, EventArgs e)
        {

        }

        private void To_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
