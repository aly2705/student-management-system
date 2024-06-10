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

namespace Centralizator_Situatii_Studenti
{
    public partial class CourseRegisterForm : Form
    {
        Centralizator centralizator;
        ArrayList selectieCursuri = new ArrayList();

        public CourseRegisterForm(Centralizator centralizator)
        {
            InitializeComponent();
            this.centralizator = centralizator;
            this.initCursuri();

        }

        private void initCursuri()
        {
            Student stud = (Student)centralizator.UtilizatorLogat;
            listView1.Items.Clear();
            int index = 1;
            foreach(Profesor profesor in centralizator.Profesori)
            {
                foreach(Curs curs in profesor.Cursuri)
                {
                    if(!stud.Situatii.Exists(x => x.Curs.Denumire == curs.Denumire))
                    {
                        ListViewItem item = new ListViewItem(index.ToString());
                        index++;
                        item.SubItems.Add(curs.Denumire);
                        item.SubItems.Add(profesor.Nume + " " + profesor.Prenume);
                        item.SubItems.Add(profesor.Id);
                        listView1.Items.Add(item);
                    }
                   
                }
               
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Sunteti sigur? Modificarile vor fi permanente", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                foreach(ListViewItem item in listView1.Items)
                {
                    if (item.Checked)
                    {
                        
                        Curs curs = centralizator.Cursuri.Find(x => x.Denumire == item.SubItems[1].Text);
                        string profesorId = item.SubItems[3].Text;

                        SituatieCurs situatie = new SituatieCurs(curs,profesorId);
                        Student stud = (Student)centralizator.UtilizatorLogat;
                        stud.Situatii.Add(situatie);

                        this.insertSituatieInDB(situatie, stud.Id);
                    }
                }
                //centralizator.serializare();
                this.Close();
            }
        }

        private void insertSituatieInDB(SituatieCurs situatie, string idStudent)
        {
            OleDbConnection conexiune = new OleDbConnection(Centralizator.connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO situatii_curs (idCurs, idStudent, idProfesor) values(@idCurs, @idStudent,'"+situatie.IdProfesor+ "')";
                comanda.Parameters.Add("@idCurs", OleDbType.Numeric, 5).Value = situatie.Curs.Cod;
                comanda.Parameters.Add("@idStudent", OleDbType.Char, 20).Value = idStudent;


                comanda.ExecuteNonQuery();

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
