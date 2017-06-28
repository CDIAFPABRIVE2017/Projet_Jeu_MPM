namespace Projet_Jeu_Quinto
{
    partial class Options
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbLangues = new System.Windows.Forms.GroupBox();
            this.gbMusique = new System.Windows.Forms.GroupBox();
            this.OnM = new System.Windows.Forms.RadioButton();
            this.OffM = new System.Windows.Forms.RadioButton();
            this.gbSon = new System.Windows.Forms.GroupBox();
            this.OnS = new System.Windows.Forms.RadioButton();
            this.OffS = new System.Windows.Forms.RadioButton();
            this.gbNbrManches = new System.Windows.Forms.GroupBox();
            this.btn_2manches = new System.Windows.Forms.Button();
            this.btn_3manches = new System.Windows.Forms.Button();
            this.btn_4manches = new System.Windows.Forms.Button();
            this.btn_5manches = new System.Windows.Forms.Button();
            this.gbLangues.SuspendLayout();
            this.gbMusique.SuspendLayout();
            this.gbSon.SuspendLayout();
            this.gbNbrManches.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Français";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "English";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbLangues
            // 
            this.gbLangues.Controls.Add(this.radioButton1);
            this.gbLangues.Controls.Add(this.radioButton2);
            this.gbLangues.Location = new System.Drawing.Point(70, 174);
            this.gbLangues.Name = "gbLangues";
            this.gbLangues.Size = new System.Drawing.Size(195, 65);
            this.gbLangues.TabIndex = 2;
            this.gbLangues.TabStop = false;
            this.gbLangues.Text = "Langues";
            // 
            // gbMusique
            // 
            this.gbMusique.Controls.Add(this.OnM);
            this.gbMusique.Controls.Add(this.OffM);
            this.gbMusique.Location = new System.Drawing.Point(70, 245);
            this.gbMusique.Name = "gbMusique";
            this.gbMusique.Size = new System.Drawing.Size(195, 65);
            this.gbMusique.TabIndex = 3;
            this.gbMusique.TabStop = false;
            this.gbMusique.Text = "Musique";
            // 
            // OnM
            // 
            this.OnM.AutoSize = true;
            this.OnM.Location = new System.Drawing.Point(6, 29);
            this.OnM.Name = "OnM";
            this.OnM.Size = new System.Drawing.Size(39, 17);
            this.OnM.TabIndex = 0;
            this.OnM.TabStop = true;
            this.OnM.Text = "On";
            this.OnM.UseVisualStyleBackColor = true;
            // 
            // OffM
            // 
            this.OffM.AutoSize = true;
            this.OffM.Location = new System.Drawing.Point(97, 29);
            this.OffM.Name = "OffM";
            this.OffM.Size = new System.Drawing.Size(39, 17);
            this.OffM.TabIndex = 1;
            this.OffM.TabStop = true;
            this.OffM.Text = "Off";
            this.OffM.UseVisualStyleBackColor = true;
            // 
            // gbSon
            // 
            this.gbSon.Controls.Add(this.OnS);
            this.gbSon.Controls.Add(this.OffS);
            this.gbSon.Location = new System.Drawing.Point(70, 316);
            this.gbSon.Name = "gbSon";
            this.gbSon.Size = new System.Drawing.Size(195, 65);
            this.gbSon.TabIndex = 4;
            this.gbSon.TabStop = false;
            this.gbSon.Text = "Son";
            // 
            // OnS
            // 
            this.OnS.AutoSize = true;
            this.OnS.Location = new System.Drawing.Point(6, 29);
            this.OnS.Name = "OnS";
            this.OnS.Size = new System.Drawing.Size(39, 17);
            this.OnS.TabIndex = 0;
            this.OnS.TabStop = true;
            this.OnS.Text = "On";
            this.OnS.UseVisualStyleBackColor = true;
            // 
            // OffS
            // 
            this.OffS.AutoSize = true;
            this.OffS.Location = new System.Drawing.Point(97, 29);
            this.OffS.Name = "OffS";
            this.OffS.Size = new System.Drawing.Size(39, 17);
            this.OffS.TabIndex = 1;
            this.OffS.TabStop = true;
            this.OffS.Text = "Off";
            this.OffS.UseVisualStyleBackColor = true;
            // 
            // gbNbrManches
            // 
            this.gbNbrManches.Controls.Add(this.btn_5manches);
            this.gbNbrManches.Controls.Add(this.btn_4manches);
            this.gbNbrManches.Controls.Add(this.btn_3manches);
            this.gbNbrManches.Controls.Add(this.btn_2manches);
            this.gbNbrManches.Location = new System.Drawing.Point(70, 25);
            this.gbNbrManches.Name = "gbNbrManches";
            this.gbNbrManches.Size = new System.Drawing.Size(195, 143);
            this.gbNbrManches.TabIndex = 5;
            this.gbNbrManches.TabStop = false;
            this.gbNbrManches.Text = "Nombre de manches";
            // 
            // btn_2manches
            // 
            this.btn_2manches.Location = new System.Drawing.Point(61, 19);
            this.btn_2manches.Name = "btn_2manches";
            this.btn_2manches.Size = new System.Drawing.Size(75, 23);
            this.btn_2manches.TabIndex = 6;
            this.btn_2manches.Text = "2 Manches";
            this.btn_2manches.UseVisualStyleBackColor = true;
            // 
            // btn_3manches
            // 
            this.btn_3manches.Location = new System.Drawing.Point(61, 48);
            this.btn_3manches.Name = "btn_3manches";
            this.btn_3manches.Size = new System.Drawing.Size(75, 23);
            this.btn_3manches.TabIndex = 7;
            this.btn_3manches.Text = "3 Manches";
            this.btn_3manches.UseVisualStyleBackColor = true;
            // 
            // btn_4manches
            // 
            this.btn_4manches.Location = new System.Drawing.Point(61, 77);
            this.btn_4manches.Name = "btn_4manches";
            this.btn_4manches.Size = new System.Drawing.Size(75, 23);
            this.btn_4manches.TabIndex = 8;
            this.btn_4manches.Text = "4 Manches";
            this.btn_4manches.UseVisualStyleBackColor = true;
            // 
            // btn_5manches
            // 
            this.btn_5manches.Location = new System.Drawing.Point(61, 106);
            this.btn_5manches.Name = "btn_5manches";
            this.btn_5manches.Size = new System.Drawing.Size(75, 23);
            this.btn_5manches.TabIndex = 9;
            this.btn_5manches.Text = "5 Manches";
            this.btn_5manches.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 430);
            this.Controls.Add(this.gbNbrManches);
            this.Controls.Add(this.gbSon);
            this.Controls.Add(this.gbMusique);
            this.Controls.Add(this.gbLangues);
            this.Name = "Options";
            this.Text = "Options";
            this.gbLangues.ResumeLayout(false);
            this.gbLangues.PerformLayout();
            this.gbMusique.ResumeLayout(false);
            this.gbMusique.PerformLayout();
            this.gbSon.ResumeLayout(false);
            this.gbSon.PerformLayout();
            this.gbNbrManches.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbLangues;
        private System.Windows.Forms.GroupBox gbMusique;
        private System.Windows.Forms.RadioButton OnM;
        private System.Windows.Forms.RadioButton OffM;
        private System.Windows.Forms.GroupBox gbSon;
        private System.Windows.Forms.RadioButton OnS;
        private System.Windows.Forms.RadioButton OffS;
        private System.Windows.Forms.GroupBox gbNbrManches;
        private System.Windows.Forms.Button btn_5manches;
        private System.Windows.Forms.Button btn_4manches;
        private System.Windows.Forms.Button btn_3manches;
        private System.Windows.Forms.Button btn_2manches;
    }
}