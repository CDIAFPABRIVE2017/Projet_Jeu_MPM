﻿namespace Projet_Jeu_Quinto
{
<<<<<<< HEAD
    partial class Partie
=======
    partial class txtAffichageMot
>>>>>>> 836e81ec15a726ec53ab74a6bbc22f2fdf132b1c
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(808, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 634);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Partie";
            this.Text = "Partie";
=======
            this.lblNbrEssai = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.txtNbrManches = new System.Windows.Forms.TextBox();
            this.lblChrono = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNbrEssai
            // 
            this.lblNbrEssai.AutoSize = true;
            this.lblNbrEssai.Location = new System.Drawing.Point(69, 64);
            this.lblNbrEssai.Name = "lblNbrEssai";
            this.lblNbrEssai.Size = new System.Drawing.Size(120, 13);
            this.lblNbrEssai.TabIndex = 0;
            this.lblNbrEssai.Text = "Nombre d\'essai restant :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(428, 20);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.btnT);
            this.panel1.Controls.Add(this.btnY);
            this.panel1.Controls.Add(this.btnU);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.btnZ);
            this.panel1.Controls.Add(this.btnE);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Location = new System.Drawing.Point(72, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 210);
            this.panel1.TabIndex = 2;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(154, 69);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(45, 45);
            this.button26.TabIndex = 25;
            this.button26.Text = "D";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(221, 69);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(45, 45);
            this.button25.TabIndex = 24;
            this.button25.Text = "F";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(283, 69);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(45, 45);
            this.button24.TabIndex = 23;
            this.button24.Text = "G";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(350, 69);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(45, 45);
            this.button23.TabIndex = 22;
            this.button23.Text = "H";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(409, 69);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(45, 45);
            this.button22.TabIndex = 21;
            this.button22.Text = "J";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(470, 69);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(45, 45);
            this.button21.TabIndex = 20;
            this.button21.Text = "K";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(530, 69);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(45, 45);
            this.button20.TabIndex = 19;
            this.button20.Text = "L";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(587, 69);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(45, 45);
            this.button19.TabIndex = 18;
            this.button19.Text = "M";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(154, 126);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(45, 45);
            this.button18.TabIndex = 17;
            this.button18.Text = "W";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(221, 126);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(45, 45);
            this.button17.TabIndex = 16;
            this.button17.Text = "X";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(283, 126);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 45);
            this.button16.TabIndex = 15;
            this.button16.Text = "C";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(350, 126);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 45);
            this.button15.TabIndex = 14;
            this.button15.Text = "V";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(409, 126);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 45);
            this.button14.TabIndex = 13;
            this.button14.Text = "B";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(470, 126);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 45);
            this.button13.TabIndex = 12;
            this.button13.Text = "N";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // btnT
            // 
            this.btnT.AutoSize = true;
            this.btnT.Location = new System.Drawing.Point(283, 17);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(45, 45);
            this.btnT.TabIndex = 11;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            // 
            // btnY
            // 
            this.btnY.AutoSize = true;
            this.btnY.Location = new System.Drawing.Point(350, 17);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(45, 45);
            this.btnY.TabIndex = 10;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            // 
            // btnU
            // 
            this.btnU.AutoSize = true;
            this.btnU.Location = new System.Drawing.Point(409, 17);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(45, 45);
            this.btnU.TabIndex = 9;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(470, 17);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "I";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(530, 17);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "O";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(587, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "P";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Q";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(86, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "S";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            this.btnR.AutoSize = true;
            this.btnR.Location = new System.Drawing.Point(221, 17);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(45, 45);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnZ
            // 
            this.btnZ.AutoSize = true;
            this.btnZ.Location = new System.Drawing.Point(86, 17);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(45, 45);
            this.btnZ.TabIndex = 2;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.AutoSize = true;
            this.btnE.Location = new System.Drawing.Point(154, 17);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(45, 45);
            this.btnE.TabIndex = 1;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.AutoSize = true;
            this.btnA.Location = new System.Drawing.Point(22, 17);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(45, 45);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(665, 64);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(117, 41);
            this.btnOption.TabIndex = 3;
            this.btnOption.Text = "Options";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // txtNbrManches
            // 
            this.txtNbrManches.Location = new System.Drawing.Point(227, 13);
            this.txtNbrManches.Name = "txtNbrManches";
            this.txtNbrManches.ReadOnly = true;
            this.txtNbrManches.Size = new System.Drawing.Size(315, 20);
            this.txtNbrManches.TabIndex = 4;
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Location = new System.Drawing.Point(76, 16);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(35, 13);
            this.lblChrono.TabIndex = 5;
            this.lblChrono.Text = "label1";
            this.lblChrono.Click += new System.EventHandler(this.lblChrono_Click);
            // 
            // txtAffichageMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 460);
            this.Controls.Add(this.lblChrono);
            this.Controls.Add(this.txtNbrManches);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNbrEssai);
            this.Name = "txtAffichageMot";
            this.Text = "Partie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
>>>>>>> 836e81ec15a726ec53ab74a6bbc22f2fdf132b1c
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
=======
        private System.Windows.Forms.Label lblNbrEssai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.TextBox txtNbrManches;
        private System.Windows.Forms.Label lblChrono;
>>>>>>> 836e81ec15a726ec53ab74a6bbc22f2fdf132b1c
    }
}