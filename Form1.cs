using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEMA_Interfata;

namespace Tema_Form2
{
    public partial class Form1 : Form
    {

        List<Carte> Books = new List<Carte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(TxtNume.Text==string.Empty)
            {
                MessageBox.Show("Nume invalid");
            }
            else if(TxtAutor.Text==string.Empty)
            {
                MessageBox.Show("Autor invalid");
            }
            else if(TxtNrPag.Text==string.Empty)
            {
                MessageBox.Show("Introduceti numarul de pagini");
            }
            else if(TxtPret.Text==string.Empty)
            {
                MessageBox.Show("Introduceti un pret");
            }
            else
            {
                Carte c1 = new Carte(TxtNume.Text, TxtAutor.Text, Convert.ToInt32(TxtNrPag.Text), Convert.ToInt32(TxtPret.Text));
                c1.SalvareInFisier2();
                Books.Add(c1);
                MessageBox.Show("Carte adaugata cu succes");
            }
        }

        private void BtnAfis_Click(object sender, EventArgs e)
        {
            Lbox.Items.Clear();
            foreach (Carte C in Books)
            {

                Lbox.Items.Add(C.Afisare());
            }
        }

        private void BtnCauta_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if(TxtNume.Enabled==true && TxtAutor.Enabled==true && TxtNrPag.Enabled==true)
            {
                TxtNume.Enabled = false;
                TxtAutor.Enabled = false;
                TxtNrPag.Enabled = false;
            }
            else
            {
                TxtNume.Enabled = true;
                TxtAutor.Enabled = true;
                TxtNrPag.Enabled = true;
            }
            foreach(Carte C in Books)
            {
                if(TxtNume.Text==C.nume && TxtAutor.Text==C.autor && TxtNrPag.Text==Convert.ToString(C.nrpagini))
                {
                    ok = 1;
                    LblCauta.Text = C.Find();
                }
            }
            if(ok==0)
            {
                MessageBox.Show("Carte negasita");
            }
        }

        private void BtnModf_Click(object sender, EventArgs e)
        {
            int ok = 0;
            foreach(Carte C in Books)
            {
                if(TxtNume.Enabled==false && TxtAutor.Enabled==false && TxtNrPag.Enabled==false)
                {
                    MessageBox.Show("Modificare facuta cu succes");
                    TxtNume.Enabled =true;
                    TxtAutor.Enabled = true;
                    TxtNrPag.Enabled = true;
                    ok = 1;
                    C.pret = Convert.ToInt32(TxtPret.Text);
                    
                }
            }
            if(ok==0)
            {
                MessageBox.Show("Modificare nereusita");
            }
        }

        private void BtnPret_Click(object sender, EventArgs e)
        {
            foreach(Carte C in Books)
            {
                LblPret.Text =Convert.ToString( C.pret);
            }
        }
    }
}
