using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    public class SituatieCurs : ICloneable
    {
        private Curs curs;
        private string idProfesor;
        private float notaSeminar;
        private float notaExamen;

        public SituatieCurs(Curs curs, string idProfesor, float notaSeminar, float notaExamen)
        {
            this.curs = curs;
            this.idProfesor = idProfesor;
            this.notaSeminar = notaSeminar;
            this.notaExamen = notaExamen;
        }
        public SituatieCurs(Curs curs, string idProfesor)
        {
            this.curs = curs;
            this.idProfesor = idProfesor;
            this.notaSeminar = 0;
            this.notaExamen = 0;
        }

        public enum Status
        {
            Complet, Restanta, InDesfasurare
        }

        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
        public Curs Curs { get => curs; set => curs = value; }
        public float NotaSeminar { get => notaSeminar; set => notaSeminar = value; }
        public float NotaExamen { get => notaExamen; set => notaExamen = value; }

        public float calculeazaNotaFinala()
        {

            return Convert.ToSingle(curs.PondereExamen) / 100f * notaExamen + Convert.ToSingle(curs.PondereSeminar) / 100f * notaSeminar;
        }

        public object Clone()
        {
            SituatieCurs copie =  (SituatieCurs)this.MemberwiseClone();
            copie.curs = (Curs)curs.Clone();
            return copie;
        }

        public override string ToString()
        {
            string result = "Denumire: " + curs.Denumire + ", Numar Credite: "+ curs.NrCredite + Environment.NewLine;
            if(notaExamen > 0 && notaSeminar > 0)
            {
                if (calculeazaNotaFinala() >= 5)
                    result += "Status: Complet" + ", Nota: " + calculeazaNotaFinala() + " (Examen=" + notaExamen + ", Seminar=" + notaSeminar + ")";
                else result += "Status: Restanta" + ", Nota: " + calculeazaNotaFinala();
            }
            else
            {
                result += "Status: In desfasurare";
            }
            return result;
        }

        public bool completa()
        {
            if (notaExamen > 0 && notaSeminar > 0)
            {
                if (calculeazaNotaFinala() >= 5)
                    return true;
            }
            return false;
        }
        public Status getStatus()
        {
            if (notaExamen > 0 && notaSeminar > 0)
            {
                if (calculeazaNotaFinala() >= 5)
                    return Status.Complet;
                else return Status.Restanta;
            }
            return Status.InDesfasurare;
        }
    }
}
