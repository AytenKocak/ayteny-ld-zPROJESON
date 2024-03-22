using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AytenBilgeKOLEJ_WEB
{
    public partial class ogrenciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=worldone\AYTEN;Database=School;User Id=sa;Password=admin1234;");
            SqlCommand cmd = new SqlCommand(" select Sinifi,OgrenciAdi,OgrenciSoyadi,ResimYolu from StudentsinSchool s  join Classroom c  on s.StudentID=c.StudentID ", cnn);
            //cmd.Parameters.AddWithValue("stId", Request.QueryString["StdId"]);

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();

            cnn.Close();
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}