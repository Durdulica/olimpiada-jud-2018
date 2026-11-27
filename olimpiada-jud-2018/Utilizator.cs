using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olimpiada_jud_2018
{
    public class Utilizator
    {
        public int IdUtilizator { get; set; }
        public string NumePrenumeUtilizator { get; set; }
        public string ParolaUtilizator { get; set; }
        public string EmailUtilizator { get; set; }
        public string ClasaUtilizator { get; set; }

        public Utilizator(int idUtilizator, string numePrenumeUtilizator, string parolaUtilizator, string emailUtilizator, string clasaUtilizator)
        {
            IdUtilizator = idUtilizator;
            NumePrenumeUtilizator = numePrenumeUtilizator;
            ParolaUtilizator = parolaUtilizator;
            EmailUtilizator = emailUtilizator;
            ClasaUtilizator = clasaUtilizator;
        }
    }
}
