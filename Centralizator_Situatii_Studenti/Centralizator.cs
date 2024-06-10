using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    public class Centralizator
    {
        private List<Student> studenti = new List<Student>();
        private List<Profesor> profesori = new List<Profesor>();
        private List<Curs> cursuri = new List<Curs>();
        private Admin administrator = new Admin("Central", "Admin", 'F');
        private User utilizatorLogat; 
        private Dictionary<SituatieCurs, int> ratings = new Dictionary<SituatieCurs, int>();

        public List<Student> Studenti { get => studenti; set => studenti = value; }
        public List<Profesor> Profesori { get => profesori; set => profesori = value; }
        public List<Curs> Cursuri { get => cursuri; set => cursuri = value; }
        internal Admin Administrator { get => administrator; set => administrator = value; }
        public User UtilizatorLogat { get => utilizatorLogat; set => utilizatorLogat = value; }
        public Dictionary<SituatieCurs, int> Ratings { get => ratings; set => ratings = value; }

        public Centralizator() { }

        public Centralizator(List<Student> studenti, List<Profesor> profesori, List<Curs> cursuri)
        {
            this.studenti = studenti;
            this.profesori = profesori;
            this.cursuri = cursuri;
        }
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Centralizator.accdb";


        public void serializare()
        {
            User currentUser = utilizatorLogat;
            Admin admin = administrator;
            utilizatorLogat = null;
            administrator = null;

            FileStream fs = new FileStream("dateCentralizator.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter binFormatter = new BinaryFormatter();

            binFormatter.Serialize(fs, this);
            fs.Close();

            utilizatorLogat = currentUser;
            administrator = admin;
        }

        public void deserializare()
        {
            User currentUser = utilizatorLogat;
            Admin admin = administrator;
            utilizatorLogat = null;
            administrator = null;

            FileStream fs = new FileStream("dateCentralizator.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormatter = new BinaryFormatter();
            Centralizator c = (Centralizator)binFormatter.Deserialize(fs);
            this.studenti = c.studenti;
            this.profesori = c.profesori;
            this.cursuri = c.cursuri;
            this.administrator = c.administrator;
            this.ratings = c.ratings;

            Curs.Cod_sq = cursuri[cursuri.Count - 1].Cod;
            int idProf = Convert.ToInt32(profesori[profesori.Count - 1].Id.Substring(1));
            int idStud = Convert.ToInt32(studenti[studenti.Count - 1].Id.Substring(1));

            if (idProf > idStud) User.Id_seq = idProf;
            else User.Id_seq = idStud;

            fs.Close();

            utilizatorLogat = currentUser;
            administrator = admin;
        }

        public void loginUtilizator(string id)
        {
            if(id!= "") { 
                if (id[0] == 'A' && id == administrator.Id){
                    utilizatorLogat = administrator;
                    return;
                } else if (id[0] == 'S'){
                    foreach (var student in studenti)
                        if (id == student.Id)
                        {
                            utilizatorLogat = student;
                            return;
                        } 
                    
                } else if (id[0] == 'P'){

                    foreach (var profesor in profesori)
                        if (id == profesor.Id)
                        {
                            
                            utilizatorLogat = profesor;
                            return;
                        }
                   
                }
                
                throw new Exception("Id invalid!");
            }
        }

        public void initDateFromAccessDB()
        {
            OleDbConnection conexiune = new OleDbConnection(connectionString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                this.initCursuri(comanda);

                this.initProfesori(comanda, conexiune);
                this.initStudentiSiRatings(comanda, conexiune);

                // Setare id sequences base 
                Curs.Cod_sq = cursuri[cursuri.Count - 1].Cod;
                int idProf = Convert.ToInt32(profesori[profesori.Count - 1].Id.Substring(1));
                int idStud = Convert.ToInt32(studenti[studenti.Count - 1].Id.Substring(1));

                if (idProf > idStud) User.Id_seq = idProf;
                else User.Id_seq = idStud;
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

        private void initCursuri(OleDbCommand comanda)
        {
            comanda.CommandText =  "Select * from cursuri";
            OleDbDataReader reader = comanda.ExecuteReader();
            while (reader.Read())
            {
                int cod = Convert.ToInt32(reader["cod"]);
                int nrCredite = Convert.ToInt32(reader["nrCredite"]);
                int pondereExamen = Convert.ToInt32(reader["pondereExamen"]);
                int pondereSeminar = Convert.ToInt32(reader["pondereSeminar"]);

                cursuri.Add(new Curs(cod, reader["denumire"].ToString(), nrCredite, pondereExamen, pondereSeminar));
            }
            reader.Close();
        }
        private void initProfesori(OleDbCommand comanda, OleDbConnection conexiune)
        {
            comanda.CommandText = "Select * from profesori";
            OleDbDataReader reader = comanda.ExecuteReader();
            while (reader.Read())
            {
                

                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = conexiune;
                comanda2.CommandText = "SELECT idCurs from cursuri_profesori where idProfesor=@idProfesor";
                comanda2.Parameters.Add("@idProfesor", OleDbType.Char, 20).Value = reader["id"].ToString();

                OleDbDataReader reader2 = comanda2.ExecuteReader();
                List<Curs> cursuriProf = new List<Curs>();
                while (reader2.Read())
                {
                    cursuriProf.Add(cursuri.Find(x => x.Cod == Convert.ToInt32(reader2["idCurs"])));
                }
                char sex = Convert.ToChar(reader["sex"]);
                

                Profesor profesor = new Profesor(reader["id"].ToString(), reader["nume"].ToString(), reader["prenume"].ToString(), sex, cursuriProf);
                profesori.Add(profesor);
            }
            reader.Close();
        }
        private void initStudentiSiRatings(OleDbCommand comanda, OleDbConnection conexiune)
        {
            comanda.CommandText = "Select * from studenti";
            OleDbDataReader reader = comanda.ExecuteReader();
            while (reader.Read())
            {
                OleDbCommand comanda2 = new OleDbCommand();
                comanda2.Connection = conexiune;
                comanda2.CommandText = "SELECT * from situatii_curs where idStudent=@idStudent";
                comanda2.Parameters.Add("@idStudent", OleDbType.Char, 20).Value = reader["id"].ToString();

                OleDbDataReader reader2 = comanda2.ExecuteReader();
                List<SituatieCurs> situatii = new List<SituatieCurs>();
                while (reader2.Read())
                {
                    Curs curs = cursuri.Find(x => x.Cod == Convert.ToInt32(reader2["idCurs"]));
                    float notaExamen = Convert.ToSingle(reader2["notaExamen"]);
                    float notaSeminar = Convert.ToSingle(reader2["notaSeminar"]);
                    SituatieCurs situatie = new SituatieCurs(curs, reader2["idProfesor"].ToString(), notaSeminar, notaExamen);
                    situatii.Add(situatie);
                    ratings[situatie] = Convert.ToInt32(reader2["rating"]);
                }
                char sex = Convert.ToChar(reader["sex"]);
                int an = Convert.ToInt32(reader["an"]);
                int grupa = Convert.ToInt32(reader["grupa"]);
                char serie = Convert.ToChar(reader["serie"]);
                Student.FormaFinantare finantare = (reader["finantare"].ToString() == "Buget") ? Student.FormaFinantare.Buget : Student.FormaFinantare.Taxa;
                Student.Specializari specializare = (reader["specializare"].ToString() == "Cibernetica") ? Student.Specializari.Cibernetica : ((reader["specializare"].ToString() == "Informatica") ? Student.Specializari.Informatica : Student.Specializari.Statistica);


                Student student = new Student(reader["id"].ToString(),
                   reader["nume"].ToString(),
                   reader["prenume"].ToString(), sex,
                   an, grupa, serie,finantare, specializare, situatii);
                studenti.Add(student);
            }
            reader.Close();
        }
    }
}
