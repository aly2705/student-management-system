using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Centralizator_Situatii_Studenti
{
    public partial class StudentGraphs : Form
    {
        Centralizator centralizator;

        int[] valoriGrafic = new int[6];
        bool vb = false;
        int nrElem = 0;
        Graphics gr;
        Color graphicsColor = Color.LightBlue;

        string[] statusesLabels = new string[] { "In desfasurare", "Complet", "Restanta" };
        string[] studTypesLabels = new string[] { "Inscrisi", "Total" };
        string[] ratingLabels = new string[] { "1 star", "2 stars", "3 stars", "4 stars", "5 stars" };

        public StudentGraphs(Centralizator centralizator)
        {
            InitializeComponent();
            this.centralizator = centralizator;

            List<Curs> cursuriProf = ((Profesor)centralizator.UtilizatorLogat).Cursuri;
            string[] cursuriVector = new string[cursuriProf.Count];
            for (int i = 0; i < cursuriProf.Count; i++)
            {
                cursuriVector[i] = cursuriProf[i].Denumire;
            }
            cbCurs.Items.AddRange(cursuriVector);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb)
            {
                gr = e.Graphics;
                const int marg = 10;

                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg,
                       panel1.ClientRectangle.Y + 2 * marg,
                       panel1.ClientRectangle.Width - 2 * marg,
                       panel1.ClientRectangle.Height - 3 * marg);
                Pen pen = new Pen(Color.White, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 2;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = valoriGrafic.Max();

                Brush br = new SolidBrush(graphicsColor);
                Brush black = new SolidBrush(Color.Black);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - rec.Height / vMax * valoriGrafic[i]),
                        (int)latime,
                        (int)(rec.Height / vMax * valoriGrafic[i]));

                    string label = ""; double offset = 0;
                    if (cbCriteriu.Text == "Status Finalizare")
                    {
                        label = statusesLabels[i];
                        offset = 5;
                    }
                    else if (cbCriteriu.Text == "Inscrieri Curs vs Total Studenti")
                    {
                        label = studTypesLabels[i];
                        offset = latime / 4;
                    }
                    else if (cbCriteriu.Text == "Distributie Rating")
                    {
                        label = ratingLabels[i];
                        offset = 0;
                    }
                    label += ": " + valoriGrafic[i] + " studenti";

                    gr.DrawString(label, this.Font,
                        black, new Point((int)(recs[i].Location.X + offset),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                }
                gr.FillRectangles(br, recs);
                
            }
        }

        private void cbCurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurs.Text == "" || cbCriteriu.Text == "") return;
            this.pregatireDateSiAfisareGrafic();
        }

        private void cbCriteriu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCurs.Text == "" || cbCriteriu.Text == "") return;
            this.pregatireDateSiAfisareGrafic();
        }

        private void pregatireDateSiAfisareGrafic()
        {
            string denumireCurs = cbCurs.Text;
            string criteriu = cbCriteriu.Text;

            if(criteriu == "Status Finalizare")
            {
                this.obtineValoriStatusFinalizare(denumireCurs);
            }else if(criteriu == "Inscrieri Curs vs Total Studenti")
            {
                this.obtineValoriInscrieri(denumireCurs);
            }else if(criteriu == "Distributie Rating")
            {
                this.obtineValoriRatings(denumireCurs);
            }
            panel1.Invalidate();
        }

        private void obtineValoriStatusFinalizare(string denumireCurs)
        {
            // In desfasurare
            valoriGrafic[0]= obtineListaStudentiDupaStatus(denumireCurs, SituatieCurs.Status.InDesfasurare).Count ;
            // Complet
            valoriGrafic[1] = obtineListaStudentiDupaStatus(denumireCurs, SituatieCurs.Status.Complet).Count ;
            // Restanta
            valoriGrafic[2] = obtineListaStudentiDupaStatus(denumireCurs, SituatieCurs.Status.Restanta).Count ;
            vb = true;
            nrElem = 3;
        }
        private void obtineValoriInscrieri(string denumireCurs)
        {
            // Inscrisi
            valoriGrafic[0] = obtineListaStudentiDupaCurs(denumireCurs).Count;
            // Total Studenti
            valoriGrafic[1] = centralizator.Studenti.Count;
           
            vb = true;
            nrElem = 2;
        }
        private void obtineValoriRatings(string denumireCurs)
        {
            // Rating 1
            valoriGrafic[0] = 0;
            // Rating 2
            valoriGrafic[1] = 0;
            // Rating 3
            valoriGrafic[2] = 0;
            // Rating 4
            valoriGrafic[3] = 0;
            // Rating 5
            valoriGrafic[4] = 0;

            string profId = ((Profesor)centralizator.UtilizatorLogat).Id;
            List<KeyValuePair<SituatieCurs, int>> entries = centralizator.Ratings.ToList();
            foreach(KeyValuePair<SituatieCurs, int> entry in entries)
            {
                if(entry.Key.Curs.Denumire == denumireCurs && entry.Key.IdProfesor== profId)
                {
                    if(entry.Value != 0)
                        valoriGrafic[entry.Value - 1]++;
                }
            }


            vb = true;
            nrElem = 5;
        }

        private List<Student> obtineListaStudentiDupaStatus(string denumireCurs, SituatieCurs.Status status)
        {
            string profId = ((Profesor)centralizator.UtilizatorLogat).Id;
            return centralizator.Studenti.FindAll(x => x.Situatii.Exists(c => c.Curs.Denumire == denumireCurs &&
            c.IdProfesor == profId && c.getStatus() == status));
        }
        private List<Student> obtineListaStudentiDupaCurs(string denumireCurs)
        {
            string profId = ((Profesor)centralizator.UtilizatorLogat).Id;
            return centralizator.Studenti.FindAll(x => x.Situatii.Exists(c => c.Curs.Denumire == denumireCurs &&
            c.IdProfesor == profId));
        }

        private void printeazaGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDoc_print);
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = pd;
            dialog.ShowDialog();
        }

        private void salveazaCaImagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cbCurs.Text == "" || cbCriteriu.Text == "")
            {
                MessageBox.Show("Alegeti un curs si un criteriu!");
                return;
            }
            label1.Visible = false;

            string profId = ((Profesor)centralizator.UtilizatorLogat).Id;
            string denumireImagine = cbCurs.Text.Split(' ')[0] + cbCriteriu.Text.Split(' ')[0]+
                DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + profId + ".bmp";

            salvare(panel1, denumireImagine);
            MessageBox.Show("Grafic salvat!");
        }

        public void salvare(Control c, string denumire)
        {
            Graphics gr = c.CreateGraphics();
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X,
                c.ClientRectangle.Y, c.ClientRectangle.Width,
                c.ClientRectangle.Height));
            img.Save("./img/"+denumire);
            img.Dispose();
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                graphicsColor = dlg.Color;
            panel1.Invalidate();
        }

        private void printDoc_print(object sender, PrintPageEventArgs e)
        {
            if (vb)
            {
                gr = e.Graphics;
                const int marg = 10;

                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg,
                       panel1.ClientRectangle.Y + 2 * marg,
                       panel1.ClientRectangle.Width - 2 * marg,
                       panel1.ClientRectangle.Height - 3 * marg);
                Pen pen = new Pen(Color.White, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 2;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = valoriGrafic.Max();

                Brush br = new SolidBrush(graphicsColor);
                Brush black = new SolidBrush(Color.Black);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - rec.Height / vMax * valoriGrafic[i]),
                        (int)latime,
                        (int)(rec.Height / vMax * valoriGrafic[i]));

                    string label = ""; double offset = 0;
                    if (cbCriteriu.Text == "Status Finalizare")
                    {
                        label = statusesLabels[i];
                        offset = 5;
                    }
                    else if (cbCriteriu.Text == "Inscrieri Curs vs Total Studenti")
                    {
                        label = studTypesLabels[i];
                        offset = latime / 4;
                    }
                    else if (cbCriteriu.Text == "Distributie Rating")
                    {
                        label = ratingLabels[i];
                        offset = 0;
                    }
                    label += ": " + valoriGrafic[i] + " studenti";
                    gr.DrawString(label, this.Font,
                        black, new Point((int)(recs[i].Location.X + offset),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                }
                gr.FillRectangles(br, recs);
            }
        }
    }
}
