using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    public class Student : User
    {
        // Student Enums
        public enum FormaFinantare
        {
            Buget, Taxa
        }
        public enum Specializari
        {
            Cibernetica, Informatica, Statistica
        }

        // Student Attributes
        public static readonly Roles rol = Roles.Student;
        private int an;
        private int grupa;
        private char serie;
        private FormaFinantare finantare;
        private Specializari specializare;

        private List<SituatieCurs> situatii;

        // Properties
        public int An { get => an; set => an = value; }
        public int Grupa { get => grupa; set => grupa = value; }
        public char Serie { get => serie; set => serie = value; }
        public FormaFinantare Finantare { get => finantare; set => finantare = value; }
        public Specializari Specializare { get => specializare; set => specializare = value; }
        public List<SituatieCurs> Situatii { get => situatii; set => situatii = value; }

        // Constructors
        public Student() : base('S', rol)
        {
            an = 1;
            grupa = 1000;
            serie = 'A';
            specializare = Specializari.Cibernetica;
            finantare = FormaFinantare.Taxa;
            situatii = new List<SituatieCurs>();
        }

        public Student(string nume, string prenume, char sex,
            int an, int grupa, char serie, FormaFinantare finantare, Specializari specializare) 
            : base('S', nume, prenume, sex, rol)
        {
            this.an = an;
            this.grupa = grupa;
            this.serie = serie;
            this.finantare = finantare;
            this.specializare = specializare;
            this.situatii = new List<SituatieCurs>();
        }

        public Student(string nume, string prenume, char sex,
            int an, int grupa, char serie, FormaFinantare finantare, Specializari specializare, List<SituatieCurs> situatii)
            : base('S', nume, prenume, sex, rol)
        {
            this.an = an;
            this.grupa = grupa;
            this.serie = serie;
            this.finantare = finantare;
            this.specializare = specializare;
            this.situatii = new List<SituatieCurs>();
            foreach(SituatieCurs
                situatieCur in situatii)
            {
                this.situatii.Add((SituatieCurs)situatieCur.Clone());
            }
        }
        public Student(string id, string nume, string prenume, char sex,
            int an, int grupa, char serie, FormaFinantare finantare, Specializari specializare, List<SituatieCurs> situatii)
            : base(id, nume, prenume, sex, rol)
        {
            this.an = an;
            this.grupa = grupa;
            this.serie = serie;
            this.finantare = finantare;
            this.specializare = specializare;
            this.situatii = new List<SituatieCurs>();
            foreach (SituatieCurs
                situatieCur in situatii)
            {
                this.situatii.Add((SituatieCurs)situatieCur.Clone());
            }
        }

        public string listaSituatii()
        {
            string result = "";
            if (this.situatii != null)
                foreach (SituatieCurs situatie in situatii)
                {
                    result += situatie.ToString() + Environment.NewLine + Environment.NewLine;
                }
            else result += "Nu sunteti inscris la niciun curs!";
            return result;
        }

        public override string ToString()
        {
            string result = base.ToString() + Environment.NewLine;
            result += "An: " + an + ", Grupa: " + grupa + ", Serie: " + serie + ", Finantare: " + finantare.ToString() + ", Specializare: " + specializare.ToString();

           
            return result;
        }

        public override string ShowPermissions()
        {
            return "Rol: Student";
        }
    }
}
