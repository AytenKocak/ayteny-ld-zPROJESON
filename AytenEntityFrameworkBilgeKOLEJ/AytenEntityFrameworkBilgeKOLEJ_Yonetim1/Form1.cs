using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AytenEntityFrameworkBilgeKOLEJ_Yonetim1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SchoolEntities1 db = new SchoolEntities1();
        private void Form1_Load(object sender, EventArgs e)
        {

            //DoldurOgretmen();
            //DoldurDers();
        }

        private void Doldur()
        {
            listView1.Items.Clear();

            var query = from t in db.Teachers
                        join l in db.Lessons on t.LessonID equals l.LessonID
                        select new
                        {
                            t.OgretmenAdi,
                            t.OgretmenSoyadi,
                            t.Bransi,
                            t.Gorev,
                            l.DersAdı,
                            l.DersKredi,
                            l.DonemBasTarihi,
                            l.DonemBitTarihi

                        };// bu sekıl yaptımmm///////

            foreach (var item in query)
            {
                ListViewItem lvi = new ListViewItem(item.OgretmenAdi);
                lvi.SubItems.Add(item.OgretmenSoyadi);
                lvi.SubItems.Add(item.Bransi);
                lvi.SubItems.Add(item.Gorev);
                lvi.SubItems.Add(item.DersAdı);
                lvi.SubItems.Add(item.DersKredi.ToString());
                lvi.SubItems.Add(item.DonemBasTarihi.ToString());
                lvi.SubItems.Add(item.DonemBitTarihi.ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);

            }
        }



        private void button1ögrtekle_Click(object sender, EventArgs e)
        {
            /*
             StudentsinSchool s = new StudentsinSchool();
            s.OgrenciAdi = textBox6ogrenciad.Text;
            s.OgrenciSoyadi = textBox7ogrencisoyad.Text;
            s.MezunolunanOkul = textBox4okul.Text;
            s.NotOrt = Convert.ToInt32(textBox3ort.Text);
            s.ResimYolu = Path.GetFileName(opf.FileName);
            db.StudentsinSchools.AddObject(s);
            db.SaveChanges();
            DoldurOgrenci();
             */
            /*
            Teacher t = new Teacher();
            textBox1ogretmenadı.Text = t.OgretmenAdi;
            textBox2ogretmensoyadı.Text = t.OgretmenSoyadi;
            textBox3bransı.Text = t.Bransi;
            textBox4gorevi.Text = t.Gorev;
            db.Teachers.AddObject(t);
            db.SaveChanges();
             */


            Teacher t = new Teacher();
            t.OgretmenAdi = textBox1ogretmenadı.Text;
            t.OgretmenSoyadi = textBox2ogretmensoyadı.Text;
            t.Bransi = textBox3bransı.Text;
            t.Gorev = textBox4gorevi.Text;
            db.Teachers.AddObject(t);
            db.SaveChanges();


        }

        private void button2ogrtguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button3ogrtsil_Click(object sender, EventArgs e)
        {

        }

        private void button1dersekle_Click(object sender, EventArgs e)
        {
            Lesson l = new Lesson();
            l.DersAdı = textBox7dersinadı.Text;
            if (textBox5dersinkredi.Text == "") // kredi girildiyse kredi bilgisi alınacak
            {
                MessageBox.Show("Kredi bilgisi girilmeli");
                return; // işlemi durduruu uyarıdan sonra
                l.DersKredi = Convert.ToInt32(textBox5dersinkredi.Text);///burda sorun var         
            }
            l.DonemBasTarihi = dateTimePicker1baslangıc.Value;
            l.DonemBitTarihi = dateTimePicker2bitis.Value;
            db.Lessons.AddObject(l);
            db.SaveChanges();

        }

        private void button2dersguncelle_Click(object sender, EventArgs e)
        {

        }

        private void button3derssil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doldur();
        }













    }
}
