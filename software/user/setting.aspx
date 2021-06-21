<%@ Page Language="C#" AutoEventWireup="true" CodeFile="setting.aspx.cs" Inherits="admin_setting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>个人设置</title>
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

        a {
            color: #ffffff;
            text-decoration: none;
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

        .wrap {
            padding: 10px;
            box-sizing: border-box;
            height: calc(100% - 50px)
        }

        .input-item {
            width: 400px;
            display: flex;
            align-items: center;
            margin: 10px 0;
        }

            .input-item span {
                flex: 0 0 90px;
                font-size: 14px;
            }

            .input-item input, .input-item select {
                flex: 1;
                height: 30px;
                border: 1px solid deepskyblue;
                outline: none;
                background: unset;
                border-radius: 4px;
                padding: 0 10px;
            }

        #submit {
            padding: 6px 25px;
            background: deepskyblue;
            border: 1px solid deepskyblue;
            cursor: pointer;
            color: #fff;
            margin-left: 90px;
            margin-top: 20px;
            border-radius: 4px;
        }

         #refresh {
            padding: 6px 25px;
            background: deepskyblue;
            border: 1px solid deepskyblue;
            cursor: pointer;
            color: #fff;
            margin-left: 20px;
            margin-top: 20px;
            border-radius: 4px;
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
                    <!---
                    <asp:LinkButton ID="item" runat="server" PostBackUrl="~/admin/item.aspx">项目管理</asp:LinkButton>
                    -->
                    <a href="item.aspx">项目管理</a>
                </div>
                <div class="menu-item">
                    <asp:Image ID="Image_plan" runat="server" Height="20px" Width="20px" ImageUrl="~/images/plan_logo.png" />
                    <!---
                    <asp:LinkButton ID="plan" runat="server" PostBackUrl="~/admin/plan.aspx">项目计划</asp:LinkButton>
                    -->
                    <a href="plan.aspx">项目计划</a>
                </div>
                <div class="menu-item active">
                    <asp:Image ID="Image_setting" runat="server" Height="20px" Width="20px" ImageUrl="~/images/setting.png" />
                    <!---
                    <asp:LinkButton ID="setting" runat="server" PostBackUrl="~/admin/setting.aspx">个人设置</asp:LinkButton>
                    -->
                    <a href="setting.aspx">个人设置</a>
                </div>
               
            </div>
            <div class="body1-rigth">
                <div class="header">
                    <span class="header-left-title">个人设置</span>
                    <div class="right">
                        <asp:Label ID="label_name" runat="server" Text="haha" Font-Size="14px"></asp:Label>
                        <a href="../common/login.aspx" class="logout">退出</a>
                    </div>
                </div>
                <div class="wrap">
                    <div class="input-item">
                        <asp:Label ID="Label8" runat="server" Text="工号"></asp:Label>
                        <asp:TextBox ID="user_userid" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
                        <asp:TextBox ID="user_name" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label5" runat="server" Text="密码"></asp:Label>
                        <asp:TextBox ID="user_password" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label4" runat="server" Text="邮箱"></asp:Label>
                        <asp:TextBox ID="user_email" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label11" runat="server" Text="电话"></asp:Label>
                        <asp:TextBox ID="user_phone" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label12" runat="server" Text="性别"></asp:Label>
                        <asp:DropDownList ID="user_sex" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>男</asp:ListItem>
                            <asp:ListItem>女</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label13" runat="server" Text="生日"></asp:Label>
                        <asp:TextBox ID="user_birthday" runat="server"></asp:TextBox>
                    </div>

                    <div class="input-item">
                        <asp:Label ID="Label3" runat="server" Text="所会技能"></asp:Label>
                        <asp:DropDownList ID="user_skill" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>android</asp:ListItem>
                            <asp:ListItem>asp.net</asp:ListItem>
                            <asp:ListItem>node.js</asp:ListItem>
                            <asp:ListItem>java</asp:ListItem>
                            <asp:ListItem>linux</asp:ListItem>
                            <asp:ListItem>数据库</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="submit" runat="server" Text="确定" OnClick="Submit_Click" />
                    <asp:Button ID="refresh" runat="server" Text="刷新" OnClick="Refresh_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
