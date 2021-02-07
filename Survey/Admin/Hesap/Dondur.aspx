<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Dondur.aspx.cs" Inherits="Survey.Admin.Hesap.Dondur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="well">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Hesabı Dondur</legend>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Parolanız</label>
                            <div class="col-sm-6">
                               <input type="password" name="txtParola" class="form-control" placeholder="Parola" /><br />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label"></label>
                            <div class="col-md-6">
                                <asp:Button Text="Kaydet" ID="dondur" CssClass="btn btn-danger btn-lg" OnClick="dondurButton" runat="server" />
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
