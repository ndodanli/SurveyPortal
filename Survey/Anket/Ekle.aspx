<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Ekle.aspx.cs" Inherits="Survey.Admin.Anket.Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="well">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Anket Oluştur</legend>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Anket Adı</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtAnketAd" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Anket Başlığı</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtAnketBasligi" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Anket Açıklaması</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtAnketAciklamasi" TextMode="MultiLine" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Başlangıç Tarihi</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtBaslangicTarih" CssClass="form-control" TextMode="Date" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Başlangıç Saati</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtBaslangicSaati" CssClass="form-control" TextMode="Time" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Bitiş Tarihi</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtBitisTarih" CssClass="form-control" TextMode="Date" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Bitiş Saati</label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtBitisSaati" CssClass="form-control" TextMode="Time" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Durum</label>
                            <div class="col-md-6">
                                <asp:RadioButtonList runat="server" ID="anketDurum">
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
