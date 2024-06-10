using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    public abstract class User
    {
        private static int id_seq = 1000;
        public enum Roles
        {
            Student, Profesor, Admin
        }

        private readonly string id;
        private string nume;
        private string prenume;
        private char sex;
        private readonly Roles rol;

        public User(char id_prefix, Roles rol)
        {
            id = id_prefix + (id_seq+1).ToString();
            nume = "New";
            prenume = "User";
            sex = 'F';
            this.rol = rol;

            id_seq++;
        }

        public User(char id_prefix, string nume, string prenume, char sex, Roles rol)
        {
            id = id_prefix + (id_seq + 1).ToString();
            this.nume = nume;
            this.prenume = prenume;
            this.sex = sex;
            this.rol = rol;

            id_seq++;
        }
        public User(string id, string nume, string prenume, char sex, Roles rol)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.sex = sex;
            this.rol = rol;
        }

        public string Id
        {
            get { return id; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { if (value != null) prenume = value; }
        }

        public char Sex
        {
            get { return sex; }
            set { if (sex == 'M' || sex == 'F') sex = value; }
        }

        public static int Id_seq { get => id_seq; set => id_seq = value; }

        public Roles Rol => this.rol;

        public string getFullName()
        {
            return nume + " " + prenume;
        }

        public override string ToString()
        {
            return ShowPermissions() + " | Utilizatorul " +  id.ToString() + ": " + nume + " " + prenume + ", sex "+ sex;
        }

        public abstract string ShowPermissions();
    }
}
