<%@ Page Title="Soru Listesi" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Liste.aspx.cs" Inherits="Survey.Admin.Anket.Soru.Liste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function confirm_user() {
            if (confirm("Soru silme işlemini onaylıyormusunuz ?") == true)
                return true;
            else
                return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="pull-left">
                <asp:Button Text="Soru Ekle" ID="btnSoru" CssClass="btn btn-success btn-lg" Font-Size="16px" OnClick="btnSoru_Click" runat="server" />
            </div>
            <div class="pull-right">
                <asp:Button Text="Geri Dön" ID="btnGeri" CssClass="btn btn-primary btn-lg" Font-Size="16px" OnClick="btnGeri_Click" runat="server" />
            </div>
        </div>
    </div>
    <div class="row" style="margin-top: 15px">
        <div class="col-sm-12">
            <div class="panel">
                <div class="panel-heading bg-primary">
                    <h3>Soru Listesi</h3>
                </div>
                <div class="panel-body">
                    <asp:ListView runat="server" ID="lvSoruListe">
                        <LayoutTemplate>
                            <div class="table-responsive">
                                <table class="table table-hover">
                                    <thead class="h4">
                                        <tr>
                                            <th>Soru Başlığı</th>
                                            <th class="text-center">Soru Tipi</th>
                                            <th class="text-center">Oluşturulma Tarihi</th>
                                            <th class="text-center">Düzenlenme Tarihi</th>
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
                                <td><a href="Secenek/Liste.aspx?soru-id=<%# Eval("Soru_ID") %>" style="color: dimgray; font-size: 12px; font-weight: bold"><%# Eval("Soru_Baslik") %></a></td>
                                <%# (int)Eval("Soru_Tipi") == 1 ? "<td class="+ "\"text-center\""+"><span class="+ "\"label label-info\""+">Çoktan Tek Seçmeli</span></td>" : "<td class="+ "\"text-center\""+"><span class="+"\"label label-warning\""+">Çoktan Çok Seçmeli</span></td>" %>
                                <td class="text-center"><%# Eval("Soru_Olusturma_Tarih","{0:d}") %></td>
                                <td class="text-center"><%# Eval("Soru_Guncelle_Tarih","{0:d}") %></td>
                                <%# (bool)Eval("Soru_Durum")==true ? "<td class="+ "\"text-center\""+"><span class="+ "\"label label-info\""+">Zorunlu</span></td>" : "<td class="+ "\"text-center\""+"><span class="+"\"label label-warning\""+">Zorunlu Değil</span></td>" %>
                                <td class="text-center">
                                    <a href="Secenek/Liste.aspx?soru-id=<%# Eval("Soru_ID") %>" class="btn btn-xs btn-success" data-toggle="tooltip" data-placement="top" title="Seçenekler">Seçenekler</a>
                                    <a href="Guncelle.aspx?soru-id=<%# Eval("Soru_ID") %>" class="btn btn-xs btn-info" data-toggle="tooltip" data-placement="top" title="Düzenle">Düzenle</a>
                                    <asp:Button ID="btnSil" Text="Sil" CssClass="btn btn-xs btn-danger" data-toggle="tooltip" data-placement="top" title="Sil" CommandArgument='<%# Eval("Soru_ID") %>' CommandName="Sil" OnCommand="btnSil_Command" OnClientClick="return confirm_user()" runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
