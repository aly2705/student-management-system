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
    public partial class AdminUI : Form
    {

        ArrayList listaComboBoxCursuri = new ArrayList();
        Centralizator centralizator;
        bool dateModificate = false;

        public AdminUI(Centralizator centralizator)
        {
            InitializeComponent();
           

            listaComboBoxCursuri.Add(this.cbCurs);
            this.centralizator = centralizator;
            myDataControl1.Text = centralizator.UtilizatorLogat.Nume + " " + centralizator.UtilizatorLogat.Prenume;
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            this.panelAddStudent.Visible = false;
            this.panelAddProffesor.Visible = false;
            this.panelAddCourse.Visible = false;
            btnDeleteCourse.Visible = false;
        }

        private void adaugaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelAddStudent.Visible = true;
            this.panelAddProffesor.Visible = false;
            this.panelAddCourse.Visible = false;
        }

        private void adaugaProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelAddStudent.Visible = false;
            this.panelAddProffesor.Visible = true;
            this.panelAddCourse.Visible = false;
        }

        private void adaugaCursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelAddStudent.Visible = false;
            this.panelAddProffesor.Visible = false;
            this.panelAddCourse.Visible = true;
        }


        private void btnSubmitStudent_Click(object sender, EventArgs e)
        {
            if(tbNume.Text == "" || tbPrenume.Text == "" || cbSex.Text == "" || cbAn.Text == "" || tbGrupa.Text == "" || cbSerie.Text == "" || cbFinantare.Text == "" || cbSpecializare.Text == "") { 
                if (tbNume.Text == "") errorProvider1.SetError(tbNume, "Introduceti numele studentului!");
                if (tbPrenume.Text == "") errorProvider1.SetError(tbPrenume, "Introduceti prenumele studentului!");
                if (cbSex.Text == "") errorProvider1.SetError(cbSex, "Selectati sexul studentului!");
                if (cbAn.Text == "") errorProvider1.SetError(cbAn, "Selectati anul studentului!");
                if (tbGrupa.Text == "") errorProvider1.SetError(tbGrupa, "Introduceti grupa studentului! Valori acceptate: 1000->1100");
                if (cbSerie.Text == "") errorProvider1.SetError(cbSerie, "Selectati seria studentului!");
                if (cbFinantare.Text == "") errorProvider1.SetError(cbFinantare, "Selectati forma de finantare a studentului!");
                if (cbSpecializare.Text == "") errorProvider1.SetError(cbSpecializare, "Selectati specializarea studentului!");
            } else
            {
                errorProvider1.Clear();
                try
                {
                    int grupa = Convert.ToInt32(tbGrupa.Text);
                    if (grupa < 1000 || grupa > 1100) errorProvider1.SetError(tbGrupa, "Alegeti o grupa de la 1000 la 1100");
                    else
                    {
                        string nume = tbNume.Text;
                        string prenume = tbPrenume.Text;
                        char sex = Convert.ToChar(cbSex.Text);
                        int an = Convert.ToInt32(cbAn.Text);
                        char serie = Convert.ToChar(cbSerie.Text);

                        Student.FormaFinantare finantare = (cbFinantare.Text == "Buget") ? Student.FormaFinantare.Buget : Student.FormaFinantare.Taxa;
                        Student.Specializari specializare = (cbSpecializare.Text == "Cibernetica") ? Student.Specializari.Cibernetica : ((cbSpecializare.Text == "Informatica") ? Student.Specializari.Informatica : Student.Specializari.Statistica);

                        Student stud = new Student(nume, prenume, sex, an, grupa, serie, finantare, specializare);
                        MessageBox.Show("S-a creat studentul: " + Environment.NewLine + stud.ToString());
                        centralizator.Studenti.Add(stud);
                        this.insertStudentInDB(stud);
                        dateModificate = true;

                        tbNume.Clear();
                        tbPrenume.Clear();
                        cbSex.Text = "";
                        cbAn.Text = "";
                        tbGrupa.Clear();
                        cbSerie.Text = "";
                        cbFinantare.Text = "";
                        cbSpecializare.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSubmitProf_Click(object sender, EventArgs e)
        {
            if (tbNumeProf.Text == "" || tbPrenumeProf.Text == "" || cbSexProf.Text == "")
            {
                if (tbNumeProf.Text == "") errorProvider1.SetError(tbNumeProf, "Introduceti numele profesorului!");
                if (tbPrenumeProf.Text == "") errorProvider1.SetError(tbPrenumeProf, "Introduceti prenumele profesorului!");
                if (cbSexProf.Text == "") errorProvider1.SetError(cbSexProf, "Selectati sexul profesorului!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    // Preluam datele simple: nume, prenume, sex
                    string nume = tbNumeProf.Text;
                    string prenume = tbPrenumeProf.Text;
                    char sex = Convert.ToChar(cbSexProf.Text);

                    // pregatim lista de cursuri a profesorului si un set in care vom tine evidenta cursurilor deja adaugate
                    List<Curs> cursuriProf = new List<Curs>();
                    HashSet<Int32> coduriCursuri = new HashSet<Int32>();
                    for(int i=0; i<listaComboBoxCursuri.Count; i++)
                    {
                        string cursString = ((ComboBox)listaComboBoxCursuri[i]).Text;

                        // permitem comboBox gol doar pentru cele adaugate de utilizator, primul cb trebuie sa fie obligatoriu completat
                        if (cursString == "") {
                            if (i == 0)
                            {
                                errorProvider1.SetError((ComboBox)listaComboBoxCursuri[i], "Selectati un curs!");
                                return;
                            }
                            else continue;
                            
                            
                        };

                        // Obtinere cod curs
                        int cod = Convert.ToInt32(cursString.Split(new Char[] { '(', ')' })[1]);

                        // Verificam sa nu avem un curs duplicat
                        if (coduriCursuri.Contains(cod))
                        {
                            errorProvider1.SetError((ComboBox)listaComboBoxCursuri[i], "Acest curs este duplicat. Selectati alt curs!");
                            return;
                        } else
                        {
                            // Salvam cursul nou intalnit in set si cursul in lista de cursuri a profesorului
                            coduriCursuri.Add(cod);
                            foreach (Curs curs in centralizator.Cursuri)
                            {
                                if (curs.Cod == cod)
                                {
                                    cursuriProf.Add(curs);
                                    break;
                                }
                            }
                        }
                    }

                    Profesor prof = new Profesor(nume, prenume,sex, cursuriProf);
                    MessageBox.Show("S-a creat profesorul: " + Environment.NewLine + prof.ToString());
                    centralizator.Profesori.Add(prof);
                    this.insertProfInDB(prof);
                    dateModificate = true;

                    // Curatare formular dupa operatiune reusita
                    tbNumeProf.Clear();
                    tbPrenumeProf.Clear();
                    cbSexProf.Text = "";

                    foreach (ComboBox cb in listaComboBoxCursuri)
                    {
                        cb.Text = "";
                        
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSubmitCourse_Click(object sender, EventArgs e)
        {
            if(tbDenumireCurs.Text == "" || tbCredite.Text == "")
            {
                if (tbDenumireCurs.Text == "") errorProvider1.SetError(tbDenumireCurs, "Introduceti denumirea cursului!");
                if (tbCredite.Text == "") errorProvider1.SetError(tbCredite, "Introduceti numarul de credite");
                if (tbpondereExamen.Text == "")
                    errorProvider1.SetError(tbpondereExamen, "Introduceti ponderea examenului (%)");
                if (tbPondereSeminar.Text == "")
                    errorProvider1.SetError(tbPondereSeminar, "Introduceti ponderea seminarului (%)");
            }
            else
            {
                errorProvider1.Clear();

                try
                {
                    string denumire = tbDenumireCurs.Text;
                    int nrCredite = Convert.ToInt32(tbCredite.Text);
                    int pondExamen = Convert.ToInt32(tbpondereExamen.Text);
                    int pondSeminar = Convert.ToInt32(tbPondereSeminar.Text);

                    if(nrCredite < 0 || nrCredite > 8 || pondExamen<0 || pondExamen >100 || pondSeminar < 0 || pondSeminar > 100)
                    {
                        if (nrCredite < 0 || nrCredite > 8)
                            errorProvider1.SetError(tbCredite, "Numarul de credite trebuie sa fie cuprins intre 1 si 8");
                        if (pondExamen < 0 || pondExamen > 100)
                            errorProvider1.SetError(tbpondereExamen, "Ponderea examenului trebuie sa fie cuprinsa intre 0 si 100");
                        if (pondSeminar < 0 || pondSeminar > 100)
                            errorProvider1.SetError(tbPondereSeminar, "Ponderea seminarului trebuie sa fie cuprinsa intre 0 si 100");

                    }else if(pondSeminar+pondExamen != 100)
                    {
                        errorProvider1.SetError(tbpondereExamen, "Suma ponderilor trebuie sa fie 100");
                    }
                    else
                    {
                        Curs curs = new Curs(denumire, nrCredite, pondExamen, pondSeminar);
                        MessageBox.Show("S-a creat cursul: " + Environment.NewLine + curs.ToString());
                        centralizator.Cursuri.Add(curs);
                        this.insertCourseInDB(curs);
                        dateModificate = true;

                        tbDenumireCurs.Clear();
                        tbCredite.Clear();
                        tbpondereExamen.Clear();
                        tbPondereSeminar.Clear();
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cbTypingNotAllowed_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAddCourseField_Click(object sender, EventArgs e)
        {
            int x = cbCurs.Location.X;
            int y = ((ComboBox)listaComboBoxCursuri[listaComboBoxCursuri.Count - 1]).Location.Y;

            ComboBox cbNou = new ComboBox();
            cbNou.Location = new Point(x, y+40);
            cbNou.Width = cbCurs.Width;
            cbNou.Visible = true;
            Curs[] cursuriVector = new Curs[centralizator.Cursuri.Count];
            for (int i = 0; i < centralizator.Cursuri.Count; i++)
            {
                cursuriVector[i] = centralizator.Cursuri[i];
            }
            cbNou.Items.AddRange(cursuriVector);

            cbNou.KeyPress += new KeyPressEventHandler(cbTypingNotAllowed_KeyPress);
            listaComboBoxCursuri.Add(cbNou);
            this.panelAddProffesor.Controls.Add(cbNou);

            if (listaComboBoxCursuri.Count == 4) btnAddCourseField.Visible = false;
            if(listaComboBoxCursuri.Count > 1) btnDeleteCourse.Visible = true;
                
        }

        private void panelAddProffesor_VisibleChanged(object sender, EventArgs e)
        {
            if(centralizator == null) { return; }
            if(centralizator.Cursuri != null) { 
                Curs[] cursuriVector = new Curs[centralizator.Cursuri.Count];
                for (int i = 0; i < centralizator.Cursuri.Count; i++)
                {
                    cursuriVector[i] = centralizator.Cursuri[i];
                }

                foreach(ComboBox cb in listaComboBoxCursuri)
                {
                        cb.Items.Clear();
                        cb.Items.AddRange(cursuriVector);
                }
            
            }
        }

        private void inapoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check folosit la varianta cu serializare/deserializare

            //if (dateModificate)
            //{
            //    DialogResult res = MessageBox.Show("Aveti modificari nesalvate! Doriti sa parasiti pagina oricum?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //    if (res == DialogResult.OK)
            //    {
            //        // Restabilire date anterioare, renuntare la modificari
            //        //centralizator.deserializare();
            //        this.Close();
            //    }
            //} else this.Close();

            this.Close();

        }


        // Metode folosite la serializare/deserializare date introduse in AdminUI

        //private void AdminUI_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (dateModificate)
        //    {
        //        DialogResult res = MessageBox.Show("Aveti modificari nesalvate! Doriti sa parasiti pagina oricum?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //        if (res == DialogResult.OK)
        //        {
        //            // Restabilire date anterioare, renuntare la modificari
        //            //centralizator.deserializare();
        //        } else e.Cancel = true;
        //    }
        //}

        //private void salveazaModificariToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if(dateModificate)
        //        try
        //        {
        //            // centralizator.serializare();
        //            MessageBox.Show("Modificarile au fost salvate!");
        //            dateModificate = false;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //}


        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            
            if(listaComboBoxCursuri.Count > 1)
            {
                this.panelAddProffesor.Controls.Remove((ComboBox)listaComboBoxCursuri[listaComboBoxCursuri.Count - 1]);
                listaComboBoxCursuri.Remove((ComboBox)listaComboBoxCursuri[listaComboBoxCursuri.Count - 1]);
            }
            if (!btnAddCourseField.Visible && listaComboBoxCursuri.Count < 4)
            {
                btnAddCourseField.Visible = true;
            }
            if(listaComboBoxCursuri.Count == 1)
            {
                btnDeleteCourse.Visible = false;
            }
        }

        private void insertStudentInDB(Student stud)
        {
            OleDbConnection conexiune = new OleDbConnection(Centralizator.connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO studenti values(@idStudent, @nume, @prenume, @sex, @an, @grupa, @serie, @finantare, @specializare)";
                comanda.Parameters.Add("@idStudent", OleDbType.Char, 20).Value = stud.Id;
                comanda.Parameters.Add("@nume", OleDbType.Char, 30).Value = stud.Nume;
                comanda.Parameters.Add("@prenume", OleDbType.Char, 30).Value = stud.Prenume;
                comanda.Parameters.Add("@sex", OleDbType.Char, 1).Value = stud.Sex;
                comanda.Parameters.Add("@an", OleDbType.Numeric, 5).Value = stud.An;
                comanda.Parameters.Add("@grupa", OleDbType.Numeric, 5).Value = stud.Grupa;
                comanda.Parameters.Add("@serie", OleDbType.Char, 1).Value = stud.Serie;
                comanda.Parameters.Add("@finantare", OleDbType.Char, 30).Value = stud.Finantare.ToString();
                comanda.Parameters.Add("@specializaree", OleDbType.Char, 30).Value = stud.Specializare.ToString();

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
        private void insertCourseInDB(Curs curs)
        {
            OleDbConnection conexiune = new OleDbConnection(Centralizator.connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO cursuri values(@cod, @denumire, @nrCredite, @pondereSeminar, @pondereExamen)";
                comanda.Parameters.Add("@cod", OleDbType.Numeric, 5).Value = curs.Cod;
                comanda.Parameters.Add("@denumire", OleDbType.Char, 40).Value = curs.Denumire;
                comanda.Parameters.Add("@nrCredite", OleDbType.Numeric, 5).Value = curs.NrCredite;
                comanda.Parameters.Add("@pondereSeminar", OleDbType.Numeric, 5).Value = curs.PondereSeminar;
                comanda.Parameters.Add("@pondereExamen", OleDbType.Numeric, 5).Value = curs.PondereExamen;
               

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
        private void insertProfInDB(Profesor prof)
        {
            OleDbConnection conexiune = new OleDbConnection(Centralizator.connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO profesori values(@idProfesor, @nume, @prenume, @sex)";
                comanda.Parameters.Add("@idProfesor", OleDbType.Char, 20).Value = prof.Id;
                comanda.Parameters.Add("@nume", OleDbType.Char, 30).Value = prof.Nume;
                comanda.Parameters.Add("@prenume", OleDbType.Char, 30).Value = prof.Prenume;
                comanda.Parameters.Add("@sex", OleDbType.Char, 1).Value = prof.Sex;


                comanda.ExecuteNonQuery();
                

                comanda.Parameters.Clear();

                comanda.CommandText = "Insert into cursuri_profesori (idProfesor, idCurs) values(@idProfesor, @idCurs)";
                
                foreach(var curs in prof.Cursuri)
                {
                    comanda.Parameters.Add("@idProfesor", OleDbType.Char, 20).Value = prof.Id;
                    comanda.Parameters.Add("@idCurs", OleDbType.Numeric, 5).Value = curs.Cod;
                    comanda.ExecuteNonQuery();

                    comanda.Parameters.Clear();
                }
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
