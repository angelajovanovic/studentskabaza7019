using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentskabaza7019
{
    
    internal class Osoba
    {
        private string ime;
        private string prezime;
        private int godine;

        public Osoba(string ime, string prezime,int godine)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godine { get => godine; set => godine = value; }

        public Osoba()
        {
            this.ime = "Nista";
            this.prezime = "Nista";
            this.godine = 0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}
