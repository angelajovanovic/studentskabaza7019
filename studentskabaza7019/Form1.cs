using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentskabaza7019
{
    public partial class Form1 : Form
    { 
        Form2 f;
        List <Student>studenti;
        String ime;
        bool p_ime=false;
        String prezime;
        bool p_prezime=false;
        int godine;
        bool p_godine;
        String indeks;
        bool p_indeks = false;
        int brojac1, brojac2, brojac3;
        public Form1()
        {
            f = new Form2();
            studenti = new List<Student>();
            InitializeComponent();
        }

        private void btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            if(p_ime == true && p_prezime == true && p_godine == true && p_indeks == true)
            {
                Student s = new Student();
                s.Ime = ime;
                s.Prezime = prezime;
                s.Godine = godine;
               // s.Indeks = txtb_Indeks.Text;
                studenti.Add(s);
                MessageBox.Show("Student" + s.Ime + "," + s.Prezime + "je dodat u list!");
            }
            else
            {
                MessageBox.Show("Niste ispravno popunili polja!");
            }
        }

        private void btn_Prikazi_Click(object sender, EventArgs e)
        {
            f.Show();
            f = new Form2();
        }

        private void txtb_Ime_TextChanged(object sender, EventArgs e)
        {
            ime = txtb_Ime.Text.Trim();
            if (ime.Length > 1 && char.IsUpper(ime[0]))
            {
                p_ime = true;
            }
            else
            {
                p_ime = false;
            }
            if(p_ime == true)
            {
                txtb_Ime.BackColor = Color.Green;
            }
            else
            {
                txtb_Ime.BackColor= Color.Red; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
