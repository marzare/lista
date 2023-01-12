using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ListaUczestnikow.ModelDanych
{
    internal class osoba : IComparable<osoba>
    {
        private int id;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime Dt_Urodzenia { get; set; }
        public decimal Sred_Ocen { get; set; }
        public string Poziom_Ang { get; set; }

        public osoba(int id, string imie, string nazwisko, DateTime dt_Urodzenia, decimal sred_Ocen, string poziom_Ang)
        {
            this.id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Dt_Urodzenia = dt_Urodzenia;
            Sred_Ocen = sred_Ocen;
            Poziom_Ang = poziom_Ang;
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko + "\nData urodzenia: " + Dt_Urodzenia.ToString("D") + "\nśrednia ocen: " + Sred_Ocen + "\nPoziom znajomości języka angielskiego: " + Poziom_Ang + "\n";
        }

        public int CompareTo(osoba? other)
        {
            if(other == null)
            {
                return 1;
            }
            if(ReferenceEquals(this, other))
            {
                return 0;
            }
            if (this.Sred_Ocen<other.Sred_Ocen)
            {
                return -1;
            } else if (this.Sred_Ocen > other.Sred_Ocen)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
    }
}
