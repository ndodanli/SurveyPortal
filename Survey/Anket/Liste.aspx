<%@ Page Title="Anket Listesi" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Liste.aspx.cs" Inherits="Survey.Admin.Anket.Liste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
        function confirm_user() {
            if (confirm("Anketi silme işlemini onaylıyormusunuz ?") == true)
                return true;
            else
                return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div id="uyeKontrol" class="col-sm-12">
            <a href="Ekle.aspx" id="btnAnketEkle" class="btn btn-info btn-block" style="height: 50px; font-size: 16px; font-weight: 500; font-family: 'Roboto', sans-serif;"><i class="fa fa-check-square"></i>&nbsp;&nbsp;Yeni Anket Oluştur</a>
        </div>
    </div>
    <div class="row" style="margin-top: 15px">
        <div class="col-sm-12">
            <div class="panel">
                <div class="panel-heading bg-primary">
                    <h3>Anket Listesi</h3>
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
                                            <th class="text-center">Durum</th>
                                            <th class="text-center">Araçlar</th>
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
                                <td><a style="color: dimgray; font-size: 12px; font-weight: bold"><%# Eval("Anket_Adi") %></a></td>
                                <td class="text-center"><%# Eval("basTarih") %></td>
                                <td class="text-center"><%# Eval("bitTarih") %></td>
                                <td class="text-center"><%# Eval("Soru_Sayi") %></td>
                                <%# (bool)Eval("Anket_Durum")==true ? "<td class="+ "\"text-center\""+"><span class="+ "\"label label-success\""+">Aktif</span></td>" : "<td class="+ "\"text-center\""+"><span class="+"\"label label-danger\""+">Pasif</span></td>" %>
                                <td class="text-center">
                                    <%#  (bool)Eval("Anket_Durum") ? (bool)Eval("Anket_Sahibi") ? "<a href=" + "\"Soru/Liste.aspx?anket-id=" + Eval("Anket_ID") + "\" class=" + "\"btn btn-xs btn-success\"" + "data-toggle="+  "\"tooltip\"" + "data-placement=" + "\"top\"" + "title=" + "\"Soru Ekle\">Sorular</a>"
                                        : "" : ""%>
                                    <%#  (bool)Eval("Anket_Durum") ? "<a href=" + "\"Onizleme.aspx?anket-id=" + Eval("Anket_ID") + "\" class=" + "\"btn btn-xs btn-primary\"" + "data-toggle="+  "\"tooltip\"" + "data-placement=" + "\"top\"" + "title=" + "\"Önizleme\">Önizleme</a>"
                                        : ""%>
                                    <%#  (bool)Eval("Anket_Durum") ? "<a href=" + "\"qrkod.aspx?anket-id=" + Eval("Anket_ID") + "\" class=" + "\"btn btn-xs btn-primary\"" + "data-toggle="+  "\"tooltip\"" + "data-placement=" + "\"top\"" + "title=" + "\"QR Kod Oluştur\">QR Kod</a>"
                                        : ""%>
                                    <%#  (bool)Eval("Anket_Sahibi") ? "<a href=" + "\"/Admin/Rapor/Analiz.aspx?anket-id=" + Eval("Anket_ID") + "\" class=" + "\"btn btn-xs btn-primary\"" + "data-toggle="+  "\"tooltip\"" + "data-placement=" + "\"top\"" + "title=" + "\"Analiz\">Analiz</a>"
                                        : ""%>
                                </td>
                                <td class="text-center">
                                    <%#  (bool)Eval("Anket_Sahibi") ? "<a href=" + "\"Guncelle.aspx?anket-id=" + Eval("Anket_ID") + "\" class=" + "\"btn btn-xs btn-info\"" + "data-toggle="+  "\"tooltip\"" + "data-placement=" + "\"top\"" + "title=" + "\"Düzenle\">Düzenle </a>"
                                        : (bool)Eval("Anket_Durum") ? " <a href=" + "\"Katil.aspx?anket-id=" + Eval("Anket_ID") + "\" class=" + "\"btn btn-xs btn-success\"" + "data-toggle="+  "\"tooltip\"" + "data-placement=" + "\"top\"" + "title=" + "\"Katıl\">Katıl </a>" : ""  %>
                                    <asp:Button ID="btnSil" Visible='<%# (bool)Eval("Anket_Sahibi") %>' Text="Sil" CssClass="btn btn-xs btn-danger" data-toggle="tooltip" data-placement="top" title="Sil" CommandArgument='<%# Eval("Anket_ID") %>' CommandName="Sil" OnCommand="btnSil_Command" OnClientClick="return confirm_user()" runat="server" />
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
                <div class="panel-footer text-center" style="color: #444444">
                    <nav aria-label="Page navigation">
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <script>
    <% if (Session["uyeKadi"] == null)
        {%>
        document.getElementById("uyeKontrol").style.display = "none";
    <%}%>
</script>
</asp:Content>
