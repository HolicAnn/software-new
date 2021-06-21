<%@ Page Language="C#" AutoEventWireup="true" CodeFile="plan.aspx.cs" Inherits="admin_plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>项目计划</title>
    <style type="text/css">
        html, body, form {
            height: 100%;
        }

        .auto-style1 {
            background-color: #1a1c1f;
            height: 100%;
            width: 170px;
            border-right: 1px solid #eee;
            /*
            position: absolute;
            bottom: 0;
            top: 0;
            left: 0;

            */
        }

        #Image1 {
            border-radius: 50%;
            position: relative;
            margin: 20px;
            width: 70px;
            height: 70px;
        }

        #item {
            color: #ffffff;
            text-decoration: none;
        }

        #plan {
            color: #ffffff;
            text-decoration: none;
        }

        #user {
            color: #ffffff;
            text-decoration: none;
        }

        #count {
            color: #ffffff;
            text-decoration: none;
        }

        #setting {
            color: #ffffff;
            text-decoration: none;
        }

        .auto-style2 {
            margin-right: 41px;
            left: 29px;
            top: 0px;
        }

        .body1 {
            display: flex;
            height: 100%;
            width: 100%;
        }

        .body1-rigth {
            flex: 1;
            height: 100%;
        }

        * {
            margin: 0;
            padding: 0;
        }

        .menu-item {
            padding: 16px 0;
            box-sizing: border-box;
            display: flex;
            align-items: center;
            justify-content: center;
        }

            .menu-item img {
                margin-right: 20px;
            }

            .menu-item:hover {
                background: #ccc;
            }

            .menu-item.active {
                background: #eee;
            }

                .menu-item.active a {
                    color: deepskyblue !important;
                }

        .body1-rigth .header {
            height: 50px;
            display: flex;
            align-items: center;
            justify-content: space-between;
            padding: 0 16px;
            background-color: #1a1c1f;
            color: #fff;
            box-shadow: 0px 3px 5px #b0bdc5;
        }

            .body1-rigth .header .right {
                display: flex;
                align-items: center;
                justify-content: center;
            }

                .body1-rigth .header .right a {
                    color: #fff;
                    text-decoration: none;
                    font-size: 12px;
                    margin-left: 10px;
                }

        .header-left-title {
            font-size: 12px;
        }

        .username {
            font-size: 12px;
        }

        .create_add {
            color: #ffffff;
            background-color: deepskyblue;
            text-decoration: none;
            margin-top: 14px;
            display: inline-block;
            padding: 6px 15px;
            border-radius: 3px;
            font-size: 14px;
        }

        #edit {
            position: relative;
            color: #ffffff;
            background-color: deepskyblue;
            text-decoration: none;
            margin-top: 14px;
            display: inline-block;
            padding: 5px 15px;
            border-radius: 3px;
            font-size: 14px;
        }

        #edit_id {
            position: relative;
            color: #000000;
            margin-top: 14px;
            padding: 6px 15px;
            width: 120px;
            border-radius: 3px;
            border-radius: 3px;
            font-size: 14px;
        }

        #refresh {
            position: relative;
            color: #ffffff;
            background-color: deepskyblue;
            text-decoration: none;
            margin-top: 12px;
            display: inline-block;
            padding: 5px 15px;
            border-radius: 3px;
            font-size: 14px;
        }

        #delete {
            position: relative;
            color: #ffffff;
            background-color: deepskyblue;
            text-decoration: none;
            margin-top: 14px;
            display: inline-block;
            padding: 5px 15px;
            border-radius: 3px;
            font-size: 14px;
        }

        #delete_id {
            position: relative;
            color: #000000;
            margin-top: 14px;
            padding: 6px 15px;
            width: 120px;
            border-radius: 3px;
            border-radius: 3px;
            font-size: 14px;
        }

        #search {
            position: relative;
            color: #ffffff;
            background-color: deepskyblue;
            text-decoration: none;
            margin-top: 14px;
            display: inline-block;
            padding: 5px 15px;
            border-radius: 3px;
            font-size: 14px;
        }

        #search_id {
            position: relative;
            color: #000000;
            margin-top: 14px;
            padding: 6px 15px;
            border-radius: 3px;
            width: 120px;
            border-radius: 3px;
            font-size: 14px;
        }

        .body-wrap {
            padding: 10px;
            box-sizing: border-box;
            height: calc(100% - 50px);
            overflow: auto;
        }

        #copyright {
            color: #576060;
            margin-top: 190px;
            padding-top: 190px;
            align-items: center;
            justify-content: center;
            padding: 16px 0;
            margin-left: 18px;
            box-sizing: border-box;
            text-align: center;
        }

        #name {
            color: #576060;
            margin-top: 190px;
            padding-top: 190px;
            padding: 16px 0;
            box-sizing: border-box;
            font-size: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        #name1 {
            color: #576060;
            padding: 16px 0;
            box-sizing: border-box;
            display: flex;
            font-size: 10px;
            padding-bottom: 30px;
            align-items: center;
            justify-content: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body1">
            <div class="auto-style1">
                <asp:Image ID="Image1" ImageUrl="~/images/photo.jpg" runat="server" CssClass="auto-style2" />
                <div class="menu-item">
                    <asp:Image ID="Image_item" runat="server" Height="20px" Width="20px" ImageUrl="~/images/item_logo.png" />
                    <asp:LinkButton ID="item" runat="server" PostBackUrl="../user/item.aspx">项目管理</asp:LinkButton>
                </div>
                <div class="menu-item active">
                    <asp:Image ID="Image_plan" runat="server" Height="20px" Width="20px" ImageUrl="~/images/plan_logo.png" />
                    <asp:LinkButton ID="plan" runat="server" PostBackUrl="../user/plan.aspx">项目计划</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:Image ID="Image_setting" runat="server" Height="20px" Width="20px" ImageUrl="~/images/setting.png" />
                    <asp:LinkButton ID="setting" runat="server" PostBackUrl="../user/setting.aspx">个人设置</asp:LinkButton>
                </div>
               
            </div>
            <div class="body1-rigth">
                <div class="header">
                    <span class="header-left-title">项目计划</span>
                    <div class="right">
                        <asp:Label ID="label_name" runat="server" Text="haha" Font-Size="14px"></asp:Label>
                        <a href="../common/login.aspx" class="logout">退出</a>
                    </div>
                </div>
                <div class="body-wrap">

                    <asp:Table ID="table1" BorderWidth="1" CellPadding="7" CellSpacing="7" GridLines="Both" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Text="任务id" Style="background-color: darkgrey" />
                            <asp:TableCell Text="项目id" Style="background-color: darkgrey" />
                            <asp:TableCell Text="任务描述" Style="background-color: darkgrey" />
                            <asp:TableCell Text="优先级" Style="background-color: darkgrey" />
                            <asp:TableCell Text="人员" Style="background-color: darkgrey" />
                            <asp:TableCell Text="起始日期" Style="background-color: darkgrey" />
                            <asp:TableCell Text="完成日期" Style="background-color: darkgrey" />
                            <asp:TableCell Text="任务状态" Style="background-color: darkgrey" />
                        </asp:TableRow>
                    </asp:Table>

                    <asp:Button ID="refresh" Text="刷新" runat="server" OnClick="Refresh_Click" />
                    <asp:Button ID="search" Text="搜索" runat="server" OnClick="Search_Click" />
                    <asp:TextBox ID="search_id" runat="server" placeholder="需要搜索的计划id"></asp:TextBox>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
