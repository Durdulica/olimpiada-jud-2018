using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace olimpiada_jud_2018
{
    public static class Date
    {
        public static List<Utilizator> CitesteUtilizatori()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();

            if (!File.Exists(Path.Combine(Application.StartupPath, "..","..", "Resources", "date.txt"))) 
            {
                MessageBox.Show("Fisierul date.txt nu este atasaj proiectului!");
                return utilizatori;
            }

            var reader = new StreamReader(Path.Combine("..", "..", "Resources", "date.txt"));

            string linie = reader.ReadLine();
            int rand = 1;
            while((linie = reader.ReadLine().Trim()) != "Itemi:")
            {
                string[] date = linie.Split(';');
                utilizatori.Add(new Utilizator(rand++, date[0], date[1], date[2], date[3]));
            }

            return utilizatori;
        }
    }
}
