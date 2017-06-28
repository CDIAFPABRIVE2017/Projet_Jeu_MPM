namespace Projet_Jeu_Quinto
{
    partial class PartiePerdu
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
            this.labelPerdu = new System.Windows.Forms.Label();
            this.lblScoreDerniereManche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPerdu
            // 
            this.labelPerdu.AutoSize = true;
            this.labelPerdu.Location = new System.Drawing.Point(306, 121);
            this.labelPerdu.Name = "labelPerdu";
            this.labelPerdu.Size = new System.Drawing.Size(96, 13);
            this.labelPerdu.TabIndex = 0;
            this.labelPerdu.Text = "Vous avez perdu :(";
            // 
            // lblScoreDerniereManche
            // 
            this.lblScoreDerniereManche.AutoSize = true;
            this.lblScoreDerniereManche.Location = new System.Drawing.Point(315, 203);
            this.lblScoreDerniereManche.Name = "lblScoreDerniereManche";
            this.lblScoreDerniereManche.Size = new System.Drawing.Size(87, 13);
            this.lblScoreDerniereManche.TabIndex = 1;
            this.lblScoreDerniereManche.Text = "Votre score est : ";
            // 
            // PartiePerdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 460);
            this.Controls.Add(this.lblScoreDerniereManche);
            this.Controls.Add(this.labelPerdu);
            this.Name = "PartiePerdu";
            this.Text = "PartiePerdu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerdu;
        private System.Windows.Forms.Label lblScoreDerniereManche;
    }
}