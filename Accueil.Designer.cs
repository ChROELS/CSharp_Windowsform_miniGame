namespace Takuzu_Christine_ROELS_09_2019
{
    partial class TakuzuAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReglesJeu = new System.Windows.Forms.Button();
            this.button6x6 = new System.Windows.Forms.Button();
            this.labelExplProgram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReglesJeu
            // 
            this.buttonReglesJeu.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonReglesJeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReglesJeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReglesJeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReglesJeu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReglesJeu.Location = new System.Drawing.Point(9, 82);
            this.buttonReglesJeu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonReglesJeu.Name = "buttonReglesJeu";
            this.buttonReglesJeu.Size = new System.Drawing.Size(317, 105);
            this.buttonReglesJeu.TabIndex = 0;
            this.buttonReglesJeu.Text = "Règles du jeu";
            this.buttonReglesJeu.UseVisualStyleBackColor = false;
            this.buttonReglesJeu.Click += new System.EventHandler(this.ButtonReglesJeu_Click);
            // 
            // button6x6
            // 
            this.button6x6.BackColor = System.Drawing.Color.BurlyWood;
            this.button6x6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6x6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6x6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6x6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6x6.Location = new System.Drawing.Point(9, 197);
            this.button6x6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button6x6.Name = "button6x6";
            this.button6x6.Size = new System.Drawing.Size(317, 105);
            this.button6x6.TabIndex = 1;
            this.button6x6.Text = "Partie 6x6";
            this.button6x6.UseVisualStyleBackColor = false;
            this.button6x6.Click += new System.EventHandler(this.Button6x6_Click);
            // 
            // labelExplProgram
            // 
            this.labelExplProgram.AutoSize = true;
            this.labelExplProgram.Location = new System.Drawing.Point(13, 15);
            this.labelExplProgram.Name = "labelExplProgram";
            this.labelExplProgram.Size = new System.Drawing.Size(49, 19);
            this.labelExplProgram.TabIndex = 2;
            this.labelExplProgram.Text = "label1";
            // 
            // TakuzuAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(335, 313);
            this.Controls.Add(this.labelExplProgram);
            this.Controls.Add(this.buttonReglesJeu);
            this.Controls.Add(this.button6x6);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "TakuzuAccueil";
            this.Text = "Découverte du Takuzu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReglesJeu;
        private System.Windows.Forms.Button button6x6;
        private System.Windows.Forms.Label labelExplProgram;
    }
}

