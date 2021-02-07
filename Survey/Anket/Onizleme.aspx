<%@ Page Title="Önizleme" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Onizleme.aspx.cs" Inherits="Survey.Admin.Anket.Onizleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading text-center">
            <h4>
                <asp:Label Text="" runat="server" ID="lblBaslik" /></h4>
        </div>
        <div class="panel-body">
            <asp:Repeater runat="server" ID="rptListe" OnItemDataBound="rptListe_ItemDataBound">
                <ItemTemplate>
                    <div class="col-md-12">
                        <div style="padding:5px 15px; background-color:lightslategray; color: white">
                            <asp:Literal runat="server" ID="ltSoruTipi" Text='<%# Eval("Soru_Tipi") %>' Visible="false" />
                            <asp:Literal runat="server" ID="ltSoru_ID" Text='<%# Eval("Soru_ID") %>' Visible="false" />
                            <asp:Literal runat="server" ID="ltDurum" Text='<%# Eval("Soru_Durum") %>' Visible="false" />
                            <h5>
                                <asp:Label ID="lblSoruBaslik" Text='<%# Eval("Soru_Baslik") %>' runat="server" /></h5>
                        </div>
                        <div class="well" style="border:1px solid darkgray; padding-left:50px">
                            <asp:CheckBoxList runat="server" ID="ckbSec" CssClass="checkbox"></asp:CheckBoxList>
                            <asp:RadioButtonList runat="server" ID="rbSec" CssClass="radio"></asp:RadioButtonList>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
