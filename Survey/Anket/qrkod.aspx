<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qrkod.aspx.cs" Inherits="Survey.Admin.Anket.qrkod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anket QR Kod</title>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="margin-top: 100px;">
            <asp:Label ID="hata" Text="" runat="server" />
            <asp:Panel runat="server" ID="panelQr" Visible="false">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h2>Kodu Kullanarak Ankete Katılabilirsiniz.</h2>
                    </div>
                    <div class="col-md-12 text-center" style="margin-top:25px;">
                        <asp:Image ID="qrResim" runat="server" />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
