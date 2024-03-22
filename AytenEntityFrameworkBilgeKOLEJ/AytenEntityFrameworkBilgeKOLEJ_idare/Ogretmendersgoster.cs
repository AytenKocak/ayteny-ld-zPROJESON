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
    public partial class Ogretmendersgoster : Form
    {
        public Ogretmendersgoster()
        {
            InitializeComponent();
        }


        SchoolEntities9 db = new SchoolEntities9();
        private void Ogretmendersgoster_Load(object sender, EventArgs e)
        {
            
            DoldurOgretmen();
            DoldurSınıf();

        }

        private void DoldurSınıf()
        {
            listView2.Items.Clear();
            var sorgu = from s in db.Classrooms
                        select s;
            foreach (var item in sorgu)
            {

                ListViewItem lvi = new ListViewItem(item.TeacherID.ToString());
                lvi.SubItems.Add(item.Sinifi);
                lvi.Tag = item;
                listView2.Items.Add(lvi);

            
            }
        }

        private void DoldurOgretmen()
        {
            listView1ogretmen.Items.Clear();
            var query = from t in db.Teachers

                        select t;

            foreach (var item in query)
            {
                ListViewItem liste = new ListViewItem((item.TeacherID).ToString());
                liste.SubItems.Add(item.OgretmenAdi); 
                liste.SubItems.Add(item.OgretmenSoyadi);
                liste.SubItems.Add(item.Bransi);
                liste.SubItems.Add(item.Gorev);
                liste.Tag = item;
                listView1ogretmen.Items.Add(liste);

            }
        }

        private void button1listele_Click(object sender, EventArgs e)
        {
            listView1ogretmen.Items.Clear();
            DoldurOgretmen();     
            

        }

        private void button2guncelle_Click(object sender, EventArgs e)
        {

            if (listView1ogretmen.SelectedIndices.Count > 0)
            {
                Teacher secılen = listView1ogretmen.SelectedItems[0].Tag as Teacher;
                secılen.TeacherID= Convert.ToInt32(textBox1ogrtNo.Text);
                secılen.OgretmenAdi = textBox5ogrtadı.Text;
                secılen.OgretmenSoyadi = textBox4ogrtsoyadı.Text;
                secılen.Bransi = textBox3ogrtbrans.Text;
                secılen.Gorev = textBox2ogrtgorv.Text;
                db.SaveChanges();
                DoldurOgretmen();
             
            }       

           

        }       

        private void listView1ogretmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1ogretmen.SelectedIndices.Count > 0)
            {
                Teacher teach = listView1ogretmen.SelectedItems[0].Tag as Teacher;
                textBox1ogrtNo.Text = teach.TeacherID.ToString();
                textBox5ogrtadı.Text = teach.OgretmenAdi;
                textBox4ogrtsoyadı.Text = teach.OgretmenSoyadi;
                textBox3ogrtbrans.Text = teach.Bransi;
                textBox2ogrtgorv.Text = teach.Gorev;
                db.SaveChanges();



            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                Classroom les = listView2.SelectedItems[0].Tag as Classroom;
                textBox1sınıf. Text = les.TeacherID.ToString();
                textBox1sınıf.Text = les.Sinifi;
               
                
            
            
            }
        }

        private void button1sınıfgoster_Click(object sender, EventArgs e)
        {
            DoldurSınıf();
        }

        private void button1ekle_Click(object sender, EventArgs e)
        {

            Classroom c = new Classroom();
            c.TeacherID = Convert.ToInt32(textBox1Noo. Text);
            c.Sinifi = textBox1sınıf.Text;

            
        }

        private void button1guncelle_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                Classroom secilen = listView2.SelectedItems[0].Tag as Classroom;
                secilen.TeacherID = Convert.ToInt32(textBox1Noo.Text);
                secilen.Sinifi = textBox1sınıf.Text;
                db.SaveChanges();
                DoldurSınıf();
            
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciDetay a = new OgrenciDetay();
            a.Show();

        }

      

        
    }
}

