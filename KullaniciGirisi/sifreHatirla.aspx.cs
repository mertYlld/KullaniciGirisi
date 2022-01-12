using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace KullaniciGirisi
{
    public partial class sifreHatirla : System.Web.UI.Page
    {
        SqlConnection db;
        SqlCommand cmd;
        SqlDataReader read;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sinav;");
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            

            db.Open();

            cmd = new SqlCommand("select HatirlatmaSorusu from Kullanici where KullaniciAdi =@KullaniciAdi", db);
            cmd.Parameters.AddWithValue("KullaniciAdi", txt_kulAdi.Text);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                lbl_soru.Text = read[0].ToString();
            }
            else
            {
                lbl_kullaniciAdisorgula.Text = "Yanlış Kullanıcı Adı";
                
            }
            
            db.Close();
            
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            db.Open();

            cmd = new SqlCommand("select Sifre from Kullanici where KullaniciAdi=@KullaniciAdi and Cevap=@Cevap", db);
            cmd.Parameters.AddWithValue("KullaniciAdi", txt_kulAdi.Text);
            cmd.Parameters.AddWithValue("Cevap", txt_cevap.Text);
            read = cmd.ExecuteReader();

            if (read.Read())
            {
                lbl_sifreGoster.Text = read[0].ToString();
                
            }
            else
            {
                lbl_sifreGoster.Text = "Yanlış Cevap";
            }
            db.Close();

            lbl_kullaniciAdisorgula.Text = "";
            txt_kulAdi.Text = "";
            lbl_soru.Text= "";
            txt_cevap.Text = "";

        }
    }
}