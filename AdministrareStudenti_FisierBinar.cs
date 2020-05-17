using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TEMA_Interfata;
namespace TEMA_Interfata
{
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddStudent(Carte s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public Carte[] GetStudenti(out int nrStudenti)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public Carte GetStudent(string nume, string prenume)
        {
            throw new Exception("Optiunea GetStudent nu este implementata");
        }
    }
}
