﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabaniProje
{
    public partial class musteriArayuzu : Form
    {
        public musteriArayuzu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniMusteriEkleme yme = new yeniMusteriEkleme();
            yme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitliMusteri km = new kayitliMusteri();
            km.Show();
        }
    }
}