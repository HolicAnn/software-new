<%@ Page Language="C#" AutoEventWireup="true" CodeFile="time.aspx.cs" Inherits="admin_time" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:Timer ID="tmrStock" runat="server" OnTick="TmrStock_Tick" Interval="5000" />
            <asp:UpdatePanel ID="upStock" runat="server" UpdateMode="Conditional">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="tmrStock" />
                </Triggers>
                <ContentTemplate>
                    <asp:Label ID="time" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:RadioButtonList ID="rdoltFrequency" runat="server" AutoPostBack="true"
                OnSelectIndexChanged="RdoltFrequency_SelectIndexChanged" OnSelectedIndexChanged="rdoltFrequency_SelectedIndexChanged">
                <asp:ListItem Value="1000">1秒</asp:ListItem>
                <asp:ListItem Value="3000">3秒</asp:ListItem>
                <asp:ListItem Value="5000">5秒</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="updatetime" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
