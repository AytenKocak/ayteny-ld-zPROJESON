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
    public partial class NotListele : Form
    {
        public NotListele()
        {
            InitializeComponent();
        }

        SchoolEntities3 db = new SchoolEntities3();
        private void NotListele_Load(object sender, EventArgs e)
        {
            
        }

        private void DoldurNoT()
        {
            listView1.Items.Clear();
            var query = from s in db.StudentsinSchools
                        join n in db.Notes on s.StudentID equals n.StudentID
                        join l in db.Lessons on n.LessonID equals l.LessonID
                        select new
                        {  s.StudentID,
                            s.OgrenciAdi,
                            s.OgrenciSoyadi,
                            l.DersAdı,
                            n.BirinciSınav,
                            n.ikinciSınav,
                            n.SonSınav,
                            n.Davranıspuan

                        };


            foreach (var item in query)
            {
                ListViewItem lvi = new ListViewItem(item.StudentID.ToString());
                lvi.SubItems.Add(item.OgrenciAdi);
                lvi.SubItems.Add(item.OgrenciSoyadi);
                lvi.SubItems.Add(item.DersAdı);
                lvi.SubItems.Add(item.BirinciSınav.ToString());
                lvi.SubItems.Add(item.ikinciSınav.ToString());
                lvi.SubItems.Add(item.SonSınav.ToString());
                lvi.SubItems.Add(item.Davranıspuan.ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);

            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoldurNoT();
        }


    }
}
