using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centralizator_Situatii_Studenti
{
    public partial class StudentsGradesForm : Form
    {
        Centralizator centralizator;
        Curs[] cursuriProfesor;
        public StudentsGradesForm(Centralizator centralizator)
        {
            InitializeComponent();
            this.centralizator = centralizator;


            List<Curs> cursuriProf = ((Profesor)centralizator.UtilizatorLogat).Cursuri;
            Curs[] cursuriVector = new Curs[cursuriProf.Count];
            for (int i = 0; i < cursuriProf.Count; i++)
            {
                cursuriVector[i] = cursuriProf[i];
            }
            this.cursuriProfesor = cursuriVector;
            cbCurs.Items.AddRange(cursuriVector);
        }

        private void cbCurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tbId.Clear();
            tbSeminar.Clear();
            tbExamen.Clear();
            listView1.Visible = true;
            panelGrades.Visible = true;
            int index = cbCurs.SelectedIndex;
            string profesorId = ((Profesor)centralizator.UtilizatorLogat).Id;


            List<Student> validStuds = centralizator.Studenti.FindAll(x =>
            x.Situatii.Exists(y => !y.completa() && y.Curs.Denumire == cursuriProfesor[index].Denumire && y.IdProfesor == profesorId));

            foreach(Student student in validStuds)
            {
                ListViewItem item = new ListViewItem(student.Id);
                item.SubItems.Add(student.Nume + " " + student.Prenume);
                listView1.Items.Add(item);
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbSeminar.Text == "" || tbExamen.Text == "")
            {
                if (tbId.Text == "") errorProvider1.SetError(tbId, "Introduceti id studentului!");
                if (tbSeminar.Text == "") errorProvider1.SetError(tbSeminar, "Introduceti nota de seminar a studentului!");
                if (tbExamen.Text == "") errorProvider1.SetError(tbExamen, "Introduceti nota de examen a studentului!");
               
            }
            else
            {
                errorProvider1.Clear();
                try
                {

                    string idStud = tbId.Text;

                    float notaSeminar = Convert.ToSingle(tbSeminar.Text);
                    float notaExamen = Convert.ToSingle(tbExamen.Text);

                    if(notaSeminar < 0 || notaSeminar >10)
                    {
                        errorProvider1.SetError(tbSeminar, "Nota trebuie sa fie curprinsa intre 1 si 10!");
                        return;
                    }
                    if (notaExamen < 0 || notaExamen > 10)
                    {
                        errorProvider1.SetError(tbExamen, "Nota trebuie sa fie curprinsa intre 1 si 10!");
                        return;
                    }

                    int index = cbCurs.SelectedIndex;
                    string profesorId = ((Profesor)centralizator.UtilizatorLogat).Id;

                    Student stud = centralizator.Studenti.Find(x => x.Id == idStud &&
                    x.Situatii.Exists(y => y.Curs.Denumire == cursuriProfesor[index].Denumire && y.IdProfesor == profesorId));

                    if (stud == null)
                    {
                        errorProvider1.SetError(tbId, "Id invalid! Verificati lista alaturata!");
                    }
                    else
                    {
                        SituatieCurs situatieDeModificat = stud.Situatii
                       .Find(y => y.Curs.Denumire == cursuriProfesor[index].Denumire && y.IdProfesor == profesorId);
                        situatieDeModificat.NotaSeminar = notaSeminar;
                        situatieDeModificat.NotaExamen = notaExamen;

                        this.updateSituatieInDB(situatieDeModificat, stud.Id);
                        //centralizator.serializare();

                        tbId.Clear();
                        tbSeminar.Clear();
                        tbExamen.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
        }

        private void tbExamen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == (char)8 || e.KeyChar == '.') 
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void updateSituatieInDB(SituatieCurs situatie, string idStudent)
        {
            OleDbConnection conexiune = new OleDbConnection(Centralizator.connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "UPDATE situatii_curs set notaSeminar=@notaSeminar, notaExamen=@notaExamen where idCurs="+situatie.Curs.Cod+" and idProfesor='" + centralizator.UtilizatorLogat.Id + "' and idStudent=@idStudent";

                comanda.Parameters.Add("@notaSeminar", OleDbType.Numeric, 5).Value = situatie.NotaSeminar;
                comanda.Parameters.Add("@notaExamen", OleDbType.Numeric, 5).Value = situatie.NotaExamen;
                comanda.Parameters.Add("@idStudent", OleDbType.Char, 20).Value = idStudent;
                


                int numUpd = comanda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
