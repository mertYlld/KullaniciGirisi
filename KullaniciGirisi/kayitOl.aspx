<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kayitOl.aspx.cs" Inherits="KullaniciGirisi.kayitOl1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form3" runat="server">
        <div >
             <h3 style="margin-left: 80px">Kayıt Ol</h3>
        <p>&nbsp;</p>
        <p>
            Adı</p>
             <p>
            <asp:TextBox ID="txt_adi" runat="server" Width="278px" OnTextChanged="txt_adi_TextChanged"></asp:TextBox><br />
             </p>
        <p>
            Soyadı</p>
             <p>
            <asp:TextBox ID="txt_soyadi" runat="server" Width="278px" OnTextChanged="txt_soyadi_TextChanged"></asp:TextBox>
            <br />
             </p>
            <p>
                Email</p>
             <p>
            <asp:TextBox ID="txt_email" runat="server" Width="278px" OnTextChanged="txt_email_TextChanged"></asp:TextBox>
            <br />
             </p>
            <p>
                Kullanıcı Adı:</p>
             <p>
            <asp:TextBox ID="txt_kullaniciAdi" runat="server" Width="278px" OnTextChanged="txt_kullaniciAdi_TextChanged"></asp:TextBox>
            <br />
             </p>
            <p>
                Şifre</p>
             <p>
            <asp:TextBox ID="txt_sifre" runat="server" TextMode="password" Width="278px" OnTextChanged="txt_sifre_TextChanged"></asp:TextBox>
             </p>
             <p>
                 Şifre Hatırlama Sorusu</p>
             <p>
            <asp:TextBox ID="txt_hSoru" runat="server" Width="278px" OnTextChanged="txt_hSoru_TextChanged"></asp:TextBox>
            <br />
             </p>
            <p>
                Şifre Hatırlama Cevabı</p>
             <p>
            <asp:TextBox ID="txt_cevap" runat="server" Width="278px" OnTextChanged="txt_cevap_TextChanged"></asp:TextBox>
            <br />
             </p>
        <asp:Button ID="btn_KayitOl" runat="server" Text="Kayıt Ol" OnClick="btnkayitol_Click" Width="278px" />
             <br />
             <a href="login.aspx" aria-atomic="False">Giriş sayfasına dön</a>
             <br />
             <asp:Label ID="lbl_Uyari" runat="server" Text=""></asp:Label>
        <br/>
        
        </div>
    </form>
</body>
</html>
