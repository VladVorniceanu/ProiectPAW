using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Facultati : ICloneable, IComparable
    {
        private string nume;
        private string oras;
        private int nrLocuri;

        public string Nume { get => nume; set => nume = value; }
        public string Oras { get => oras; set => oras = value; }
        public int NrLocuri { get => nrLocuri; set => nrLocuri = value; }

        public Facultati()
        {
            nume = "necunoscut";
            oras = "necunoscut";
            nrLocuri = 0;
        }

        public Facultati(string nume, string oras, int nrLocuri)
        {
            this.nume = nume;
            this.oras = oras;
            this.nrLocuri = nrLocuri;
        }

        public override string ToString()
        {
            string rezultat = "Facultatea " + nume + " din orasul " + oras + " are " + nrLocuri + " locuri disponibile.";
            return rezultat;
        }

        public object Clone()
        {
            Facultati clona = (Facultati)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object facultate)
        {
            Facultati fac = (Facultati)facultate;
            if (this.nrLocuri > fac.nrLocuri)
            {
                return -1;
            }
            else
                if (this.nrLocuri < fac.nrLocuri)
                return 1;
            else
                return string.Compare(this.nume, fac.nume);
        }
    }
}
