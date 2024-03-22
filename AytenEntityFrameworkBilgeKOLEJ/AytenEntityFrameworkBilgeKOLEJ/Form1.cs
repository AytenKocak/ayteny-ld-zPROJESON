using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AytenEntityFrameworkBilgeKOLEJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        SchoolEntities18 db = new SchoolEntities18();
        private void Form1_Load(object sender, EventArgs e)
        {
            DoldurOgrenci();
            DoldurVeli();

        }

        private void DoldurVeli()
        {
            listView2veli.Items.Clear();
            var query2 = from r in db.Registerateds
                         select r;
            foreach (var item in query2)
            {
                ListViewItem lvi = new ListViewItem(item.VeliAdi);
                lvi.SubItems.Add(item.Velisoyadi);
                lvi.SubItems.Add(item.Telefon);
                lvi.SubItems.Add(item.Adres);
                lvi.SubItems.Add(item.email);
                lvi.Tag = item;
                listView2veli.Items.Add(lvi);
            }
        }

        private void DoldurOgrenci()
        {
            
            listView1ogrenci.Items.Clear();
            var query1 = from s in db.StudentsinSchools
                         select s;
            foreach (var item in query1)
            {
                ListViewItem lvi = new ListViewItem(item.OgrenciAdi);
                lvi.SubItems.Add(item.OgrenciSoyadi);
                lvi.SubItems.Add(item.MezunolunanOkul);
                lvi.SubItems.Add(item.NotOrt.ToString());
                lvi.SubItems.Add(item.ResimYolu);
                lvi.Tag = item;
                listView1ogrenci.Items.Add(lvi);



            }
        }

        private void button1ekleogrenci_Click(object sender, EventArgs e)
        {
            StudentsinSchool s = new StudentsinSchool();
            s.OgrenciAdi = textBox6ogrenciad.Text;
            s.OgrenciSoyadi = textBox7ogrencisoyad.Text;
            s.MezunolunanOkul = textBox4okul.Text;
            s.NotOrt = Convert.ToInt32(textBox3ort.Text);
            s.ResimYolu = Path.GetFileName(opf.FileName);
            db.StudentsinSchools.AddObject(s);
            db.SaveChanges();
            DoldurOgrenci();

        }

        private void button3veliekle_Click(object sender, EventArgs e)
        {
            Registerated r = new Registerated();
            r.VeliAdi = textBox2veliad.Text;
            r.Velisoyadi = textBox1velisoyad.Text;
            r.Telefon = textBox8telefon.Text;
            r.Adres = textBox9adres.Text;
            r.email = textBox1email.Text;
            db.Registerateds.AddObject(r);
            db.SaveChanges();
            DoldurVeli();
        }
                OpenFileDialog opf;
        private void button1resimekle_Click(object sender, EventArgs e)
        {
            opf = new OpenFileDialog();
            opf.ShowDialog();
            opf.Filter = "FotoğrafSeçiniz(*.jpg)|*.jpg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                Image resim = Image.FromFile(opf.FileName);
                StudentsinSchool s = new StudentsinSchool();
                s.ResimYolu = Path.GetFileName(opf.FileName);
                pictureBox1ogrenci.Image = resim;
                pictureBox1ogrenci.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void listView1ogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1ogrenci.SelectedIndices.Count > 0)
            {
                StudentsinSchool s = listView1ogrenci.SelectedItems[0].Tag as StudentsinSchool;
                textBox6ogrenciad.Text = s.OgrenciAdi;
                textBox7ogrencisoyad.Text = s.OgrenciSoyadi;
                textBox4okul.Text = s.MezunolunanOkul;
                textBox3ort.Text = s.NotOrt.ToString();
                db.SaveChanges();

            }
        }

        private void listView2veli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2veli.SelectedIndices.Count > 0)
            {
                Registerated r = listView2veli.SelectedItems[0].Tag as Registerated;
                textBox2veliad.Text = r.VeliAdi;
                textBox1velisoyad.Text = r.Velisoyadi;
                textBox8telefon.Text = r.Telefon;
                textBox9adres.Text = r.Adres;
                textBox1email.Text = r.email;
                db.SaveChanges();
              
            }
        }

        private void button2guncelleogrenci_Click(object sender, EventArgs e)
        {
            if (listView1ogrenci.SelectedIndices.Count > 0)
            {
                
                StudentsinSchool secilen = listView1ogrenci.SelectedItems[0].Tag as StudentsinSchool;
                secilen.OgrenciAdi = textBox6ogrenciad.Text;
                secilen.OgrenciSoyadi = textBox7ogrencisoyad.Text;
                secilen.MezunolunanOkul = textBox4okul.Text;
                secilen.NotOrt = Convert.ToInt32(textBox3ort.Text);
                db.SaveChanges();
                DoldurOgrenci();

            }

        }

        private void button3silogrenci_Click(object sender, EventArgs e)
        {
            if (listView1ogrenci.SelectedIndices.Count > 0)
            {
                StudentsinSchool secilen = listView1ogrenci.SelectedItems[0].Tag as StudentsinSchool;
                db.StudentsinSchools.DeleteObject(secilen);
                db.SaveChanges();
                DoldurOgrenci();
            }
        }

        private void button2veliguncelle_Click(object sender, EventArgs e)
        {
            if (listView2veli.SelectedIndices.Count > 0)
            {

                Registerated r = listView2veli.SelectedItems[0].Tag as Registerated;

                r.VeliAdi = textBox2veliad.Text;
                r.Velisoyadi = textBox1velisoyad.Text;
                r.Telefon = textBox8telefon.Text;
                r.Adres = textBox9adres.Text;
                r.email = textBox1email.Text;
                db.SaveChanges();
                DoldurVeli();
            }

               



            
        }

        private void button1velisil_Click(object sender, EventArgs e)
        { 
            
            ///////****silmiyooo
            ////if (listView2veli.SelectedIndices.Count > 0)
            ////{
            ////    Registerated sil = (Registerated)listView2veli.SelectedItems[0].Tag;
            ////    db.Registerateds.DeleteObject(sil);
            ////    db.SaveChanges();
            ////    DoldurVeli();
            ////}
        }

        private void pictureBox1ogrenci_Click(object sender, EventArgs e)
        {

        }

        private void textBox1email_TextChanged(object sender, EventArgs e)
        {

        }












    }
}





///////////////////////////////////////////////////////////////////////////////////////////////////////////

//private void Doldur()
//{
//    listView1.Items.Clear();
//    var query = from r in db.Registerateds
//              join s in db.StudentsinSchools on r.KayıtID equals s.KayıtID
//              select new
//              {
//                  s.OgrenciAdi,
//                  s.OgrenciSoyadi,
//                  s.MezunolunanOkul,
//                  s.NotOrt,
//                  r.VeliAdi,
//                  r.Velisoyadi,
//                  r.Telefon,
//                  r.Adres,
//                  r.email
//              };


//foreach (var item in query)
//{
//    ListViewItem lvi = new ListViewItem(item.OgrenciAdi);
//    lvi.SubItems.Add(item.OgrenciSoyadi);
//    lvi.SubItems.Add(item.MezunolunanOkul);
//    lvi.SubItems.Add(item.NotOrt.ToString());
//    lvi.SubItems.Add(item.VeliAdi);
//    lvi.SubItems.Add(item.Velisoyadi);
//    lvi.SubItems.Add(item.Telefon);
//    lvi.SubItems.Add(item.Adres);
//    lvi.SubItems.Add(item.email);
//    lvi.Tag = item;
//    listView1.Items.Add(lvi);

//}