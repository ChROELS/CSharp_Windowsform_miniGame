using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takuzu_Christine_ROELS_09_2019
{
    public partial class TakuzuAccueil : Form
    {
        public TakuzuAccueil()
        {
            InitializeComponent();
            labelExplProgram.Text = "Complète" + "\n"+"une grille 6x6 pour découvrir le jeu Takuzu !";
        }

        private void ButtonReglesJeu_Click(object sender, EventArgs e)
        {
            ReglesJeu fenetreReglesJeu= new ReglesJeu();
            fenetreReglesJeu.Show();

        }

        private void Button6x6_Click(object sender, EventArgs e)
        {
            partie6x6 fenetrePartie = new partie6x6();
            fenetrePartie.Show();
            Panel panelGrille = new Panel();
            panelGrille.Visible = true;

        }
    }
}
