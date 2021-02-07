<%@ Page Title="Kullanıcı Paneli" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Survey.Admin.Dashboard" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div id="uyeKontrol" class="col-sm-12">
            <a href="Anket/Ekle.aspx"  id="btnAnketEkle" class="btn btn-info btn-block" style="height: 50px; font-size: 16px; font-weight: 500; font-family: 'Roboto', sans-serif;"><i class="fa fa-check-square"></i>&nbsp;&nbsp;Yeni Anket Oluştur</a>
        </div>
    </div>

    <div class="row" style="margin-top: 25px;">
        <div class="col-sm-12">
            <div class="col-sm-4">
                <div class="panel panel-warning">
                    <div class="panel-heading" style="color: #fff; background-color: #e27d7a; border-color: #e27d7a;">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-list-alt fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="text-center" style="font-size:large">
                                    <asp:Label runat="server" ID="txtAnketSayisi" />
                                    <h4>Anket</h4>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-4">
                <div class="panel panel-warning">
                    <div class="panel-heading" style="color: #fff; background-color: #e27d7a; border-color: #e27d7a;">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-comments fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="text-center" style="font-size:large">
                                    <asp:Label runat="server" ID="txtKatilimci" />
                                    <h4>Katılımcı</h4>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-4">
                <div class="panel panel-warning">
                    <div class="panel-heading" style="color: #fff; background-color: #e27d7a; border-color: #e27d7a;">
                        <div class="row">
                            <div class="col-xs-3">
                                <i class="fa fa-user fa-5x"></i>
                            </div>
                            <div class="col-xs-9 text-right">
                                <div class="text-center" style="font-size:large">
                                    <asp:Label runat="server" ID="txtUyeler" />
                                    <h4>Üyeler</h4>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div id="area-example" style="height: 300px;"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
    <script src="/Scripts/morris.js"></script>
</asp:Content>