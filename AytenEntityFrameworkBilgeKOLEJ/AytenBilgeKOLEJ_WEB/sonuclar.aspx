<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sonuclar.aspx.cs" Inherits="AytenBilgeKOLEJ_WEB.sonuclar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css.css" rel="stylesheet" type="text/css" />
    <%--  <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />--%>
    <link href="stilim.css" rel="stylesheet" type="text/css" />
    <link href="stillerim/stilim.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 167px;
            height: 125px;
        }
    </style>
    <link href="stillerim/iletisim.css" rel="stylesheet" type="text/css" />
    <link href="csslerim/iletisim.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="header">
       <table><tr> <td height="70" valign="top" bgcolor="#F0E2D0" class="welcome" style="padding-left:24px; padding-right:25px; "><br />
<h2>BİLGE KOLEJİ</h2></td></tr></table><br /><td width="702" height="36" style="background-image:url(images/index_28.gif); background-repeat:repeat-x;"><pre class="menu"> <a href="defoult.aspx">AnaSayfa</a>    |    <a href="hakkımızda.aspx">Hakkımızda</a>    |    <a href="ogrenciler.aspx">Öğrenciler</a>    |    <a href="sonuclar.aspx">Sonuçlar</a>    |    <a href="duyurular.aspx">Duyurular</a>       |    <a href="iletisim.aspx">İletişim</a>      </pre></td>
            </div>
        <div id="content">
            <h3> SINAV SONUÇLARI </h3> 
                <asp:Repeater ID="Repeater1" runat="server" 
                onitemcommand="Repeater1_ItemCommand">
                    <HeaderTemplate>
                        <table width='650' border='2' align='center' >
                            <tr>
                            <th>
                                    Sınıfı
                                </th>
                                <th>
                                    Dersin Adı
                                </th>
                                <th>
                                    Öğrencinin Adı
                                </th>
                                <th>
                                    Öğrencinin Soyadı
                                </th>
                                <th>
                                    Birinci Sınav
                                </th>
                                <th>
                                    İkinci Sınav
                                </th>
                                <th>
                                    Son Sınav
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                        <td>
                                <%# Eval("Sinifi")%>
                            </td>
                            <td>
                                <%# Eval("DersAdı")%>
                            </td>
                            <td>
                                <%# Eval("OgrenciAdi")%>
                            </td>
                            <td>
                                <%# Eval("OgrenciSoyadi")%>
                            </td>
                            <td>
                                <%# Eval("BirinciSınav")%>
                            </td>
                            <td>
                                <%#Eval("ikinciSınav")%>
                            </td>
                            <td>
                                <%#Eval("SonSınav")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
        <br />
        <br />
            <div>
            </div>
        </div>
        <div id="footer"> <td width="702" height="36" style="background-image:url(images/index_28.gif); background-repeat:repeat-x;"><pre class="menu"> <a href="defoult.aspx">AnaSayfa</a>    |    <a href="hakkımızda.aspx">Hakkımızda</a>    |    <a href="classroom.aspx">Öğrenciler</a>    |    <a href="sınavsonucları.aspx">Sonuçlar</a>    |    <a href="duyurular.aspx">Duyurular</a>    |    <a href="veligrisi.aspx">VeliGrişi</a>    |    <a href="iletisim.aspx">İletişim</a>    |    <a href="content.html">News</a>    </pre></td>
        </div>
    </div>
    </form>
</body>
</html>
