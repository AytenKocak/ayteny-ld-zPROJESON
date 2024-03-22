namespace AytenEntityFrameworkBilgeKOLEJ_idare
{
    partial class Form1
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
            this.textBox1gorev = new System.Windows.Forms.TextBox();
            this.textBox2brans = new System.Windows.Forms.TextBox();
            this.textBox3ogrtsoyadı = new System.Windows.Forms.TextBox();
            this.textBox4ogrtadı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1baslangıc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2bıtıs = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3derskredi = new System.Windows.Forms.ComboBox();
            this.comboBox3dersadı = new System.Windows.Forms.ComboBox();
            this.button2dersekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1gorev
            // 
            this.textBox1gorev.Location = new System.Drawing.Point(40, 172);
            this.textBox1gorev.Name = "textBox1gorev";
            this.textBox1gorev.Size = new System.Drawing.Size(159, 20);
            this.textBox1gorev.TabIndex = 0;
            // 
            // textBox2brans
            // 
            this.textBox2brans.Location = new System.Drawing.Point(40, 129);
            this.textBox2brans.Name = "textBox2brans";
            this.textBox2brans.Size = new System.Drawing.Size(159, 20);
            this.textBox2brans.TabIndex = 1;
            // 
            // textBox3ogrtsoyadı
            // 
            this.textBox3ogrtsoyadı.Location = new System.Drawing.Point(40, 84);
            this.textBox3ogrtsoyadı.Name = "textBox3ogrtsoyadı";
            this.textBox3ogrtsoyadı.Size = new System.Drawing.Size(159, 20);
            this.textBox3ogrtsoyadı.TabIndex = 2;
            // 
            // textBox4ogrtadı
            // 
            this.textBox4ogrtadı.Location = new System.Drawing.Point(40, 38);
            this.textBox4ogrtadı.Name = "textBox4ogrtadı";
            this.textBox4ogrtadı.Size = new System.Drawing.Size(159, 20);
            this.textBox4ogrtadı.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(32, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(29, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Branşı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğretmen Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğrtmen Adı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(53, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Öğretmen Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.textBox3ogrtsoyadı);
            this.groupBox1.Controls.Add(this.textBox1gorev);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2brans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4ogrtadı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(70, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 311);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1baslangıc
            // 
            this.dateTimePicker1baslangıc.Location = new System.Drawing.Point(67, 169);
            this.dateTimePicker1baslangıc.Name = "dateTimePicker1baslangıc";
            this.dateTimePicker1baslangıc.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1baslangıc.TabIndex = 22;
            // 
            // dateTimePicker2bıtıs
            // 
            this.dateTimePicker2bıtıs.Location = new System.Drawing.Point(66, 227);
            this.dateTimePicker2bıtıs.Name = "dateTimePicker2bıtıs";
            this.dateTimePicker2bıtıs.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2bıtıs.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox3derskredi);
            this.groupBox2.Controls.Add(this.comboBox3dersadı);
            this.groupBox2.Controls.Add(this.button2dersekle);
            this.groupBox2.Controls.Add(this.dateTimePicker2bıtıs);
            this.groupBox2.Controls.Add(this.dateTimePicker1baslangıc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(426, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 346);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Ekle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Dönem Bitiş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Dönem Başlangıç Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Dersin Kredisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dersin Adı";
            // 
            // comboBox3derskredi
            // 
            this.comboBox3derskredi.FormattingEnabled = true;
            this.comboBox3derskredi.Location = new System.Drawing.Point(122, 86);
            this.comboBox3derskredi.Name = "comboBox3derskredi";
            this.comboBox3derskredi.Size = new System.Drawing.Size(147, 21);
            this.comboBox3derskredi.TabIndex = 32;
            // 
            // comboBox3dersadı
            // 
            this.comboBox3dersadı.FormattingEnabled = true;
            this.comboBox3dersadı.Location = new System.Drawing.Point(122, 41);
            this.comboBox3dersadı.Name = "comboBox3dersadı";
            this.comboBox3dersadı.Size = new System.Drawing.Size(147, 21);
            this.comboBox3dersadı.TabIndex = 26;
            this.comboBox3dersadı.SelectedIndexChanged += new System.EventHandler(this.comboBox3dersadı_SelectedIndexChanged);
            // 
            // button2dersekle
            // 
            this.button2dersekle.BackColor = System.Drawing.Color.DimGray;
            this.button2dersekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2dersekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2dersekle.Location = new System.Drawing.Point(110, 279);
            this.button2dersekle.Name = "button2dersekle";
            this.button2dersekle.Size = new System.Drawing.Size(138, 32);
            this.button2dersekle.TabIndex = 25;
            this.button2dersekle.Text = "Ders Ekle";
            this.button2dersekle.UseVisualStyleBackColor = false;
            this.button2dersekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(752, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 47);
            this.button3.TabIndex = 35;
            this.button3.Text = "İleri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(847, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1gorev;
        private System.Windows.Forms.TextBox textBox2brans;
        private System.Windows.Forms.TextBox textBox3ogrtsoyadı;
        private System.Windows.Forms.TextBox textBox4ogrtadı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1baslangıc;
        private System.Windows.Forms.DateTimePicker dateTimePicker2bıtıs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2dersekle;
        private System.Windows.Forms.ComboBox comboBox3dersadı;
        private System.Windows.Forms.ComboBox comboBox3derskredi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

