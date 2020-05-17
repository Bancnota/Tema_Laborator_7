using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TEMA_Interfata;
using System.IO;

namespace TEMA_Interfata
{
   public interface IStocareData
    {
     void AddStudent(Carte s);
        Carte[] GetStudenti(out int nrCarti);

        Carte GetStudent(string nume, string prenume);
    }
}
