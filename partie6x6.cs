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
    public partial class partie6x6 : Form
    {
        //Un tableau de strings à deux dimensions, de 6 lignes et 6 colonnes représentant la solution
        string[,] arrayGrille = new string[6, 6] { { "0", "1", "0", "0", "1", "1" }, { "1", "0", "1", "1", "0", "0" }, { "0", "0", "1", "0", "1", "1" }, { "0", "1", "0", "1", "0", "1" }, { "1", "1", "0", "1", "0", "0" }, { "1", "0", "1", "0", "1", "0" } };
        


        public partie6x6()
        {
            InitializeComponent();
        }

        private void Partie6x6_Load(object sender, EventArgs e)
        //La fenêtre avec la grille de jeu se charge
        {
            //Permet au joueur de voir 9 "1" ou "0" pour lancer la partie 
            case5.Text = arrayGrille[0, 4];
            case8.Text = arrayGrille[1, 1];
            case13.Text = arrayGrille[2, 0];
            case14.Text = arrayGrille[2, 1];
            case19.Text = arrayGrille[3, 0];
            case23.Text = arrayGrille[3, 4];
            case29.Text = arrayGrille[4, 4];
            case31.Text = arrayGrille[5, 0];
            case33.Text = arrayGrille[5, 2];


            //L'aide "Comment commencer" n'est pas visible avant que le joueur ne coche cette option
            panelHowToStart.Visible = false;
            //Au chargement de la fenêtre,
            //le joueur ne voit pas la solution avant qu'il ne coche cette option
            //l'option "vérrification en temps réel" n'est pas encore cochée
        }

        private void checkBoxCommentCommencer_Click(object sender, EventArgs e)
        // Rend visible une aide complémentaire pour commencer à compléter la grille
        {
            panelHowToStart.Visible = true;
            if (checkBoxCommentCommencer.Checked == false)
            {
                panelHowToStart.Visible = false;
            }
            //Si la checkBox est décochée, l'option n'est plus visible
        }

        private void CheckBoxPartie_CheckedChanged(object sender, EventArgs e)
        // Affiche la solution sous forme de suite de "1" et "O"
        {
            //Un tableau d'objets TextBox "case" collectant les entrées du joueur de même taille
            TextBox[,] GridPlayer = new TextBox[6, 6] { { case1, case2, case3, case4, case5, case6 }, { case7, case8, case9, case10, case11, case12 }, { case13, case14, case15, case16, case17, case18 }, { case19, case20, case21, case22, case23, case24 }, { case25, case26, case27, case28, case29, case30 }, { case31, case32, case33, case34, case35, case36 } };
            case5.Text = arrayGrille[0, 4];
            case8.Text = arrayGrille[1, 1];
            case13.Text = arrayGrille[2, 0];
            case14.Text = arrayGrille[2, 1];
            case19.Text = arrayGrille[3, 0];
            case23.Text = arrayGrille[3, 4];
            case29.Text = arrayGrille[4, 4];
            case31.Text = arrayGrille[5, 0];
            case33.Text = arrayGrille[5, 2];
            for (int positionLine = 0; positionLine <= arrayGrille.GetUpperBound(0); positionLine++)
            {
                for (int positionColumn = 0; positionColumn <= arrayGrille.GetUpperBound(1); positionColumn++)
                {
                    GridPlayer[positionLine, positionColumn].Text = arrayGrille[positionLine, positionColumn];
                    GridPlayer[positionLine, positionColumn].BackColor = Color.AntiqueWhite;
                }
            }
            if (CheckBoxPartie.Checked == false)
            //Si la checkBox est décochée, la solution n'est plus visible
            {
                for (int positionLine = 0; positionLine <= GridPlayer.GetUpperBound(0); positionLine++)
                {
                    for (int positionColumn = 0; positionColumn <= GridPlayer.GetUpperBound(1); positionColumn++)
                    {
                        GridPlayer[positionLine, positionColumn].Text = "-";
                        case5.Text = arrayGrille[0, 4];
                        case8.Text = arrayGrille[1, 1];
                        case13.Text = arrayGrille[2, 0];
                        case14.Text = arrayGrille[2, 1];
                        case19.Text = arrayGrille[3, 0];
                        case23.Text = arrayGrille[3, 4];
                        case29.Text = arrayGrille[4, 4];
                        case31.Text = arrayGrille[5, 0];
                        case33.Text = arrayGrille[5, 2];
                        GridPlayer[positionLine, positionColumn].BackColor = Color.BurlyWood;
                    }
                }
            }
        }
        private void buttonFinished_Click(object sender, EventArgs e)
        {
            /*Lance la vérification de la grille du joueur 
            soit les textes des textbox par comparaison avec les valeurs du tableau2D*/
            //Un tableau d'objets TextBox "case" collectant les entrées du joueur de même taille
            TextBox[,] GridPlayer = new TextBox[6, 6] { { case1, case2, case3, case4, case5, case6 }, { case7, case8, case9, case10, case11, case12 }, { case13, case14, case15, case16, case17, case18 }, { case19, case20, case21, case22, case23, case24 }, { case25, case26, case27, case28, case29, case30 }, { case31, case32, case33, case34, case35, case36 } };
            case5.Text = arrayGrille[0, 4];
            case8.Text = arrayGrille[1, 1];
            case13.Text = arrayGrille[2, 0];
            case14.Text = arrayGrille[2, 1];
            case19.Text = arrayGrille[3, 0];
            case23.Text = arrayGrille[3, 4];
            case29.Text = arrayGrille[4, 4];
            case31.Text = arrayGrille[5, 0];
            case33.Text = arrayGrille[5, 2];
            case5.BackColor = Color.AntiqueWhite;
            case8.BackColor = Color.AntiqueWhite;
            case13.BackColor = Color.AntiqueWhite;
            case14.BackColor = Color.AntiqueWhite;
            case19.BackColor = Color.AntiqueWhite;
            case23.BackColor = Color.AntiqueWhite;
            case29.BackColor = Color.AntiqueWhite;
            case31.BackColor = Color.AntiqueWhite;
            case33.BackColor = Color.AntiqueWhite;

            //string[,] GridPlayerFinal = new string[6, 6] { { case1.Text, case2.Text, case3.Text, case4.Text, case5.Text, case6.Text }, { case7.Text, case8.Text, case9.Text, case10.Text, case11.Text, case12.Text }, { case13.Text, case14.Text, case15.Text, case16.Text, case17.Text, case18.Text }, { case19.Text, case20.Text, case21.Text, case22.Text, case23.Text, case24.Text }, { case25.Text, case26.Text, case27.Text, case28.Text, case29.Text, case30.Text }, { case31.Text, case32.Text, case33.Text, case34.Text, case35.Text, case36.Text } };
            
            for (int positionLine = 0; positionLine <= arrayGrille.GetUpperBound(0); positionLine++)
            {
                for (int positionColumn = 0; positionColumn <= arrayGrille.GetUpperBound(1); positionColumn++)
                {
                    /*Si le joueur a tapé autre chose que "1" ou "0" au clavier, le texte redevient "-"*/
                    bool badEntry = GridPlayer[positionLine, positionColumn].Text != "1" && GridPlayer[positionLine, positionColumn].Text != "0";
                    if (badEntry == true)
                    {
                        GridPlayer[positionLine, positionColumn].Text = "-";
                    }
                    else 
                    {
                        bool partialSuccess = GridPlayer[positionLine, positionColumn].Text == arrayGrille[positionLine, positionColumn];
                        //Colorisation des bonnes cases ou des cases pas encore correctes
                        if (partialSuccess == true)
                        {
                            //Si le joueur a complété quelques cases avec succès
                            GridPlayer[positionLine, positionColumn].BackColor = Color.AntiqueWhite;
                            //Si le joueur a complété toute la grille avec succès en un coups
                            Color[] GridPlayerFinal = new Color[] { case1.BackColor, case2.BackColor, case3.BackColor, case4.BackColor, case5.BackColor, case6.BackColor, case7.BackColor, case8.BackColor, case9.BackColor, case10.BackColor, case11.BackColor, case12.BackColor, case13.BackColor, case14.BackColor, case15.BackColor, case16.BackColor, case17.BackColor, case18.BackColor, case19.BackColor, case20.BackColor, case21.BackColor, case22.BackColor, case23.BackColor, case24.BackColor, case25.BackColor, case26.BackColor, case27.BackColor, case28.BackColor, case29.BackColor, case30.BackColor, case31.BackColor, case32.BackColor, case33.BackColor, case34.BackColor, case35.BackColor, case36.BackColor };                            //GridPlayerFinal.SetValue(GridPlayer[positionLine, positionColumn].Text,positionLine, positionColumn);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                //Array[] sumOfArrays = new Array[] {GridPlayerFinal, arrayGrille};
                            bool completeSuccess = Array.TrueForAll(GridPlayerFinal, elements => elements == Color.AntiqueWhite);
                            if (completeSuccess)
                            {
                                
                                GridPlayer[2, 0].Text = "B";
                                GridPlayer[2, 1].Text = "R";
                                GridPlayer[2, 2].Text = "A";
                                GridPlayer[2, 3].Text = "V";
                                GridPlayer[2, 4].Text = "O";
                                GridPlayer[2, 5].Text = "!";
                            }
                        }
                        else
                        {
                            GridPlayer[positionLine, positionColumn].BackColor = Color.BurlyWood;
                        }
              
                    }
                }
            }
        }
    }
}