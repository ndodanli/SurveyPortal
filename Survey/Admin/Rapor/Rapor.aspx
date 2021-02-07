<%@ Page Title="Anket Rapor" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Rapor.aspx.cs" Inherits="Survey.Admin.Rapor.Rapor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel">
                <div class="panel-heading bg-primary">
                    <h3>Anket Raporları</h3>
                </div>
                <div class="panel-body">
                    <asp:ListView runat="server" ID="lvAnketListe" onpagepropertieschanging="lvAnketListe_PagePropertiesChanging">
                        <LayoutTemplate>
                            <div class="table-responsive">
                                <table class="table table-hover">
                                    <thead class="h4">
                                        <tr>
                                            <th>Anket Adı</th>
                                            <th class="text-center">Başlangıç Tarihi</th>
                                            <th class="text-center">Bitiş Tarihi</th>
                                            <th class="text-center">Soru Sayısı</th>
                                            <th class="text-center">Anket Katılım</th>
                                            <th class="text-center">Durum</th>
                                            <th class="text-center">İşlemler</th>
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
                                <td><a href="/Anket/Onizleme.aspx?anket-id=<%# Eval("Anket_ID") %>" style="color: dimgray; font-size: 12px; font-weight: bold"><%# Eval("Anket_Adi") %></a></td>
                                <td class="text-center"><%# Eval("basTarih") %></td>
                                <td class="text-center"><%# Eval("bitTarih") %></td>
                                <td class="text-center"><%# Eval("Soru_Sayi") %></td>
                                <td class="text-center"><%# Eval("Anket_Katilim") %></td>
                                <%# (bool)Eval("Anket_Durum")==true ? "<td class="+ "\"text-center\""+"><span class="+ "\"label label-success\""+">Aktif</span></td>" : "<td class="+ "\"text-center\""+"><span class="+"\"label label-danger\""+">Pasif</span></td>" %>
                                <td class="text-center">
                                    <a href="Analiz.aspx?anket-id=<%# Eval("Anket_ID") %>" class="btn btn-xs btn-primary" data-toggle="tooltip" data-placement="top" title="Analiz">Analiz</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                    <div class="text-center">
                        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lvAnketListe" PageSize="5">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ButtonCssClass="btn btn-info" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
