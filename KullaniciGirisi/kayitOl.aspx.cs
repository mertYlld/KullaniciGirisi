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
    public partial class kayitOl1 : System.Web.UI.Page
    {
        SqlConnection db;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnkayitol_Click(object sender, EventArgs e)
        {
           
            db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sinav;");
            db.Open();
            cmd = new SqlCommand(@"insert into Kullanici (Adi, Soyadi, Email, KullaniciAdi, Sifre, HatirlatmaSorusu, Cevap) values(@Adi,
            @Soyadi,@Email,@KullaniciAdi,@Sifre,@HatirlatmaSorusu,@Cevap)", db);
            cmd.Parameters.AddWithValue("Adi", txt_adi.Text);
            cmd.Parameters.AddWithValue("Soyadi", txt_soyadi.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.Parameters.AddWithValue("KullaniciAdi", txt_kullaniciAdi.Text);
            cmd.Parameters.AddWithValue("Sifre", txt_sifre.Text);
            cmd.Parameters.AddWithValue("HatirlatmaSorusu", txt_hSoru.Text);
            cmd.Parameters.AddWithValue("Cevap", txt_cevap.Text);
            cmd.ExecuteNonQuery();
            db.Close();

            txt_adi.Text = "";
            txt_soyadi.Text = "";
            txt_email.Text = "";
            txt_kullaniciAdi.Text = "";
            txt_sifre.Text = "";
            txt_hSoru.Text = "";
            txt_cevap.Text = "";

            lbl_Uyari.Text = "Kayıt Olundu";
        }

        protected void txt_adi_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_soyadi_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_hSoru_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txt_cevap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}