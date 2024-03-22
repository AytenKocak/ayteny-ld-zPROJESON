using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AytenEntityFrameworkBilgeKOLEJ_idare
{
    public partial class OgrenciDetay : Form
    {
        public OgrenciDetay()
        {
            InitializeComponent();
        }

        SchoolEntities9 db = new SchoolEntities9();
        private void OgrenciDetay_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("DEVAM EDİYOR");
            comboBox1.Items.Add("DEVAM ETMİYOR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsinSchool s = new StudentsinSchool();
            s.OgrenciAdi = textBox1ogrAdı.Text;
            s.OgrenciSoyadi = textBox1soyadı.Text;
            s.TakdirBelgesi = textBox2Basarı.Text;
            s.Devam_Durumu = comboBox1.SelectedItem.ToString();           
            db.StudentsinSchools.AddObject(s);
            db.SaveChanges();

          
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1ogrAdı_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1soyadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3RaporluGun_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2Basarı_TextChanged(object sender, EventArgs e)
        {

        }

        

         

       

        

       
    }
}
