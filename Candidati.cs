using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    [Serializable]
    internal class Candidati : Persoana, Medii, IComparable, ICloneable
    {
        private int idCandidat;
        private string nume;
        private int varsta;
        private string profilLiceu;
        private int[] noteBac;
        private double medieLiceu;

        public Candidati() : base() {
            idCandidat = 0;
            nume = "n/a";
            varsta = 0;
            medieLiceu = 5.00;
            noteBac = new int[] { 5, 6, 7 };
            profilLiceu = "Real";
        }

        public Candidati(int c, char s, int id, string name, int v, string profil, int[]note, double liceu):base(c, s) {
            idCandidat = id;
            nume = name;
            varsta = v;
            profilLiceu = profil;
            noteBac = new int[note.Length];
            for (int i = 0; i < note.Length; i++)
                noteBac[i] = note[i];
            medieLiceu = liceu;
        }

        public int IdCandidat { get => idCandidat; set => idCandidat = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public string ProfilLiceu { get => profilLiceu; set => profilLiceu = value; }
        public int[] NoteBac { get => noteBac; set => noteBac = value; }
        public string ProfilLiceu1 { get => profilLiceu; set => profilLiceu = value; }
        public double MedieLiceu { get => medieLiceu; set => medieLiceu = value; }
        public string Nume { get => nume; set => nume = value; }

        public override string ToString()
        {
            string rezultat = "Candidatul " + idCandidat + base.ToString + ", se numeste " + nume + ", are varsta de " + varsta + " ani, a absolvit profil " + profilLiceu + " cu media liceala " + medieLiceu;
            if (noteBac == null)
                rezultat += " si nu a promovat bacalaureatul.";
            {
                rezultat += " si are urmatoarele note la bacalaureat: " +
                    Environment.NewLine;
                for (int i = 0; i < noteBac.Length; i++)
                    rezultat += noteBac[i] + ", ";
            }
            return rezultat;
        }
        public int CompareTo(object obj)
        {
            Candidati c = (Candidati)obj;
            if (this.medieAdmitere() > c.medieAdmitere())
            {
                return -1;
            }
            else
                if (this.medieAdmitere() < c.medieAdmitere())
                return 1;
            else
                return string.Compare(this.nume, c.nume);
        }

        public double medieBac()
        {
            double medie = 0;
            if(noteBac != null)
            {
                for(int i = 0;i < noteBac.Length;i++) {
                    medie += noteBac[i];
                }
            }
            return medie / noteBac.Length;
        }

        public override string spuneAnNastere()
        {
            return (System.DateTime.Now.Year - varsta).ToString();
        }

        public double medieAdmitere()
        {
            double suma = 0;
            for (int i = 0; i < noteBac.Length; i++)
                suma += noteBac[i];
            return suma/noteBac.Length;
        }

        public object Clone()
        {
            Candidati clona = (Candidati)this.MemberwiseClone();
            int[] noteNoi = (int[])noteBac.Clone();
            clona.noteBac = noteNoi;
            return clona;
        }
    }
}
