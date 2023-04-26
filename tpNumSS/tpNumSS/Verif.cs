using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace tpNumSS
{
    public static class Verif
    {

        //On peut faire une collection d'exceptions pur cumuler l'affichage de plusieurs erreurs!

        /// <summary>
        /// Verifier si la saisie est numérique
        /// </summary>
        /// <param name="numSS"></param>
        public static void isNumeric(string numSS)
        {
            try
            {
                long num = long.Parse(numSS);
            }
            catch (Exception)
            {

                throw new SaisieEronnee();
            }
        }

        /// <summary>
        /// Verifier si NumSecu composé de 15 chiffres
        /// </summary>
        /// <param name="numSS"></param>
        /// <exception cref="HorsIntervalle"></exception>
        public static void nbChiffres(string numSS)
        {
            if(numSS.Length != 15)
            {
                throw new HorsIntervalle("Le numéro saisi est très court.");
            }
        }

        /// <summary>
        /// Verifier le premier chiffre =1 ou =2
        /// </summary>
        /// <param name="numSS"></param>
        /// <exception cref="HorsIntervalle"></exception>
        public static void premierChiffre(string numSS)
        {
            if (extraireChaine(numSS, 0, 1) != "1" && extraireChaine(numSS, 0, 1) != "2")
            {
                throw new HorsIntervalle("Le premier chiffre doit être de 1 ou 2"); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            
        }

        /// <summary>
        /// Verifie la validité du mois
        /// </summary>
        /// <param name="numSS"></param>
        /// <exception cref="HorsIntervalle"></exception>
        public static void moisNais(string numSS)
        {
            int mois = int.Parse(extraireChaine(numSS, 3, 2));
            if (mois > 12 || mois < 1)
            {
               throw new HorsIntervalle(mois + " n'est pas un mois valide.");
            }
            
        }

        /// <summary>
        /// Verife la clé du NumSécu
        /// </summary>
        /// <param name="numSS"></param>
        /// <exception cref="ErreurCle"></exception>
        public static void verifCle(string numSS)
        {
            long ch13 = long.Parse(extraireChaine(numSS, 0, 13));
            long cle = long.Parse(extraireChaine(numSS, 13, 2));

            if (97 - (ch13 % 97) != cle)
            {
                throw new ErreurCle(cle.ToString());
            }
            
        }

        public static string extraireChaine(string chaine, int debut, int taille)
        {
            return chaine.Substring(debut, taille);
        }

        /// <summary>
        /// Verifie la validité du département
        /// </summary>
        /// <param name="numSS"></param>
        /// <exception cref="HorsIntervalle"></exception>
        public static void verifDept(string numSS)
        {
            int dept = int.Parse(extraireChaine(numSS, 5, 2));

            if ((dept < 0 || dept > 96) && dept != 99)
            {
                throw new HorsIntervalle("Le département "+dept+" n'existe pas.");
            }
            
        }
    }
}
