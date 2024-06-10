using System;
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
    public partial class CourseRatingsForm : Form
    {
        Student student;
        Centralizator centralizator;
        public CourseRatingsForm(Centralizator centralizator)
        {
            InitializeComponent();

            this.student = (Student)centralizator.UtilizatorLogat;
            this.centralizator = centralizator;

            this.prepareListView();
        }

        private void prepareListView()
        {
            listView1.Items.Clear();
            foreach(SituatieCurs situatie in student.Situatii)
            {
                if(situatie.getStatus() == SituatieCurs.Status.InDesfasurare && !centralizator.Ratings.ContainsKey(situatie))
                {

                    ListViewItem itm = new ListViewItem(situatie.Curs.Denumire);
                    Profesor prof = centralizator.Profesori.Find(x => x.Id == situatie.IdProfesor);
                    itm.SubItems.Add(prof.Nume + " " + prof.Prenume);
                    itm.SubItems.Add(prof.Id);
                    listView1.Items.Add(itm);
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            
            string materie = listView1.FocusedItem.SubItems[0].Text;
            string materiePrescurtata = "";
            if (materie.Split(' ').Length > 1)
            {
                string[] cuvinte = materie.Split(' ');
                for(int i= 0; i < cuvinte.Length; i++)
                {
                    cuvinte[i].ToUpper();
                    materiePrescurtata += cuvinte[i][0];
                }
            }
            else materiePrescurtata = materie;
            string text = materiePrescurtata +
                "-"+ listView1.FocusedItem.SubItems[1].Text;
            Graphics gr = ((Panel)sender).CreateGraphics();
            gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(40, 50, 200, 50));
            gr.DrawString(text, this.Font, new SolidBrush(Color.Black), 40, 50);


            DialogResult res = MessageBox.Show("Adaugati ratingul?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res != DialogResult.OK) 
            {
                gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(40, 50, 200, 50));
                return;
            }
            string profId = listView1.FocusedItem.SubItems[2].Text;
            if ((Panel)sender == panelRating1)
                this.adaugaRating(materie, profId, 1);
            else if ((Panel)sender == panelRating2)
                this.adaugaRating(materie, profId, 2);
            else if ((Panel)sender == panelRating3)
                this.adaugaRating(materie, profId, 3);
            else if ((Panel)sender == panelRating4)
                this.adaugaRating(materie, profId, 4);
            else if ((Panel)sender == panelRating5)
                this.adaugaRating(materie, profId, 5);

            if (e.Effect == DragDropEffects.Move)
            {
                listView1.Items.Remove(listView1.FocusedItem);
            }

        }


        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.DoDragDrop(listView1.FocusedItem,
                    DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void adaugaRating(string denumireCurs, string profesorId, int rating)
        {
            SituatieCurs situatie = student.Situatii.Find(s => 
            s.Curs.Denumire == denumireCurs
            && s.IdProfesor == profesorId);
            centralizator.Ratings.Add(situatie, rating);
            this.updateRatingInDB(situatie, student.Id, profesorId, rating);
            //centralizator.serializare();
        }

        private void updateRatingInDB(SituatieCurs situatie, string idStudent, string idProfesor, int rating)
        {
            OleDbConnection conexiune = new OleDbConnection(Centralizator.connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "UPDATE situatii_curs set rating=@rating where idCurs="+situatie.Curs.Cod+" and idProfesor='" + idProfesor + "' and idStudent=@idStudent";

                comanda.Parameters.Add("@rating", OleDbType.Numeric, 5).Value = rating;
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
