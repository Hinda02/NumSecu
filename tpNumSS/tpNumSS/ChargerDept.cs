using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpNumSS
{
    public static class ChargerDept
    {
        public static string chargerFichier(int nbLigne)
        {
            TextReader reader;
            string fileName = "geo.txt";

            try
            {
                reader = new StreamReader(fileName, Encoding.Default);
                string line = reader.ReadLine();

                for (int i = 1; i < nbLigne; i++)
                {
                    line = reader.ReadLine();
                }


                reader.Close();
                return line;

            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Le fichier " + fileName + " est introuvable.",
                "Attention!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
