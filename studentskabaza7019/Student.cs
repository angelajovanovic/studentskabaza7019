using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentskabaza7019
{
    internal class Student:Osoba
    {
        private string ime;
        private string prezime;
        private int godine;

        private string indeks;

        public Student(string ime, string prezime, int godine, string indeks)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godine = godine;
            this.indeks = indeks;
        }
        
        private string Indeks { get => indeks; set=>indeks=value; }

        public Student()
        {
            this.ime = "Nis";
            this.prezime = "Nis";
            this.godine = 0;
            this.indeks = "Nis";

        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
