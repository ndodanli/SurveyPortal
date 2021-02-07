<%@ Page Title="Seçenek Güncelle" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Guncelle.aspx.cs" Inherits="Survey.Admin.Anket.Soru.Secenek.Guncelle" %>
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
                            <label class="col-sm-4 control-label">Seçenek Adı :</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtSecenekAd" CssClass="form-control" />
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
