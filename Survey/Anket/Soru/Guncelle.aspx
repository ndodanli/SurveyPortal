<%@ Page Title="Soru Güncelle" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Guncelle.aspx.cs" Inherits="Survey.Admin.Anket.Soru.Guncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="well">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Soru Oluştur</legend>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Soru Adı :</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtSoruAd" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Soru Tipi</label>
                            <div class="col-md-6">
                                <asp:DropDownList runat="server" ID="ddlSoruTipi" CssClass="form-control">
                                    <asp:ListItem Value="1" Text="Çoktan Tek Seçmeli" />
                                    <asp:ListItem Value="2" Text="Çoktan Çok Seçmeli" />
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Zorunlu</label>
                            <div class="col-md-6">
                                <asp:RadioButtonList runat="server" ID="rbZorunlu">
                                    <asp:ListItem Value="1" Text="Evet" />
                                    <asp:ListItem Value="0" Text="Hayır" />
                                </asp:RadioButtonList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <div class="col-md-6">
                                <asp:Button Text="Vazgeç" ID="btnIptal" CssClass="btn btn-danger btn-lg" OnClick="btnIptal_Click" runat="server" />
                                <asp:Button Text="Guncelle" ID="btnGuncelle" CssClass="btn btn-success btn-lg" OnClick="btnGuncelle_Click" runat="server" />
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
