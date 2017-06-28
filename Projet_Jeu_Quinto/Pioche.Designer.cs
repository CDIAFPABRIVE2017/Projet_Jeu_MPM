namespace Projet_Jeu_Quinto
{
    partial class Pioche
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
            this.txtPioche = new System.Windows.Forms.TextBox();
            this.ajPioche = new System.Windows.Forms.Button();
            this.motsRetirés = new System.Windows.Forms.ListBox();
            this.listePioche = new System.Windows.Forms.ListBox();
            this.RetPioche = new System.Windows.Forms.Button();
            this.txtPioche2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPioche
            // 
            this.txtPioche.Location = new System.Drawing.Point(345, 112);
            this.txtPioche.Name = "txtPioche";
            this.txtPioche.Size = new System.Drawing.Size(100, 20);
            this.txtPioche.TabIndex = 0;
            // 
            // ajPioche
            // 
            this.ajPioche.Location = new System.Drawing.Point(358, 138);
            this.ajPioche.Name = "ajPioche";
            this.ajPioche.Size = new System.Drawing.Size(75, 23);
            this.ajPioche.TabIndex = 1;
            this.ajPioche.Text = "Ajouter";
            this.ajPioche.UseVisualStyleBackColor = true;
            // 
            // motsRetirés
            // 
            this.motsRetirés.FormattingEnabled = true;
            this.motsRetirés.Location = new System.Drawing.Point(98, 60);
            this.motsRetirés.Name = "motsRetirés";
            this.motsRetirés.Size = new System.Drawing.Size(197, 329);
            this.motsRetirés.TabIndex = 2;
            // 
            // listePioche
            // 
            this.listePioche.FormattingEnabled = true;
            this.listePioche.Location = new System.Drawing.Point(500, 60);
            this.listePioche.Name = "listePioche";
            this.listePioche.Size = new System.Drawing.Size(197, 329);
            this.listePioche.TabIndex = 3;
            // 
            // RetPioche
            // 
            this.RetPioche.Location = new System.Drawing.Point(358, 268);
            this.RetPioche.Name = "RetPioche";
            this.RetPioche.Size = new System.Drawing.Size(75, 23);
            this.RetPioche.TabIndex = 5;
            this.RetPioche.Text = "Retirer";
            this.RetPioche.UseVisualStyleBackColor = true;
            // 
            // txtPioche2
            // 
            this.txtPioche2.Location = new System.Drawing.Point(345, 242);
            this.txtPioche2.Name = "txtPioche2";
            this.txtPioche2.Size = new System.Drawing.Size(100, 20);
            this.txtPioche2.TabIndex = 4;
            // 
            // Pioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 460);
            this.Controls.Add(this.RetPioche);
            this.Controls.Add(this.txtPioche2);
            this.Controls.Add(this.listePioche);
            this.Controls.Add(this.motsRetirés);
            this.Controls.Add(this.ajPioche);
            this.Controls.Add(this.txtPioche);
            this.Name = "Pioche";
            this.Text = "Pioche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPioche;
        private System.Windows.Forms.Button ajPioche;
        private System.Windows.Forms.ListBox motsRetirés;
        private System.Windows.Forms.ListBox listePioche;
        private System.Windows.Forms.Button RetPioche;
        private System.Windows.Forms.TextBox txtPioche2;
    }
}