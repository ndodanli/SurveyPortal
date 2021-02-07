<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Liste.aspx.cs" Inherits="Survey.Admin.Uye.Liste" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
        <div class="col-sm-12">
            <a href="Ekle.aspx" id="btnAnketEkle" class="btn btn-info btn-block" style="height: 50px; font-size: 16px; font-weight: 500; font-family: 'Roboto', sans-serif;"><i class="fa fa-check-square"></i>&nbsp;&nbsp;Yeni Kullanıcı Oluştur</a>
        </div>
    </div>
    <div class="row" style="margin-top: 25px">
        <div class="col-sm-12">
            <div class="panel">
                <div class="panel-heading" style="color: white; background-color: dimgray;">
                    <h3>Üye Listesi</h3>
                </div>
                <div class="panel-body">
                    <asp:ListView runat="server" ID="lvKullaniciListe">
                        <LayoutTemplate>
                            <div class="table-responsive">
                                <table class="table table-hover">
                                    <thead>
                                        <tr>
                                            <th class="text-center">Kullanıcı Adı</th>
                                            <th class="text-center">Email</th>
                                            <th class="text-center">Kullanıcı Tipi</th>
                                            <th class="text-center">Kayıt Tarihi</th>
                                            <th class="text-center">Son Giriş Tarihi</th>
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
                                <td class="text-center"><%# Eval("Kullanici_Adi") %></td>
                                <td class="text-center"><%# Eval("Kullanici_Email") %></td>
                                <td class="text-center"><%# Eval("Rol_ID") %></td>
                                <td class="text-center"><%# Eval("Kayıt_Tarihi","{0:d}") %></td>
                                <td class="text-center"><%# Eval("Son_Giris_Tarihi","{0:d}") %></td>
                                <%# (bool)Eval("Durum")==true ? "<td class="+ "\"text-center\""+"><span class="+ "\"label label-success\""+">Aktif</span></td>" : "<td class="+ "\"text-center\""+"><span class="+"\"label label-danger\""+">Pasif</span></td>" %>
                                <td class="text-center">
                                    <a href="Guncelle.aspx?kullanici-id=<%# Eval("Kullanici_ID") %>" class="btn btn-xs btn-info" data-toggle="tooltip" data-placement="top" title="Düzenle">Düzenle</a>
                                    <asp:Button ID="btnSil" Text="Sil" CssClass="btn btn-xs btn-danger" data-toggle="tooltip" data-placement="top" title="Sil" CommandArgument='<%# Eval("Kullanici_ID") %>' CommandName="Sil" OnCommand="btnSil_Command" runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="panel-footer text-center" style="color: #444444">
                    <nav aria-label="Page navigation">
                        <ul class="pagination">
                            <li>
                                <a href="#" aria-label="Previous">
                                    <span aria-hidden="true">&laquo;</span>
                                </a>
                            </li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li>
                                <a href="#" aria-label="Next">
                                    <span aria-hidden="true">&raquo;</span>
                                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
