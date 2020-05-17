using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace TEMA_Interfata
{
    class Program
    {
            static void Main(string[] args)
            {
            formularCarti f1 = new formularCarti();
            f1.Show();
            Application.Run();



                Carte[] carti = new Carte[20];
                int nrCarti = 0;
                string opt;
                Carte s1 = new Carte();
                Carte s2 = new Carte();
                do
                {
                    Console.Clear();
                    Console.WriteLine("G.Genul cartii");
                    Console.WriteLine("C.Adaugare carte ");
                    Console.WriteLine("A.Afisare biblioteca ");
                    Console.WriteLine("S.Salvare date in fisier");
                    Console.WriteLine("F.Cautare carte dupa nume");
                    Console.WriteLine("E.Iesire program");
                    Console.WriteLine("\n\nAlegeti o optiune: ");
                    opt = Console.ReadLine();
                    switch (opt)
                    {
                        case "G":
                            Console.WriteLine("Alegeti genul cartii: Roman=1, Nuvela=2,Pastel=3,Basm=4");
                            carti[0]._gen = (Carte.gen)Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Genul de carte ales este : {0}", carti[0]._gen);
                            break;
                        case "C":
                            s1.CitireTastatura();
                            break;

                        case "A":
                            s1.Afisare2();
                            break;
                        case "S":
                        s1.SalvareInFisier();
                            break;
                        case "F":
                            string s;
                            Console.WriteLine("Introduceti numele cartii pe care doriti sa o cautati: ");
                            s = Console.ReadLine();
                            s1.CautareDupaNume(s);
                            break;
                        case "M":
                            s1.AfisC();
                            break;
                            //  case "E":
                            //    O(0);
                            //     break;

                    }

                } while (true);


            }
        }
    public class formularCarti : Form
    {
        Label Lnume;
        Label Lautor;
        Label Lnrpagini;
        Label Lpret;
        TextBox Tnume;
        TextBox Tautor;
        TextBox Tnrpagini;
        TextBox Tpret;
        Label LADD;
        Button ADD;


    public formularCarti()
        {
            this.Size = new System.Drawing.Size(700,500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.BackColor = Color.Green;
            this.Text = "Gestiune Carti";

            Lnume = new Label();
            Lnume.Width = 170;
            Lnume.Text = "Nume";
            Lnume.BackColor = Color.Yellow;
            this.Controls.Add(Lnume);

            Lautor = new Label();
            Lautor.Width = 170;
            Lautor.Text = "Autor";
            Lautor.Top = 30;
            Lautor.BackColor = Color.Yellow;
            this.Controls.Add(Lautor);

            Lnrpagini = new Label();
            Lnrpagini.Width = 170;
            Lnrpagini.Text = "NrPagini";
            Lnrpagini.Top = 60;
            Lnrpagini.BackColor = Color.Yellow;
            this.Controls.Add(Lnrpagini);

            Lpret = new Label();
            Lpret.Width = 170;
            Lpret.Text = "Pret";
            Lpret.Top = 90;
            Lpret.BackColor = Color.Yellow;
            this.Controls.Add(Lpret);

            Tnume = new TextBox();
            Tnume.Width = 170;
            Tnume.Location = new System.Drawing.Point(180, 0);
            this.Controls.Add(Tnume);

            Tautor = new TextBox();
            Tautor.Width = 170;
            Tautor.Location = new System.Drawing.Point(180, 30);
            this.Controls.Add(Tautor);

            Tnrpagini = new TextBox();
            Tnrpagini.Width = 170;
            Tnrpagini.Location = new System.Drawing.Point(180, 60);
            this.Controls.Add(Tnrpagini);

            Tpret = new TextBox();
            Tpret.Width = 170;
            Tpret.Location = new System.Drawing.Point(180, 90);
            this.Controls.Add(Tpret);

            ADD = new Button();
            ADD.Width = 170;
            ADD.Text="Adauga";
            ADD.BackColor = Color.PapayaWhip;
            ADD.Location = new System.Drawing.Point(0, 120);
            this.Controls.Add(ADD);
            ADD.Click+= OnButtonADDClicked;
            this.Controls.Add(ADD);


            LADD = new Label();
            LADD.Width= 400;
            LADD.BackColor = Color.Yellow;
            LADD.Text = string.Empty;
            LADD.Height = 80;
            LADD.Top = 150;
            this.Controls.Add(LADD);

           

        }
        private void OnButtonADDClicked(object sender, EventArgs e)
        {
            
            if (Tnume.Text == string.Empty || Tnume.Text.Length > 15)
            {
                Lnume.ForeColor = Color.Red;
                Lautor.ForeColor = Color.Black;
                Lnrpagini.ForeColor = Color.Black;
                Lpret.ForeColor = Color.Black;
                MessageBox.Show("Nume Carte Invalid");
            }
            else if (Tautor.Text == string.Empty || Tautor.Text.Length > 15)
            {
                
                Lnume.ForeColor= Color.Black;
                Lautor.ForeColor = Color.Red;
                Lnrpagini.ForeColor = Color.Black;
                Lpret.ForeColor = Color.Black;
                MessageBox.Show("Nume Autor Invalid");


            }
            else if (Tnrpagini.Text == string.Empty)
            {
                Lnume.ForeColor = Color.Black;
                Lautor.ForeColor = Color.Black;
                Lnrpagini.ForeColor = Color.Red;
                Lpret.ForeColor = Color.Black;
                MessageBox.Show("NumarPagini Invalid");
            }
            else if (Tpret.Text == string.Empty)
            {
                Lnume.ForeColor = Color.Black;
                Lautor.ForeColor = Color.Black;
                Lnrpagini.ForeColor = Color.Black;
                Lpret.ForeColor = Color.Red;
                MessageBox.Show("Pret Invalid");
            }
            else
            {
                Carte s1 = new Carte(Tnume.Text, Tautor.Text, Convert.ToInt32(Tnrpagini.Text), Convert.ToInt32(Tpret.Text));

                Lnume.ForeColor = Color.Black;
                Lautor.ForeColor = Color.Black;
                Lnrpagini.ForeColor = Color.Black;
                Lpret.ForeColor = Color.Black;
                LADD.Text=s1.Afisare();
                s1.SalvareInFisier2();
            }
        }
    }

}
