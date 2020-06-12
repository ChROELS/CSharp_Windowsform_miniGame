namespace Takuzu_Christine_ROELS_09_2019
{
    partial class ReglesJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titreBut = new System.Windows.Forms.Label();
            this.titreRegles = new System.Windows.Forms.Label();
            this.LabelConditions = new System.Windows.Forms.Label();
            this.labelTroisConditions = new System.Windows.Forms.Label();
            this.labelBut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titreBut
            // 
            this.titreBut.AutoSize = true;
            this.titreBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titreBut.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreBut.Location = new System.Drawing.Point(84, 47);
            this.titreBut.Name = "titreBut";
            this.titreBut.Size = new System.Drawing.Size(42, 26);
            this.titreBut.TabIndex = 0;
            this.titreBut.Text = "But\r\n";
            this.titreBut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titreBut.Click += new System.EventHandler(this.TitreBut_Click);
            // 
            // titreRegles
            // 
            this.titreRegles.AutoSize = true;
            this.titreRegles.Location = new System.Drawing.Point(84, 125);
            this.titreRegles.Name = "titreRegles";
            this.titreRegles.Size = new System.Drawing.Size(0, 13);
            this.titreRegles.TabIndex = 1;
            // 
            // LabelConditions
            // 
            this.LabelConditions.AutoSize = true;
            this.LabelConditions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelConditions.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConditions.Location = new System.Drawing.Point(84, 126);
            this.LabelConditions.Name = "LabelConditions";
            this.LabelConditions.Size = new System.Drawing.Size(103, 26);
            this.LabelConditions.TabIndex = 2;
            this.LabelConditions.Text = "Conditions";
            this.LabelConditions.Click += new System.EventHandler(this.LabelConditions_Click);
            // 
            // labelTroisConditions
            // 
            this.labelTroisConditions.AutoSize = true;
            this.labelTroisConditions.Location = new System.Drawing.Point(84, 84);
            this.labelTroisConditions.Name = "labelTroisConditions";
            this.labelTroisConditions.Size = new System.Drawing.Size(0, 13);
            this.labelTroisConditions.TabIndex = 3;
            // 
            // labelBut
            // 
            this.labelBut.AutoSize = true;
            this.labelBut.Location = new System.Drawing.Point(84, 97);
            this.labelBut.Name = "labelBut";
            this.labelBut.Size = new System.Drawing.Size(0, 13);
            this.labelBut.TabIndex = 4;
            // 
            // ReglesJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(685, 313);
            this.Controls.Add(this.labelBut);
            this.Controls.Add(this.labelTroisConditions);
            this.Controls.Add(this.LabelConditions);
            this.Controls.Add(this.titreRegles);
            this.Controls.Add(this.titreBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReglesJeu";
            this.Text = "Règles du jeu Takuzu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreBut;
        private System.Windows.Forms.Label titreRegles;
        private System.Windows.Forms.Label LabelConditions;
        private System.Windows.Forms.Label labelTroisConditions;
        private System.Windows.Forms.Label labelBut;
    }
}