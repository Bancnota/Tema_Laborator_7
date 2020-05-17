using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace TEMA_Interfata
{
    public class Carte
    {
        public enum gen
        {
            Roman = 1,
            Nuvela = 2,
            Pastel = 3,
            Basm = 4
        }
        private gen genul = gen.Roman;
        public gen _gen
        {
            get { return genul; }
            set { genul = value; }
        }
        Carte[] carti = new Carte[20];
        int nrCarti;
        public string nume
        {
            get;
            set;
        }
        public string autor
        {
            get;
            set;

        }
        public int nrpagini
        {
            get;
            set;

        }
        public int pret
        {
            get;
            set;
        }
        public Carte()
        {
            nume = string.Empty;
            autor = string.Empty;
            nrpagini = 0;
            pret = 0;
        }
        public Carte(string Nume, string Autor, int NrPagini, int Pret)
        {
            nume = Nume;
            autor = Autor;
            nrpagini = NrPagini;
            pret = Pret;

        }
        public Carte(string _nume)
        {
            string[] Buff = _nume.Split(',');
            nume = Buff[0];
            autor = Buff[1];
            nrpagini = Convert.ToInt32(Buff[2]);
            pret = Convert.ToInt32(Buff[3]);
        }
        public void CitireTastatura()
        {
            while (true)
            {
                string x, y;
                Console.WriteLine("Introduceti numele cartii noi: ");
                nume = Console.ReadLine();
                Console.WriteLine("Introduceti numele autorului: ");
                autor = Console.ReadLine();
                Console.WriteLine("Introduceti numarul de pagini: ");
                x = Console.ReadLine();
                nrpagini = Convert.ToInt32(x);
                Console.WriteLine("Introduceti pretul cartii: ");
                y = Console.ReadLine();
                pret = Convert.ToInt32(y);
                Carte s1 = new Carte(nume, autor, nrpagini, pret);
                carti[nrCarti] = s1;
                nrCarti++;
                Console.WriteLine("Doriti sa mai introduceti o carte ?");
                string rsp = Console.ReadLine();
                if (rsp == "DA" || rsp == "Da" || rsp == "dA" || rsp == "da")
                {
                    continue;
                }
                else
                    break;
            }
        }
        public void Afisare2()
        {
            for (int i = 0; i < nrCarti; i++)
            {
                Console.WriteLine(carti[i].Afisare());
                Console.ReadKey();
            }
        }
         public void SalvareInFisier()
          {
              using (StreamWriter sr = new StreamWriter("Fisierul meu", true))
              {
                  for (int i = 0; i < nrCarti; i++)
                  {

                      sr.WriteLine(carti[i].Afisare());

                  }

              }
          }
        public void SalvareInFisier2()
        {
            using (StreamWriter sr = new StreamWriter("Fisierul meu", true))
            {


                sr.WriteLine(Afisare());


            }
        }
        public void CautareDupaNume(string NUME)
        {
            int ok = 0;
            for (int i = 0; i < nrCarti; i++)
            {
                if (string.Compare(NUME, carti[i].nume) == 0)
                {
                    ok = 1;
                    Console.WriteLine(carti[i].Find());
                    Console.ReadKey();
                }
            }
            if (ok == 0)
            {
                Console.WriteLine("Carte inexistenta");
                Console.ReadKey();
            }
        }
        public string Find()
        {
            string s = "";
            s = "Carte gasita in baza de date!Aceasta este scrisa de " + autor + ", are " + nrpagini + " de pagini si costa " + pret + " de lei";
            return s;
        }
        public void AfisC()
        {
            int ok = 0;
            for (int i = 0; i < nrCarti; i++)
            {
                if (nrCarti > 2)
                {
                    ok = 1;
                    carti[i].comparare(carti[i + 1]);
                }
            }
            if (ok == 0)
                Console.WriteLine("Pentru comparare, biblioteca trebuie sa dispuna de cel putin 2 carti.");
            Console.ReadKey();
        }
        public void comparare(Carte db)
        {
            if (pret > db.pret)
            {
                Console.WriteLine("Cartea {0} scrisa de {1} costa mai mult decat cartea {2} scrisa de {3}", nume, autor, db.nume, db.autor);
                Console.ReadKey();
            }
            if (pret < db.pret)
            {
                Console.WriteLine("Cartea {0} scrisa de {1} costa mai mult decat cartea {2} scrisa de {3}", db.nume, db.autor, nume, autor);
                Console.ReadKey();
            }
            if (pret == db.pret)
            {
                Console.WriteLine("Au acelasi pret");
                Console.ReadKey();
            }
        }
        public string Afisare()
        {
            string s = "";
            // return string.Format("Cartea cu numele <<{0}>>,a fost scrisa de autorul <<{1}>>,are {2} de pagini si costa {3} lei", nume, autor, nrpagini, pret);
            s =string.Format( "Nume: " + nume + " \nAutor: " + autor + " \nNrPag: " + nrpagini + " \nPret: " + pret + "\n");
            return s;
        }
    }
}

