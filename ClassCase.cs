using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takuzu_Christine_ROELS_09_2019
{
    public class ClassCase
        //accessible à tout le programme
    {
        //ATTRIBUTS ET PROPRIETES
        private string caseText;
        //le contenu de la case de la grille du joueur
        public string CaseText
        {
            get { return caseText; }
            set { caseText = value; }
        }
        private string caseBackgroundColor;
        //La couleur d'arrière-plan de la case
        public string CaseBackgroundColor
        {
            get { return caseBackgroundColor; }
            set { caseBackgroundColor = value; }
        }
        //CONSTRUCTEUR PARAMETRE
        public ClassCase(string caseTextPlayer, string caseBackgroundColorPlayer)
        {
            caseText = caseTextPlayer;
            caseBackgroundColor = caseBackgroundColorPlayer;
        }




    }
}
