<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="gitHubTestBranch_VS2012.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="login" runat="server" OnAuthenticate="login_Authenticate"></asp:Login>
        <asp:Label id="lblmsg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
