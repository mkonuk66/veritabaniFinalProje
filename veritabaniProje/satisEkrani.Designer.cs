﻿
namespace veritabaniProje
{
    partial class satisEkrani
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
            this.addID = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.debtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(188, 50);
            this.addID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(174, 20);
            this.addID.TabIndex = 1;
            this.addID.TextChanged += new System.EventHandler(this.addID_TextChanged);
            this.addID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addID_KeyPress);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProductButton.ForeColor = System.Drawing.Color.Sienna;
            this.addProductButton.Location = new System.Drawing.Point(61, 110);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(92, 43);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Ürünü Ekle";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProductButton.ForeColor = System.Drawing.Color.Sienna;
            this.deleteProductButton.Location = new System.Drawing.Point(236, 110);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(92, 44);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Ürünü Sil";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // cashButton
            // 
            this.cashButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cashButton.ForeColor = System.Drawing.Color.Sienna;
            this.cashButton.Location = new System.Drawing.Point(61, 295);
            this.cashButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(104, 38);
            this.cashButton.TabIndex = 5;
            this.cashButton.Text = "Peşin";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // debtButton
            // 
            this.debtButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debtButton.ForeColor = System.Drawing.Color.Sienna;
            this.debtButton.Location = new System.Drawing.Point(236, 295);
            this.debtButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.debtButton.Name = "debtButton";
            this.debtButton.Size = new System.Drawing.Size(98, 38);
            this.debtButton.TabIndex = 6;
            this.debtButton.Text = "Cari";
            this.debtButton.UseVisualStyleBackColor = true;
            this.debtButton.Click += new System.EventHandler(this.debtButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "BARKOD NO GİRİNİZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(137, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ÖDEME BİÇİMİ";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Sepet",
            "----------"});
            this.listBox1.Location = new System.Drawing.Point(418, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 199);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tutar Toplamı :\r\n";
            // 
            // satisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debtButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "satisEkrani";
            this.Text = "SATIŞ EKRANI";
            this.Load += new System.EventHandler(this.satisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button debtButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}