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
    public partial class kayitliTedarikci : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public kayitliTedarikci()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri1;
        private void button1_Click(object sender, EventArgs e)
        {
            gonderilecekveri1 = textBox1.Text;
            var musteri = new Entity.tTedarikci();
            int kontrol = Convert.ToInt32(textBox1.Text);
            var product = dbcontext.tTedarikcis.FirstOrDefault(x => x.tedarikciId == kontrol);
            if (product == null)
            {
                MessageBox.Show("Böyle bir tedarikci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tedarikcininBorcDurumu f2 = new tedarikcininBorcDurumu();
                f2.Show();
                this.Close();
            }
        }
    }
}
