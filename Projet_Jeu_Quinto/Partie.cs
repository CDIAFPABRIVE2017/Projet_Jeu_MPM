﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Projet_Jeu_Quinto
{
    public partial class txtAffichageMot : Form
    {
        public txtAffichageMot()
        {
            InitializeComponent();
        }

        private void lblChrono_Click(object sender, EventArgs e)
        {
            Stopwatch chrono = new Stopwatch();

            if (/*//BtnNvlPartie_Click))*/)
                {
                chrono.Start();
                Thread.Sleep(10000);
                }

            if(/*BtnQuitter || mancheFini)*/)
            {
                chrono.Stop();
                TimeSpan ts = Stopwatch.Elapsed;
            }
        }
    }
}
