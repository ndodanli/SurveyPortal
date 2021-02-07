<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Survey.Login" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anket Portal | Giriş</title>
    <link href="Content/reset.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/login.css" rel="stylesheet" />
    <script src="scripts/jquery-3.1.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</head>
<body>
    <div>
        <div class="container">
            <div class="logo text-center" style="margin-top: 10px; margin-right: 10px">
                <img src="Content/logo-bg.png" />
            </div>
            <form runat="Server" method="post" action="GirisYap.aspx" id="loginbox">
                <div class="form-horizontal">
                    <input type="text" name="txtKullaniciAdi" class="form-control" placeholder="Kullanıcı Adı" /><br />
                    <input type="password" name="txtParola" class="form-control" placeholder="Parola" /><br />
                    <input type="submit" class="btn btn-primary btn-lg btn-block" value="Giriş" />
                    <a href="Signup.aspx" class="btn btn-danger btn-lg btn-block">Kayıt Ol</a>
                </div>
                <br />
                <%
                    if (Request.QueryString["h"] != null)
                    {
                        if (Request.QueryString["h"].ToString() == "1")
                        {
                %>
                <div class="alert alert-danger text-center">Lütfen Kullanıcı Adı veya Parola Giriniz!</div>
                <%} %>
                <%
                    if (Request.QueryString["h"].ToString() == "2")
                    {
                %>
                <div class="alert alert-danger text-center">Girilen Kullanıcı Adı veya Parola Geçersiz!</div>
                <%}%>
                <%
                    if (Request.QueryString["h"].ToString() == "3")
                    {
                %>
                <div class="alert alert-danger text-center">Kullanıcı Pasif Durumdadır!</div>
                <%}%>
                <%
                    } %>
            </form>
        </div>
    </div>
</body>
</html>
