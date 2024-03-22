using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AytenEntityFrameworkBilgeKoleji_NotGris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         SchoolEntities3 db = new SchoolEntities3 ();
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lesson l= new Lesson();
            l.DersAdı=textBox8Dersadı.Text;
            db.Lessons.AddObject(l);
            db.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsinSchool s= new StudentsinSchool();
            s.StudentID=Convert.ToInt32(textBox1NO.Text);
            s.OgrenciAdi=textBox6Ogradı.Text;
            s.OgrenciSoyadi=textBox5ogrSoyadı.Text;
            db.StudentsinSchools.AddObject(s);
            db.SaveChanges();
        }

        private void button2notgir_Click(object sender, EventArgs e)
        {  
            Note n= new Note();
            n.BirinciSınav=Convert.ToInt32(textBox4İlkSınav.Text);
            n.ikinciSınav=Convert.ToInt32(textBox3İkinciSınav.Text);
            n.SonSınav=Convert.ToInt32(textBox2SonSınav.Text);
            n.Davranıspuan=Convert.ToInt32(textBox1Davranıs.Text);
            db.Notes.AddObject(n);
            db.SaveChanges();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotListele a = new NotListele();
            a.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
