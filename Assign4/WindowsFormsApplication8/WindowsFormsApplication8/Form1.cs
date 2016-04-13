using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        Db db;
        public Form1()
        {
            InitializeComponent();
            db = new Db();
        }
        public void displayNames()
        {
            IEnumerator<Person> students = db.GetTable<Person>().GetEnumerator();
            while (students.MoveNext())
            {
                MessageBox.Show(students.Current.name);
            }
        }
        public void displayStudentsNames()
        {
            //search DB using base type
            IEnumerable<Person> students = from s in db.people
                                           where s.type == "S"
                                           select s;
            foreach (Person student in students)
            {
                MessageBox.Show(student.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayNames();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayStudentsNames();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        public void addRecord()
        {
            //insert into DB using subtypes
            Student student = new Student();
            student.name = "Jack";
            student.type = "S";
            student.StudentCode = 555;
            db.GetTable<Person>().InsertOnSubmit(student);
            db.SubmitChanges();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteRecord();
        }

        public void deleteRecord()
        {
            IEnumerable<Person> students = from s in db.people
                                           where s.type == "S"
                                            && s.name == "Jack"
                                           select s;

            db.GetTable<Person>().DeleteAllOnSubmit(students);
            db.SubmitChanges();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        public void updateRecord()
        {
            //each read object has a different type and treated based on this type by linq. it is determined through type.
            var students = db.people.Where(p => p.name == "sherif" && p.type == "S");

            foreach (var person in students)
            {
                ((Student)person).StudentCode = 0;

            }
            db.SubmitChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int y = e.MarginBounds.Top;
            int x0 = e.MarginBounds.Left;
            int increment = 130;
            int x2;

            Person person;
            using (Font font = new Font("Times New Roman", 20))
            {
                e.Graphics.DrawString("Id", font, Brushes.Red, x0, y);
                e.Graphics.DrawString("Name", font, Brushes.Red, x0 + increment, y);
                e.Graphics.DrawString("Std Code", font, Brushes.Red, x0 + (2 * increment), y);
                e.Graphics.DrawString("Type", font, Brushes.Red, x0 + (3 * increment), y);
                e.Graphics.DrawString("Teach Code", font, Brushes.Red, x0 + (4 * increment), y);

                //draw horizontal line
                x2 = x0 + (5 * increment) + 20;
                e.Graphics.DrawLine(Pens.Green, x0 - 10, y + (int)(font.Size * 1.5), x2, y + (int)(font.Size * 1.3));


                y += (int)(font.Size * 1.5);
                IEnumerator<Person> ppl = db.GetTable<Person>().GetEnumerator();
                while (ppl.MoveNext())
                {
                    person = ppl.Current;
                    e.Graphics.DrawString(person.id.ToString(), font, Brushes.Black, x0, y);
                    e.Graphics.DrawString(person.name, font, Brushes.Black, x0 + increment, y);
                    if (person is Student)
                    {
                        e.Graphics.DrawString(((Student)person).StudentCode.ToString(), font, Brushes.Black, x0 + (2 * increment), y);

                    }
                    else
                    {
                        e.Graphics.DrawString("NA", font, Brushes.Black, x0 + (2 * increment), y);

                    }
                    e.Graphics.DrawString(person.type, font, Brushes.Black, x0 + (3 * increment), y);


                    if (person is Teacher)
                    {
                        e.Graphics.DrawString(((Teacher)person).TeacherCode.ToString(), font, Brushes.Black, x0 + (4 * increment), y);

                    }
                    else
                    {
                        e.Graphics.DrawString("NA", font, Brushes.Black, x0 + (4 * increment), y);

                    }

                    y += (int)(font.Size * 2);
                }
            }
            //draw enclosing rectangle
            float width = x2 - x0 + 10;
            float height = y - e.MarginBounds.Top + 10;
            e.Graphics.DrawRectangle(Pens.Green, x0 - 10, e.MarginBounds.Top - 10, width, height);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

      
    }
}

