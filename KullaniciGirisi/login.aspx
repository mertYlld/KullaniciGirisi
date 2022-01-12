<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KullaniciGirisi.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
       <h3 style="margin-left: 80px">Giriş Yapınız</h3>
        <p>&nbsp;</p>
        <p>
            Kullanıcı Adı</p>
        <p>
            <asp:TextBox ID="txtKullaniciAdi" runat="server" Width="278px" OnTextChanged="txtKullaniciAdi_TextChanged"></asp:TextBox><br />
            </p>
        <p>
            Şifre</p>
        <p>
            <asp:TextBox ID="txtSifre" runat="server" TextMode="Password" Width="279px" OnTextChanged="txtSifre_TextChanged"></asp:TextBox>
        </p>
        <p>
            <br />
        </p>
        <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" OnClick="btnGiris_Click" Width="291px" />
        <br />
        <a href="sifreHatirla.aspx">Şifremi Unuttum</a> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <a href="kayitOl.aspx">Kayıt Ol</a>
        <br />
        <asp:Label ID="lblUyari" runat="server" Text=""></asp:Label>
        <br/>
        
    </form>

    </body>
</html>
