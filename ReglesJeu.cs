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
    public partial class ReglesJeu : Form
    {
        
        public ReglesJeu()
        {
            InitializeComponent();
            
            


        }

        public Font Calibri { get; private set; }

        private void LabelConditions_Click(object sender, EventArgs e)
        {
            labelTroisConditions.Font = Calibri;
            labelTroisConditions.Location = new Point(84, 169) ;
            labelTroisConditions.Text = "Les règles du jeu :" + "\n" + "1) Chaque ligne et chaque colonne contiennent un nombre identique de 0 et de 1." + "\n" + "2) Il y a au maximum deux 1 ou deux 0 consécutifs sur chaque ligne et colonne." + "\n" + "3) Les lignes et les colonnes ne sont jamais identiques.";
            labelTroisConditions.Show();
        }

        private void TitreBut_Click(object sender, EventArgs e)
        {

            labelBut.Text = "Compléter la grille avec des 0 et 1 en respectant trois règles.";
            labelBut.Show();
        }
    }
}
