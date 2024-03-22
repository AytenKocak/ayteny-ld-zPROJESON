using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AytenBilgeKOLEJ_WEB
{
    public partial class duyurular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=worldone\AYTEN;Database=School;User Id=sa;Password=admin1234;");
            SqlCommand cmd = new SqlCommand("select Tarih,Acıklama from Duyuru", cnn);

            //           select  OgrenciAdi,OgrenciSoyadi,BirinciSınav,ikinciSınav,SonSınav from StudentsinSchool s join  Note
            //n on s.StudentID=n.StudentID 
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Repeater1.DataSource = dr;
            Repeater1.DataBind();

            cnn.Close();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}