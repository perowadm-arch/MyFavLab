using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApp4._2;

namespace PersonClass
{
    /// <summary>
    /// Базовий клас для створення змінної персони
    /// </summary>
    public abstract class Persona
    {
        public Persona() { }

        /// <summary>
        /// Змінна для запису дати народження
        /// </summary>
        private DateTime BirthDate;

        /// <summary>
        /// Змінна для запису імені
        /// </summary>
        private string Name;

        /// <summary>
        /// Змінна для назви факультету
        /// </summary>
        private string Facultet;


        /// <summary>
        /// Функція для виводу інформації про персону в один рядок
        /// </summary>
        /// <returns>Рядок з інформацією про вказану персону</returns>
        /// <param name = "Today">Змінна типу DateTime як нинішню дату для розрахунку віку.</param>
        public abstract string Info(DateTime Today);

        /// <summary>
        /// Дата народження
        /// </summary>
        public DateTime Date { get { return BirthDate; } set { BirthDate = value; } }

        /// <summary>
        /// Ім'я
        /// </summary>
        public string PName { get { return Name; } set { Name = value; } }

        /// <summary>
        /// Факультет
        /// </summary>
        public string Fac { get { return Facultet; } set { Facultet = value; } }


        /// <summary>
        /// Функція для підрахунку віку персони за вказаною датою народження та сьогоднішньою датою
        /// </summary>
        /// <returns>Ціле число, вік персони</returns>
        /// <param name = "Today">Змінна типу DateTime як нинішню дату для розрахунку віку.</param>
        public int seeAge(DateTime Today)
        {
            return Today.Year - Date.Year;
        }

    }

    /// <summary>
    /// Клас-нащадок Person для створення змінної студента
    /// </summary>
    public class Student : Persona
    {
        public Student()
        {

        }

        /// <summary>
        /// Змінна для значення курсу студента
        /// </summary>
        private int Course;

        /// <summary>
        /// Номер курсу
        /// </summary>
        public int CourseNum { get { return Course; } set { Course = value; } }



        /// <summary>
        /// Функція для втводу інформації про СТУДЕНТА в один рядок
        /// </summary>
        /// <returns>Рядок з інформацією про вказаного студента</returns>
        /// <param name = "Today">Змінна типу DateTime як нинішню дату для розрахунку віку.</param>
        public override string Info(DateTime Today)
        {
            string c = Course.ToString();
            int ageStud = seeAge(Today);
            string a = ageStud.ToString();
            string n = PName;
            
            return $"Name: {n};\r\nAge: {a};\r\nCourse: {c};\r\nFacultet: {Fac};\r\n\n";
        }

        /// <summary>
        /// Функція для запису інформації про СТУДЕНТА в один рядок
        /// </summary>
        /// <param name = "name">Рядок ім'я</param>
        /// <param name = "bd">Дата народження типу DateTime</param>
        /// <param name = "fac">Рядок факультету</param>
        /// <param name = "course">Ціле число курсу</param>
        public void addInfoSt(string name, DateTime bd,  string fac, int course)
        {
            this.PName = name;
            this.Fac = fac;
            this.Date = bd;
            this.CourseNum = course;
        }
    }

    /// <summary>
    /// Клас-нащадок Person для створення змінної абітурієнта
    /// </summary>
    public class Abiturient : Persona
    {
        public Abiturient()
        {

        }

        /// <summary>
        /// Функція для виводу інформації про АБІТУРІЄНТА в один рядок
        /// </summary>
        /// <returns>Рядок з інформацією про вказаного абітурієнта</returns>
        /// <param name = "Today">Змінна типу DateTime як нинішню дату для розрахунку віку.</param>
        public override string Info(DateTime Today)
        {
            int ageStud = seeAge(Today);
            string a = ageStud.ToString();
            string n = PName;

            return $"Name: {n};\r\nAge: {a};\r\nFacultet: {Fac}\r\n\n";
        }

