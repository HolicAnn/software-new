<%@ Page Language="C#" AutoEventWireup="true" CodeFile="plan_detail.aspx.cs" Inherits="admin_plan_detail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>计划详情</title>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body1">
            <div class="auto-style1">
                <asp:Image ID="Image1" ImageUrl="~/images/photo.jpg" runat="server" CssClass="auto-style2" />
                <div class="menu-item">
                    <asp:Image ID="Image_item" runat="server" Height="20px" Width="20px" ImageUrl="~/images/item_logo.png" />
                    <asp:LinkButton ID="item" runat="server" PostBackUrl="~/admin/item.aspx">项目管理</asp:LinkButton>
                </div>
                <div class="menu-item active">
                    <asp:Image ID="Image_plan" runat="server" Height="20px" Width="20px" ImageUrl="~/images/plan_logo.png" />
                    <asp:LinkButton ID="plan" runat="server" PostBackUrl="~/admin/plan.aspx">项目计划</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:Image ID="Image_user" runat="server" Height="20px" Width="20px" ImageUrl="~/images/user.png" />
                    <asp:LinkButton ID="user" runat="server" PostBackUrl="~/admin/user.aspx">人员管理</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:Image ID="Image_count" runat="server" Height="20px" Width="20px" ImageUrl="~/images/count.png" />
                    <asp:LinkButton ID="count" runat="server" PostBackUrl="~/admin/count.aspx">统计分析</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:Image ID="Image_setting" runat="server" Height="20px" Width="20px" ImageUrl="~/images/setting.png" />
                    <asp:LinkButton ID="setting" runat="server" PostBackUrl="~/admin/setting.aspx">个人设置</asp:LinkButton>
                </div>
            </div>
            <div class="body1-rigth">
                <div class="header">
                    <span class="header-left-title">项目计划>详情</span>
                    <div class="right">
                        <span class="username">Hello</span>
                        <a href="../common/login.aspx" class="logout">退出</a>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
