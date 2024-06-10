using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    public class Profesor : User
    {
        public static readonly Roles rol = Roles.Profesor;
        private List<Curs> cursuri;

        public Profesor() : base('P', rol)
        {
        }

        public Profesor(string nume, string prenume, char sex, List<Curs> cursuri) : base('P', nume, prenume, sex, rol)
        {
            this.cursuri = cursuri;
        }
        public Profesor(string id, string nume, string prenume, char sex, List<Curs> cursuri) : base(id, nume, prenume, sex, rol)
        {
            this.cursuri = cursuri;
        }

        public List<Curs> Cursuri { get => cursuri; set => cursuri = value; }

        public override string ShowPermissions()
        {
            return "Rol: Profesor";
        }

        public override string ToString()
        {
            string result = base.ToString() + Environment.NewLine;
            if (cursuri != null)
            {
                result += "---- Cursuri predate: ----" + Environment.NewLine;
                foreach (var cur in cursuri)
                {
                    result += cur.ToString() + Environment.NewLine;
                }
            }
            

            return result;
        }

        public string listaCursuriPredate()
        {
            string result = "";
            if (cursuri != null)
            {
                foreach (var cur in cursuri)
                {
                    result += cur.Denumire + ", ";
                }
            }
            return result;
        }
    }
}