        /// <summary>
        /// Функція для запису інформації про АБІТУРІЄНТА в один рядок
        /// </summary>
        /// <param name = "name">Рядок ім'я</param>
        /// <param name = "bd">Дата народження типу DateTime</param>
        /// <param name = "fac">Рядок факультету</param>
        public void addInfoAb(string name, DateTime bd, string fac)
        {

            this.PName = name;
            this.Date = bd;
            this.Fac = fac;
            
        }
    }

    /// <summary>
    /// Клас-нащадок Person для створення змінної викладача
    /// </summary>
    public class Teacher : Persona
    {
        public Teacher()
        {

        }


        /// <summary>
        /// Змінна для запису посади викладача
        /// </summary>
        private string Title;

        /// <summary>
        /// Змінна для запису кількості років досвіду викладача
        /// </summary>
        private int Exp;



        /// <summary>
        /// Посада
        /// </summary>
        public string TitleTeach { get { return Title; } set { Title = value; } }

        /// <summary>
        /// Роки досвіду
        /// </summary>
        public int YearsExperience { get { return Exp; } set { Exp = value; } }

        /// <summary>
        /// Функція для виводу інформації про ВИКЛАДАЧА в один рядок
        /// </summary>
        /// <returns>Рядок з інформацією про вказаного викладача</returns>
        /// <param name = "Today">Змінна типу DateTime як нинішню дату для розрахунку віку.</param>
        public override string Info(DateTime Today)
        {
            string e = Exp.ToString();
            int ageStud = seeAge(Today);
            string a = ageStud.ToString();
            string n = PName;
            string y = YearsExperience.ToString();

            return $"Name: {n};\r\nAge: {a};\r\nTitle: {TitleTeach};\r\nFacultet: {Fac};\r\nExperience: {y};\r\n\n";
        }

        /// <summary>
        /// Функція для виводу інформації про ВИКЛАДАЧА в один рядок
        /// </summary>
        /// <param name = "name">Рядок ім'я</param>
        /// <param name = "bd">Дата народження типу DateTime</param>
        /// <param name = "fac">Рядок факультету</param>
        /// <param name = "exp">Ціле число досвіду</param>
        /// <param name = "titl">Рядок посади</param>
        public void addInfoTh(string name, DateTime bd, string fac, int exp, string titl)
        {
            this.PName = name;
            this.Fac = fac;
            this.Date = bd;
            this.YearsExperience = exp;
            this.TitleTeach = titl;
        }
    }

    /// <summary>
    /// Клас для зберігання всієї інформації про персон різних типів (абітурієнтів, студентів, викладачів)
    /// </summary>
    public class DataBase
    {
        public DataBase() { }

        /// <summary>
        /// Список типу Person для зберігання інформації про персон різних типів
        /// </summary>
        private List<Persona> storage = new List<Persona>();

        /// <summary>
        /// Функція для додавання нової персони в список storage
        /// </summary>
        /// <param name="persona">Змінна типу Persona.</param>
        public void add(Persona persona)
        {
            storage.Add(persona);
        }

        /// <summary>
        /// Функція для видобування всієї інформації з списку storage
        /// </summary>
        /// <returns>Список інформації про персон, записаних в список</returns>
        public List<Persona> getAll()
        {
            return storage;
        }

        /// <summary>
        /// Функція для знаходження інформації про персону за заданими параметрами
        /// </summary>
        /// <returns>Список інформації про персон, з якими відбувся збіг після пошуку</returns>
        /// <param name = "name">Необов'язковий рядок ім'я</param>
        /// <param name = "birthdate">Необов'язкова дата народження типу DateTime</param>
        /// <param name = "fac">Необов'язковий рядок факультету</param>
        /// <param name = "from">Необов'язкове ціле число нижньої границі діапазону</param>
        /// <param name = "to">Необов'язкове ціле число вищої границі діапазону</param>
        /// <param name = "Today">Змінна типу DateTime як нинішню дату для розрахунку віку.</param>

