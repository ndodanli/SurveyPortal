<%@ Page Title="Anket Analiz" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Analiz.aspx.cs" Inherits="Survey.Admin.Rapor.Analiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
    </div>
    <div class="row" style="margin-top: 15px">
        <div class="col-sm-12">
            <div class="panel">
                <div class="panel-heading bg-primary">
                    <h3>Anket Listesi</h3>
                </div>
                <div class="panel-body">
                    <asp:ListView runat="server" ID="lvAnket">
                        <LayoutTemplate>
                            <div class="table-responsive">
                                <table class="table table-hover">
                                    <thead>
                                        <tr>
                                            <th>Anket Adı</th>
                                            <th class="text-center">Başlangıç Tarihi</th>
                                            <th class="text-center">Bitiş Tarihi</th>
                                            <th class="text-center">Anket Katılım</th>
                                            <th class="text-center">Anket Durum</th>
                                            <th class="text-center">Anket Oluşturulma Tarihi</th>
                                            <th class="text-center">Anket Başlığı</th>
                                            <th class="text-center">Anket Açıklaması</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                                    </tbody>
                                </table>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><a href="/Anket/Onizleme.aspx?anket-id=<%# Eval("Anket_ID") %>" style="color:dimgray; font-size:12px; font-weight:bold"><%# Eval("Anket_Adi") %></a></td>
                                <td class="text-center"><%# Eval("Anket_Baslangic_Tarih","{0:d}") %></td>
                                <td class="text-center"><%# Eval("Anket_Bitis_Tarih","{0:d}") %></td>
                                <td class="text-center"><%# Eval("Anket_Katilim") %></td>
                                <td class="text-center"><%# Eval("Anket_Durum") %></td>
                                <td class="text-center"><%# Eval("Anket_Olusturulma_Tarih","{0:d}") %></td>
                                <td class="text-center"><%# Eval("Anket_Basligi") %></td>
                                <td class="text-center"><%# Eval("Anket_Aciklamasi") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
