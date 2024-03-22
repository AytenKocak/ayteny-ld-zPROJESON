<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ogrenciler.aspx.cs" Inherits="AytenBilgeKOLEJ_WEB.ogrenciler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
  
    <link href="stillerim/sınıfstilcss.css" rel="stylesheet" type="text/css" />
    <link href="csslerim/sınıfstill.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
    <div id="header">
        <img src="resimlerim/BilgeKolejı.jpg" style="height: 105px; width: 160px" />

        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="defoult.aspx" >Anasayfa</a>&nbsp;|&nbsp;<a href="hakkımızda.aspx">Hakkımızda</a>&nbsp;|&nbsp;<a href="ogrenciler.aspx">Öğrenciler</a>&nbsp;|&nbsp;<a href="sonuclar.aspx">Sonuçlar</a>&nbsp;|&nbsp;<a href="duyurular.aspx">Duyurular</a>&nbsp;|&nbsp;<a href="veligrisi.aspx">VeliGrişi</a>&nbsp;|&nbsp;<a href="iletisim.aspx">İletişim</a>
 
        </div>
        <div id="anakontent">
            <h2>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ÖĞRENCİLERİMİZ</h2>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
                RepeatDirection="Horizontal" 
                onselectedindexchanged="DataList1_SelectedIndexChanged">
                <ItemTemplate>
                    <div id="anadiv">
                        <div id="fotodiv">
                            <asp:Image ID="Image1" runat="server" src='<%#"~/../students/"+Eval("ResimYolu") %>' />
                        </div><br />
                        <div id="sınıf"> <%#  Eval("Sinifi") %></div>
                        <div id="isim">
                            <b>Adı  Soyadı:
                                <%# Eval("OgrenciAdi") %><br />
                        </div><a> <%# Eval("OgrenciSoyadi")%></a>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    </form>
</body>
</html>