        public List<Persona> Find(string name = null, DateTime? birthdate = null, string fac = null, int? from = null, int? to = null, DateTime? Today = null)
        {
            List<Persona> tempStorage = new List<Persona>();
            

            foreach (var item in storage)
            {
                //bool p = true;
                bool pname = false;
                bool pbd = false;
                bool pfac = false;
                bool findbydia = false;

                if (name != null)
                {
                    if (item.PName != name)
                    {
                        pname = false;
                        //p = false;
                    }
                    else
                    {
                        pname = true;

                    }
                }

                if (birthdate != null)
                {
                    if (item.Date != birthdate)
                    {
                        pbd = false;
                        //p = false;
                    }
                    else
                    {
                        pbd = true;

                    }
                }

                if (fac != null)
                {
                    if (item.Fac != fac)
                    {
                        pfac = false;

                    }
                    else
                    {
                        pfac = true;

                    }
                }

                if ((from != null) && (to != null))
                {
                    if (!(from <= item.seeAge((DateTime)Today)) && !(item.seeAge((DateTime)Today) >= to))
                    {
                        findbydia = false;
                    }
                    else
                    {
                        findbydia = true;

                    }
                }

                if (pname || pbd || pfac || findbydia)
                {
                    tempStorage.Add(item);
                }

            }


            return tempStorage;
        }

        /// <summary>
        /// Функція для знаходження інформації про конкретно студентів за заданими параметрами
        /// </summary>
        /// <returns>Список інформації про студентів, з якими відбувся збіг після пошуку</returns>
        /// <param name = "course">Необов'язкове ціле число курсу</param>
        
        public List<Persona> FindStudent(int? course = null)
        {

            List<Persona> tempStorage = new List<Persona>();
            

            foreach (var item in storage)
            {
                bool pcourse = false;
                

                if (item is Student student)
                {
                    

                    if (course != null)
                    {
                        if (student.CourseNum != course)
                        {
                            pcourse = false;

                        }
                        else
                        {
                            pcourse = true;
                        }
                    }

                    

                    if (pcourse)
                    {
                        student = (Student)item;
                        tempStorage.Add(student);
                    }
                }

                
            }

            return tempStorage;
        }

        /// <summary>
        /// Функція для знаходження інформації про конкретно абітурієнта за заданими параметрами
        /// </summary>
        /// <returns>Список інформації про абітурієнтів, з якими відбувся збіг після пошуку</returns>
        /// <param name = "fac">Необов'язковий рядок факультету</param>
        public List<Persona> FindAbiturient(string fac = null)
        {
            List<Persona> tempStorage = new List<Persona>();
            

            foreach (var item in storage)
            {
                bool pfac = false;

                if (item is Abiturient abiturient)
                {
                    

                    if (fac != null)
                    {
                        if (abiturient.Fac != fac)
                        {
                            pfac = false;

                        }
                        else
                        {
                            pfac = true;
                        }
                    }

                    if (pfac)
                    {
                        abiturient = (Abiturient)item;
                        tempStorage.Add(abiturient);
                    }
                }

                
            }

            return tempStorage;
        }

        /// <summary>
        /// Функція для знаходження інформації про конкретно викладача за заданими параметрами
        /// </summary>
        /// <returns>Список інформації про викладачів, з якими відбувся збіг після пошуку</returns>
        /// <param name = "title">Необов'язковий рядок посади</param>
        /// <param name = "exp">Необов'язкове ціле число досвіду</param>
        public List<Persona> FindTeacher(string title = null, int? exp = null)
        {

            List<Persona> tempStorage = new List<Persona>();
            

            foreach (var item in storage)
            {


                bool ptitle = false;
                bool pexp = false;

                if (item is Teacher teacher)
                {
                    


                    if(title != null)
                    {
                        if(teacher.TitleTeach != title)
                        {
                            ptitle = false;
                        }
                        else
                        {
                            ptitle = true;
                        }
                    }

                    if (exp != null)
                    {
                        if (teacher.YearsExperience != exp)
                        {
                            pexp = false;
                        }
                        else
                        {
                            pexp = true;
                        }
                    }

                    if (ptitle || pexp)
                    {
                        teacher = (Teacher)item;
                        tempStorage.Add(teacher);
                    }

                }


            }

            return tempStorage;
        }




    }

}
