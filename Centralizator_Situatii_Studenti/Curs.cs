using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralizator_Situatii_Studenti
{
    [Serializable]
    public class Curs: ICloneable
    {
        private static int cod_sq = 10;
        private readonly int cod;
        private string denumire;
        private int nrCredite;
        private int pondereSeminar;
        private int pondereExamen;

        public Curs(string denumire, int nrCredite,  int pondereExamen, int pondereSeminar)
        {
            this.cod = cod_sq + 1;
            this.denumire = denumire;
            this.nrCredite = nrCredite;
            this.pondereSeminar = pondereSeminar;
            this.pondereExamen = pondereExamen;

            cod_sq++;
            
        }
        public Curs(int cod, string denumire, int nrCredite, int pondereExamen, int pondereSeminar)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.nrCredite = nrCredite;
            this.pondereSeminar = pondereSeminar;
            this.pondereExamen = pondereExamen;

        }

        public static int Cod_sq { get => cod_sq; set => cod_sq = value; }
        public int Cod { get => cod; }
        public int NrCredite { get => nrCredite; set => nrCredite = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public int PondereSeminar { get => pondereSeminar; set => pondereSeminar = value; }
        public int PondereExamen { get => pondereExamen; set => pondereExamen = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return denumire + " (" + cod + ")";
        }
    }
}
