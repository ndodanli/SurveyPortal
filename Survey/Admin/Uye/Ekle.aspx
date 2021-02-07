<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Ekle.aspx.cs" Inherits="Survey.Admin.Uye.Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="well">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Üye Ekle</legend>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Kullanıcı Adı</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtKullanici" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Parola</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtParola" TextMode="Password" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Parola Tekrar</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtParolaTek" TextMode="Password" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Email</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Tip</label>
                            <div class="col-md-6">
                                <asp:DropDownList runat="server" ID="ddlKullaniciTip" CssClass="form-control">
                                    <asp:ListItem Value="1" Text="Admin" />
                                    <asp:ListItem Value="2" Text="User" />
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Durum</label>
                            <div class="col-md-6">
                                <asp:RadioButtonList runat="server" ID="rbKullaniciDurum" CssClass="radio-inline">
                                    <asp:ListItem Value="1" Text="Aktif" />
                                    <asp:ListItem Value="0" Text="Pasif" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <div class="col-md-6">
                                <asp:Button Text="Vazgeç" ID="btnIptal" CssClass="btn btn-danger btn-lg" OnClick="btnIptal_Click" runat="server" />
                                <asp:Button Text="Kaydet" ID="btnKaydet" CssClass="btn btn-success btn-lg" OnClick="btnKaydet_Click" runat="server" />
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-sm-4"></div>
                            <div class="col-md-6">
                                <asp:Label Text="" ID="Mesaj" runat="server" />
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
