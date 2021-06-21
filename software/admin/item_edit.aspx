<%@ Page Language="C#" AutoEventWireup="true" CodeFile="item_edit.aspx.cs" Inherits="admin_item_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>编辑项目</title>
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
            padding: 6px 16px;
            background: deepskyblue;
            border: 1px solid deepskyblue;
            cursor: pointer;
            color: #fff;
            margin-left: 90px;
            margin-top: 20px;
            border-radius: 4px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="body1">
            <div class="auto-style1">
                <asp:Image ID="Image1" ImageUrl="~/images/photo.jpg" runat="server" CssClass="auto-style2" />
                <div class="menu-item active">
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
                <div class="menu-item">
                    <asp:Image ID="Image_user" runat="server" Height="20px" Width="20px" ImageUrl="~/images/user.png" />
                    <!---
                    <asp:LinkButton ID="user" runat="server" PostBackUrl="~/admin/user.aspx">人员管理</asp:LinkButton>
                    -->
                    <a href="user.aspx">人员管理</a>
                </div>
                <div class="menu-item ">
                    <asp:Image ID="Image_count" runat="server" Height="20px" Width="20px" ImageUrl="~/images/count.png" />
                    <!---
                    <asp:LinkButton ID="count" runat="server" PostBackUrl="~/admin/count.aspx">统计分析</asp:LinkButton>
                    -->
                    <a href="count.aspx">统计分析</a>
                </div>
                <div class="menu-item">
                    <asp:Image ID="Image_setting" runat="server" Height="20px" Width="20px" ImageUrl="~/images/setting.png" />
                    <!---
                    <asp:LinkButton ID="setting" runat="server" PostBackUrl="~/admin/setting.aspx">个人设置</asp:LinkButton>
                    -->
                    <a href="setting.aspx">个人设置</a>
                </div>
               
            </div>
            <div class="body1-rigth">
                <div class="header">
                    <span class="header-left-title">项目管理>编辑</span>
                    <div class="right">
                        <asp:Label ID="label_name" runat="server" Text="haha" Font-Size="14px"></asp:Label>
                        <a href="login.aspx" class="logout">退出</a>
                    </div>
                </div>
                <div class="wrap">
                    <div class="input-item">
                        <asp:Label ID="Label8" runat="server" Text="项目id"></asp:Label>
                        <asp:TextBox ID="item_itemid" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label1" runat="server" Text="项目名称"></asp:Label>
                        <asp:TextBox ID="item_name" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label4" runat="server" Text="项目类型"></asp:Label>
                        <asp:DropDownList ID="item_type" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>app</asp:ListItem>
                            <asp:ListItem>小程序</asp:ListItem>
                            <asp:ListItem>web网站</asp:ListItem>
                            <asp:ListItem>系统构建</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label3" runat="server" Text="所需技能"></asp:Label>
                        <asp:DropDownList ID="item_skill" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Android</asp:ListItem>
                            <asp:ListItem>Asp.net</asp:ListItem>
                            <asp:ListItem>Node.js</asp:ListItem>
                            <asp:ListItem>Java</asp:ListItem>
                            <asp:ListItem>Linux</asp:ListItem>
                            <asp:ListItem>DataBase</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label2" runat="server" Text="项目简介"></asp:Label>
                        <asp:TextBox ID="item_memo" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label5" runat="server" Text="项目人员"></asp:Label>
                        <asp:DropDownList ID="item_user" runat="server">
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem>蒋新</asp:ListItem>
                            <asp:ListItem>蒋仁雨</asp:ListItem>
                            <asp:ListItem>李知恒</asp:ListItem>
                            <asp:ListItem>余佳婧</asp:ListItem>
                            <asp:ListItem>李文阳</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label6" runat="server" Text="开始日期"></asp:Label>
                        <asp:TextBox ID="item_sdate" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label7" runat="server" Text="提交日期"></asp:Label>
                        <asp:TextBox ID="item_edate" runat="server"></asp:TextBox>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label9" runat="server" Text="项目状态"></asp:Label>
                        <asp:DropDownList ID="item_status" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>进行中</asp:ListItem>
                            <asp:ListItem>已完成</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="input-item">
                        <asp:Label ID="Label10" runat="server" Text="是否交付"></asp:Label>
                        <asp:DropDownList ID="item_is_deal" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>未交付</asp:ListItem>
                            <asp:ListItem>已交付</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button ID="submit" runat="server" Text="确定" OnClick="Submit_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
