<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sifreHatirla.aspx.cs" Inherits="KullaniciGirisi.sifreHatirla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3 style="margin-left: 80px">Şifre Hatırlatma</h3>
            <br />
            Kullanıcı Adı:
            <asp:TextBox ID="txt_kulAdi" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Tamam" OnClick="Button1_Click" />
            <asp:Label ID="lbl_kullaniciAdisorgula" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Kişinin Sorusu:
            <asp:Label ID="lbl_soru" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Kişinin Cevabı:<asp:TextBox ID="txt_cevap" runat="server" Width="239px"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Tamam" OnClick="Button2_Click" />
            <br />
            <br />
&nbsp;<p><b>Şifreniz: </b>
            <b><asp:Label ID="lbl_sifreGoster" runat="server" ForeColor="#CC0000"></asp:Label></b>
&nbsp;</p>
            <br />
        </div>
    </form>
</body>
</html>
