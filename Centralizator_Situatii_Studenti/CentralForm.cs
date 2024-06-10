using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Centralizator_Situatii_Studenti
{
    public partial class CentralForm : Form
    {
        public delegate void ClosedEventHandler(object sender, FormClosedEventArgs e);
        Centralizator centralizator = new Centralizator();

        public CentralForm()
        {
            InitializeComponent();

            // Initializare centralizator cu datele stocate in fisierul binar
            // centralizator.deserializare();

            /* Populare centralizator cu mock data
            Curs c1 = new Curs("Programarea aplicatiilor Windows", 4, 50, 50);
            Curs c2 = new Curs("Programare Orientata Obiect", 5,  50, 50);
            Curs c3 = new Curs("Baze de Date", 4,  50, 50);
            Curs c4 = new Curs("SGBD", 5,  50, 50);
            Curs c5 = new Curs("Programare JAVA", 4, 50, 50);
            Curs c6 = new Curs("Macroeconomie cantitativa", 3, 50, 50);

            
            Profesor p1 = new Profesor("Popa", "Maria", 'F', new List<Curs> { c1,c5 });
            Profesor p2 = new Profesor("Enea", "Vlad", 'M', new List<Curs> { c2 });

            List<SituatieCurs> situatii = new List<SituatieCurs>();
            situatii.Add(new SituatieCurs(c1, "P1002", 7, 10));
            situatii.Add(new SituatieCurs(c2, "P1003", 0, 0));

            List<SituatieCurs> situatii2 = new List<SituatieCurs>();
            situatii2.Add(new SituatieCurs(c5, "P1002", 1, 5));
            situatii2.Add(new SituatieCurs(c2, "P1003", 5, 5));

            Student s1 = new Student("Sima", "Alina", 'F', 2, 1063, 'E', Student.FormaFinantare.Buget, Student.Specializari.Informatica, situatii);
            Student s2 = new Student("Oana", "Alexandru", 'M', 3, 1072, 'B', Student.FormaFinantare.Buget, Student.Specializari.Cibernetica, situatii2);
           
            centralizator = new Centralizator(new List<Student> { s1, s2 }, new List<Profesor> { p1, p2 }, new List<Curs> { c1, c2, c3, c4, c5, c6 });
            */

            // Initializare centralizator cu date din AccessDB
            centralizator.initDateFromAccessDB();

            // Ascundere optiuni protejate
            veziCursuriToolStripMenuItem.Visible = false;
            veziUtilizatoriToolStripMenuItem.Visible = false;
            administrareToolStripMenuItem.Visible = false;
            situatiiCursToolStripMenuItem.Visible = false;
            inscriereCursToolStripMenuItem.Visible = false;
            validareNoteToolStripMenuItem.Visible = false;
            veziGraficeToolStripMenuItem.Visible = false;
            oferaRatingMenuItem.Visible = false;
            this.hidePanels();

            myDataControl1.Text = "";
        }

       

        private void veziUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panelShowUsers.Visible = true;
            lvStudenti.Items.Clear();
            lvProfesori.Items.Clear();
            foreach (Student student in centralizator.Studenti)
            {
                ListViewItem item = new ListViewItem(student.Id);
                item.SubItems.Add(student.Nume +" "+ student.Prenume);
                item.SubItems.Add(student.Sex.ToString());
                item.SubItems.Add(student.An.ToString());
                item.SubItems.Add(student.Grupa.ToString());
                item.SubItems.Add(student.Serie.ToString());
                item.SubItems.Add(student.Finantare.ToString());
                item.SubItems.Add(student.Specializare.ToString());
                lvStudenti.Items.Add(item);
            }
            
            foreach (Profesor profesor in centralizator.Profesori)
            {
                ListViewItem item = new ListViewItem(profesor.Id);
                item.SubItems.Add(profesor.Nume + " " + profesor.Prenume);
                item.SubItems.Add(profesor.Sex.ToString());
                item.SubItems.Add(profesor.listaCursuriPredate());
                lvProfesori.Items.Add(item);
            }

        }

        private void veziCursuriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panelShowUsers.Visible = false;
            panelShowCourses.Visible = true;
            lvCursuri.Items.Clear();
            foreach (Curs curs in centralizator.Cursuri)
            {
                ListViewItem item = new ListViewItem(curs.Cod.ToString());
                item.SubItems.Add(curs.Denumire);
                item.SubItems.Add(curs.NrCredite.ToString());
                item.SubItems.Add(curs.PondereSeminar.ToString());
                item.SubItems.Add(curs.PondereExamen.ToString());
                lvCursuri.Items.Add(item);
            }

        }

        private void administrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminUI adminUI = new AdminUI(centralizator);
            adminUI.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthForm_Closing(object sender, FormClosedEventArgs e)
        {
            if (centralizator.UtilizatorLogat == null) return;

            this.hidePanels();
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Admin) adapteazaMeniu_Admin();
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Student) adapteazaMeniu_Student();
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Profesor) adapteazaMeniu_Profesor();


            myDataControl1.Text = centralizator.UtilizatorLogat.Nume+" "+centralizator.UtilizatorLogat.Prenume;

        }

        private void autentificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm auth = new AuthForm(centralizator, new ClosedEventHandler(AuthForm_Closing));
            auth.ShowDialog();
        }

        private void hidePanels()
        {
            panelShowUsers.Visible = false;
            panelShowCourses.Visible = false;
            panelShowSituatii.Visible = false;
        }
        private void adapteazaMeniu_Admin()
        {
           
            veziCursuriToolStripMenuItem.Visible = true;
            veziUtilizatoriToolStripMenuItem.Visible = true;
            administrareToolStripMenuItem.Visible = true;
            situatiiCursToolStripMenuItem.Visible = false;
            inscriereCursToolStripMenuItem.Visible = false;
            validareNoteToolStripMenuItem.Visible = false;
            veziGraficeToolStripMenuItem.Visible = false;
            oferaRatingMenuItem.Visible = false;
        }
        private void adapteazaMeniu_Student()
        {
            veziCursuriToolStripMenuItem.Visible = false;
            veziUtilizatoriToolStripMenuItem.Visible = false;
            administrareToolStripMenuItem.Visible = false;
            situatiiCursToolStripMenuItem.Visible = true;
            inscriereCursToolStripMenuItem.Visible = true;
            validareNoteToolStripMenuItem.Visible = false;
            veziGraficeToolStripMenuItem.Visible = false;
            oferaRatingMenuItem.Visible = true;
        }
        private void adapteazaMeniu_Profesor()
        {
            veziCursuriToolStripMenuItem.Visible = false;
            veziUtilizatoriToolStripMenuItem.Visible = false;
            administrareToolStripMenuItem.Visible = false;
            situatiiCursToolStripMenuItem.Visible = false;
            inscriereCursToolStripMenuItem.Visible = false;
            validareNoteToolStripMenuItem.Visible = true;
            veziGraficeToolStripMenuItem.Visible = true;
            oferaRatingMenuItem.Visible = false;
        }

        private void situatiiCursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(centralizator.UtilizatorLogat.Rol == User.Roles.Student)
            {
                Student stud = (Student)centralizator.UtilizatorLogat;
                panelShowSituatii.Visible = true;
                lvSituatii.Items.Clear();

                panelShowSituatii.Visible = true;
                foreach(SituatieCurs situatie in stud.Situatii)
                {
                    ListViewItem item = new ListViewItem(situatie.Curs.Denumire);
                    Profesor profesor = centralizator.Profesori.Find(x => ((Profesor)x).Id == situatie.IdProfesor);
                    item.SubItems.Add(profesor.Nume + " " + profesor.Prenume);
                    item.SubItems.Add(situatie.Curs.NrCredite.ToString());
                    
                    if (situatie.NotaExamen > 0 && situatie.NotaSeminar > 0)
                    {
                        if (situatie.calculeazaNotaFinala() >= 5)
                        {
                            item.SubItems.Add("Complet");
                            item.SubItems.Add(situatie.NotaSeminar.ToString());
                            item.SubItems.Add(situatie.NotaExamen.ToString());
                            item.SubItems.Add(situatie.calculeazaNotaFinala().ToString());
                        }
                        else
                        {
                            item.SubItems.Add("Restanta");
                            item.SubItems.Add(situatie.NotaSeminar.ToString());
                            item.SubItems.Add(situatie.NotaExamen.ToString());
                            item.SubItems.Add(situatie.calculeazaNotaFinala().ToString());
                        }
                    }
                    else
                    {
                        item.SubItems.Add("In desfasurare");
                        item.SubItems.Add("-");
                        item.SubItems.Add("-");
                        item.SubItems.Add("-");
                    }
                    lvSituatii.Items.Add(item);
                }
                
            }
        }

        private void inscriereCursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Student)
            {
                CourseRegisterForm form = new CourseRegisterForm(centralizator);
                this.hidePanels();
                form.ShowDialog();
            }
        }

        private void oferaRatingMenuItem_Click(object sender, EventArgs e)
        {
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Student)
            {
                CourseRatingsForm form = new CourseRatingsForm(centralizator);
                this.hidePanels();
                form.ShowDialog();
            }
        }

        private void validareNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Profesor)
            {
                StudentsGradesForm form = new StudentsGradesForm(centralizator);
                this.hidePanels();
                form.ShowDialog();
            }
        }
        private void veziGraficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (centralizator.UtilizatorLogat.Rol == User.Roles.Profesor)
            {
                StudentGraphs form = new StudentGraphs(centralizator);
                this.hidePanels();
                form.ShowDialog();
            }
        }


    }
}
