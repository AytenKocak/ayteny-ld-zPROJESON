﻿namespace AytenEntityFrameworkBilgeKOLEJ_idare
{
    partial class OgrenciDetay
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1ogrAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2Basarı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3RaporluGun = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1soyadı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(422, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Detay Giriniz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1ogrAdı
            // 
            this.textBox1ogrAdı.Location = new System.Drawing.Point(319, 44);
            this.textBox1ogrAdı.Name = "textBox1ogrAdı";
            this.textBox1ogrAdı.Size = new System.Drawing.Size(121, 20);
            this.textBox1ogrAdı.TabIndex = 1;
            this.textBox1ogrAdı.TextChanged += new System.EventHandler(this.textBox1ogrAdı_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(135, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2Basarı
            // 
            this.textBox2Basarı.Location = new System.Drawing.Point(319, 217);
            this.textBox2Basarı.Name = "textBox2Basarı";
            this.textBox2Basarı.Size = new System.Drawing.Size(121, 20);
            this.textBox2Basarı.TabIndex = 9;
            this.textBox2Basarı.TextChanged += new System.EventHandler(this.textBox2Basarı_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(135, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Başarı Durumu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3RaporluGun
            // 
            this.textBox3RaporluGun.Location = new System.Drawing.Point(319, 133);
            this.textBox3RaporluGun.Name = "textBox3RaporluGun";
            this.textBox3RaporluGun.Size = new System.Drawing.Size(121, 20);
            this.textBox3RaporluGun.TabIndex = 11;
            this.textBox3RaporluGun.TextChanged += new System.EventHandler(this.textBox3RaporluGun_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(135, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Raporlu Gün Sayısı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(135, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Devam Durumu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1soyadı
            // 
            this.textBox1soyadı.Location = new System.Drawing.Point(319, 89);
            this.textBox1soyadı.Name = "textBox1soyadı";
            this.textBox1soyadı.Size = new System.Drawing.Size(121, 20);
            this.textBox1soyadı.TabIndex = 20;
            this.textBox1soyadı.TextChanged += new System.EventHandler(this.textBox1soyadı_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(135, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Öğrenci Soyadı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(716, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1soyadı);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3RaporluGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2Basarı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1ogrAdı);
            this.Controls.Add(this.button1);
            this.Name = "OgrenciDetay";
            this.Text = "OgrenciDetay";
            this.Load += new System.EventHandler(this.OgrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1ogrAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2Basarı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3RaporluGun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1soyadı;
        private System.Windows.Forms.Label label3;
    }
}