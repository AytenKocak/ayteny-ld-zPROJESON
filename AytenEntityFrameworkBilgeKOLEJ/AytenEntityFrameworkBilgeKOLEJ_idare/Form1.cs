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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SchoolEntities9 db = new SchoolEntities9();
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldurdersadı();
            Derskredisi();
            //Doldurogretmenadı();
            //Doldurogrtsoyadı();
            //Doldurbrans();
            //Doldurgorev();


        }

        //private void Doldurgorev()
        //{
        //    var grov = from t in db.Teachers select t.Gorev;
        //    foreach (var item in grov)
        //    {
        //        comboBox4grv.DataSource= grov;
        //    }
        //}

        //private void Doldurbrans()
        //{
        //    var brans = from t in db.Teachers select t.Bransi;
        //    foreach (var item in brans)
        //    { comboBox5ogretmenbrns.DataSource = brans; }
                      
        //}

        //private void Doldurogrtsoyadı()
        //{
        //    var sorguogrtsoyadı = from t in db.Teachers select t.OgretmenSoyadi;
        //    foreach (var item in sorguogrtsoyadı)
        //    {
        //        comboBox2ogrtsoyad.DataSource = sorguogrtsoyadı.ToList();
        //    }
        //}

        //private void Doldurogretmenadı()
        //{
        //    var sorguogretmenadı = from t in db.Teachers select t.OgretmenAdi;
        //    foreach (var item in sorguogretmenadı)
        //    {
        //       comboBox1ogrtadı.DataSource= sorguogretmenadı.ToList();

        //    }
        //}

        private void Derskredisi()
        {

            var sorgukredı = from d in db.Lessons select d.DersKredi;
            foreach (var item in sorgukredı)
            {
                comboBox3derskredi.DataSource= sorgukredı.ToList();
            }
        }

        private void Doldurdersadı()
        {
            var sorgu = from d in db.Lessons select d.DersAdı;
            foreach (var item in sorgu)
            { comboBox3dersadı.DataSource = sorgu; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Teacher t = new Teacher();
            t.OgretmenAdi = textBox4ogrtadı.Text;
            t.OgretmenSoyadi = textBox3ogrtsoyadı.Text;
            t.Bransi = textBox2brans.Text;
            t.Gorev = textBox1gorev.Text;
            db.Teachers.AddObject(t);
            db.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)//dersekle butonu
        {
            

            Lesson les = new Lesson();
            les.DersAdı = comboBox3dersadı.SelectedItem.ToString();
            les.DersKredi = Convert.ToInt32(comboBox3derskredi.SelectedItem.ToString());
            les.DonemBasTarihi = dateTimePicker1baslangıc.Value;
            les.DonemBitTarihi = dateTimePicker2bıtıs.Value;
            db.Lessons.AddObject(les);
            db.SaveChanges();
            

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //private void button2_Click_1(object sender, EventArgs e)///öğretmen guncelle butonu
        //{
        //    //StudentsinSchool secilen = listView1ogrenci.SelectedItems[0].Tag as StudentsinSchool;
        //    //secilen.OgrenciAdi = textBox6ogrenciad.Text;
        //    //secilen.OgrenciSoyadi = textBox7ogrencisoyad.Text;
        //    //secilen.MezunolunanOkul = textBox4okul.Text;
        //    //secilen.NotOrt = Convert.ToInt32(textBox3ort.Text);
        //    //db.SaveChanges();
        //    //DoldurOgrenci();   
                      
           
        //}

        private void comboBox1ogrtadı_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2ogrtsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2ogrtsoyad.SelectedItem = textBox3ogrtsoyadı;
        }

        private void comboBox5ogretmenbrns_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox5ogretmenbrns.SelectedItem = textBox1bransguncelle.Text;

        }

        private void comboBox4grv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox4grv.SelectedItem = textBox1gorev.Text;
        }

        private void button3ogretmenguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ogretmendersgoster a = new Ogretmendersgoster();
            a.Show();
            //yada a.ShowDiolog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3dersadı_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}
