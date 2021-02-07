<%@ Page Title="Kullanıcı Profili" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="Survey.Admin.Hesap.Profil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="well">
                <h2>Hoşgeldin <b><%= Session["uyeKadi"] %></b></h2>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-sm-6 col-md-offset-3">
            <div class="well">
                <div class="form-horizontal ">
                    <fieldset>
                        <h4><b>Kullanıcı Bilgileri</b></h4>
                        <table class="table">
                            <tr>
                                <td>E-Posta</td>
                                <td>:</td>
                                <td><asp:Label ID="txtEposta" Text="" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>Kullanıcı Adı</td>
                                <td>:</td>
                                <td>
                                    <asp:Label ID="txtKullaniciAdi" Text="" runat="server" /></td>
                            </tr>
                            <tr>
                                <td>Kayıt Tarihi</td>
                                <td>:</td>
                                <td>
                                    <asp:Label ID="txtKayitTarihi" Text="" runat="server" /></td>
                            </tr>
                              <tr>
                                <td></td>
                                <td></td>
                                <td>
                                    <a href="Email.aspx" class="btn btn-primary btn-lg btn-block">E-Mail Değişikliği</a><br />
                                    <asp:Button ID="btnVazgec" Text="Geri Dön" CssClass="btn btn-danger btn-block" OnClick="btnVazgec_Click" runat="server" />
                                    
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
