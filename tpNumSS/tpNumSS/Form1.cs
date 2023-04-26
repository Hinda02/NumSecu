using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerifSecu;

namespace tpNumSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bouton Quitter
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Bouton Effacer l'insertion
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            TxtNumSS.Clear();
        }

        /// <summary>
        /// Bouton permettant d'effectuer les différentes verifications 
        /// concernant la validité du numéro saisi par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerifier_Click(object sender, EventArgs e)
        {


            try
            {
                Verif.isNumeric(TxtNumSS.Text);
                Verif.nbChiffres(TxtNumSS.Text);
                Verif.premierChiffre(TxtNumSS.Text);
                Verif.moisNais(TxtNumSS.Text);
                Verif.verifDept(TxtNumSS.Text);
                Verif.verifCle(TxtNumSS.Text);

                Form2 form2 = new Form2(TxtNumSS.Text);
                form2.ShowDialog();
            }
            catch (SaisieEronnee ex) //non saisie + lettres + caractère
            {
                MessageBox.Show(ex.Message,
                "Attention!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            catch (ErreurCle exp) //cle fausse
            {
                MessageBox.Show(exp.Message,
                "Attention!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            catch (HorsIntervalle ex) //numéro différent de ce qui est attendu
            {
                MessageBox.Show(ex.Message,
                "Attention!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Le numéro de sécurité sociale saisi n'est pas valide.",
                "Attention!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
            
        }

    }
}
