using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KullaniciGirisi
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection db;
        SqlCommand com;
        SqlDataReader read;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sinav;");
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            

            db.Open();
            com = new SqlCommand("select * from Kullanici where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", db);
            com.Parameters.AddWithValue("KullaniciAdi", txtKullaniciAdi.Text);
            com.Parameters.AddWithValue("Sifre", txtSifre.Text);
            read = com.ExecuteReader();

            if (read.Read())
            {
                db.Close();
                Response.Redirect("admin.aspx");
            }
            else
            {
                lblUyari.Text = "Kullanıcı adı veya şifre hatalı";
            }
            db.Close();
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";

        }


        protected void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
   

        protected void sifremiUnuttum_Click(object sender, EventArgs e)
        {
            
        }

        protected void kayitOl_Click(object sender, EventArgs e)
        {

        }
    }
}