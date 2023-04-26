using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerifSecu;

namespace tpNumSS
{
    public partial class Form2 : Form
    {

        //dictionary for months
        private Dictionary<int, string> listMois = new Dictionary<int, string>();
        

        public Form2(string numSecu)
        {
            InitializeComponent();

            listMois.Add(01, "janvier");
            listMois.Add(02, "fevrier");
            listMois.Add(03, "mars");
            listMois.Add(04, "avril");
            listMois.Add(05, "mai");
            listMois.Add(06, "juin");
            listMois.Add(07, "juillet");
            listMois.Add(08, "août");
            listMois.Add(09, "septembre");
            listMois.Add(10, "octobre");
            listMois.Add(11, "novembre");
            listMois.Add(12, "decembre");


            int sexe = int.Parse(Verification.extraireChaine(numSecu, 0, 1));
            int annee = int.Parse(Verification.extraireChaine(numSecu, 1, 2));
            int mois = int.Parse(Verification.extraireChaine(numSecu, 3, 2));
            int dept = int.Parse(Verification.extraireChaine(numSecu, 5, 2));

            //Affichage dans le formulaire
            //afficher num secu
            
            NumSecu.Text = string.Format("{0:# ## ## ## ### ### ##}", long.Parse(numSecu));
            
            //afficher sexe
            if(sexe == 1)
            {
                masculin.Select();
            }
            else
            {
                feminin.Select();
            }

            //afficher le mois de naissance
            if (listMois.ContainsKey(mois))
            {
                moisNais.Text = listMois[mois];
            }

            //afficher annee de naissance
            if(annee <= DateTime.Now.Year - 2000)
            {
                if(annee >= 0 || annee <= 9)
                {
                    string strAnnee = string.Format("{0:00}", annee);
                    anneeNais.Text = "20" + strAnnee;
                }
                else
                {
                    anneeNais.Text = "20" + annee;
                }
            }
            else
            {
                anneeNais.Text = "19" + annee;
            }

            string[] tab;
            //afficher departement de naissance
            string ligne = ChargerDept.chargerFichier(dept);
            tab = ligne.Split(';');

            DeptNais.Text = tab[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
