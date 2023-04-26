using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpNumSS
{

    //exception système: prédéfinies
    //exception utilisateur: crée par rapport au code testé

    public class HorsIntervalle : Exception
    {
        public HorsIntervalle(string message) : base("Votre saisie est hors intervalle: "+ message) 
        { 

        }
    }

    public class SaisieEronnee : Exception
    {
        public SaisieEronnee() : base("Votre saisie est éronnée.")
        {

        }
    }

    public class ErreurCle : Exception
    {
        public ErreurCle(string message) : base("La clé: "+ message + " n'est pas valide.")
        {

        }
    }
}
