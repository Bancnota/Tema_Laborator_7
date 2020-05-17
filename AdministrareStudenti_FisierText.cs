using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TEMA_Interfata;
namespace TEMA_Interfata
{
        public class AdministrareStudenti_FisierText : IStocareData
        {
            private const int PAS_ALOCARE = 10;
            string NumeFisier { get; set; }
            public AdministrareStudenti_FisierText(string numeFisier)
            {
                this.NumeFisier = numeFisier;
                Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
                sFisierText.Close();

                //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
                //instructiunea 'using' va apela sFisierText.Close();
                //using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
            }
            public void AddStudent(Carte s)
            {
                try
                {
                    //instructiunea 'using' va apela la final swFisierText.Close();
                    //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                    using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                    {
                        swFisierText.WriteLine(s.Afisare());
                    }
                }
                catch (IOException eIO)
                {
                    throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
                }
                catch (Exception eGen)
                {
                    throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
                }
            }

            public Carte[] GetStudenti(out int nrcarti)
            {
                Carte[] carti = new Carte[PAS_ALOCARE];

                try
                {
                    // instructiunea 'using' va apela sr.Close()
                    using (StreamReader sr = new StreamReader(NumeFisier))
                    {
                        string line;
                        nrcarti = 0;

                        //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                        while ((line = sr.ReadLine()) != null)
                        {
                            carti[nrcarti++] = new Carte(line);
                            if (nrcarti == PAS_ALOCARE)
                            {
                                Array.Resize(ref carti, nrcarti+ PAS_ALOCARE);
                            }
                        }
                    }
                }
                catch (IOException eIO)
                {
                    throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
                }
                catch (Exception eGen)
                {
                    throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
                }

                return carti;
            }

            public Carte GetStudent(string nume, string prenume)
            {
                try
                {
                    // instructiunea 'using' va apela sr.Close()
                    using (StreamReader sr = new StreamReader(NumeFisier))
                    {
                        string line;

                        //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                        while ((line = sr.ReadLine()) != null)
                        {
                            Carte carte = new Carte(line);
                            if (carte.nume.Equals(nume) && carte.autor.Equals(prenume))
                                return carte;
                        }
                    }
                }
                catch (IOException eIO)
                {
                    throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
                }
                catch (Exception eGen)
                {
                    throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
                }
                return null;
            }
    }
}
