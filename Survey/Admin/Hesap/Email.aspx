<%@ Page Title="Email" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="Survey.Admin.Hesap.Email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="well">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Email Değiştir</legend>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Mevcut Email</label>
                            <div class="col-sm-4">
                                <input runat="server" id="txtMevcutEmail" name="txtMevcutEmail" class="form-control" type="email" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Yeni Email</label>
                            <div class="col-sm-4">
                                <input runat="server" id="txtYeniEmail" name="txtYeniEmail" class="form-control" type="email" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Yeni Email Tekrar</label>
                            <div class="col-sm-4">
                                <input runat="server" id="txtYeniEmailTek" name="txtYeniEmailTek" class="form-control" type="email" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <div class="col-sm-4">
                                <asp:Button Text="Değiştir" ID="btnDegistir" CssClass="btn btn-success btn-lg btn-block" OnClick="btnDegistir_Click" runat="server" /><br />
                                <asp:Button Text="Vazgeç" ID="btnVazgec" CssClass="btn btn-danger btn-lg btn-block" OnClick="btnVazgec_Click" runat="server" />
                                
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <asp:Label ID="sonuc" Text="" runat="server" />
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
    <script>
        $(document).ready(function () {
            $("input[name=txtMevcutEmail]").focusout(function () {
                var mail = $(this).val();
                var kontrol1 = mail.indexOf("@");
                var kontrol2 = mail.lastIndexOf(".");
                if (kontrol1 > 0 && kontrol2 > kontrol1 && kontrol1 < mail.length) {
                    alert("E-Mail adresi geçerli");
                } else {
                    alert("E-Mail adresi geçersiz");
                }
            });
        });
    </script>
</asp:Content>
