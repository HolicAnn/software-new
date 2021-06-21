<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sign.aspx.cs" Inherits="user_sign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>注册账号</title>
    <style>
        body {
            background: url(https://pic3.zhimg.com/v2-fbbb97b977b5cebc66dc3cefab0ac981_r.jpg?source=1940ef5c) no-repeat;
            background-size: cover;
        }

        .wrap {
            padding: 10px;
            box-sizing: border-box;
            height: calc(100% - 50px);
            margin-left: 65px;
            padding-left: 65px;
            margin-top: 70px;
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
                border: 1px solid white;
                outline: none;
                background: unset;
                border-radius: 4px;
                padding: 0 10px;
            }

        #submit {
            padding: 6px 45px;
            background: deepskyblue;
            border: 1px solid deepskyblue;
            cursor: pointer;
            color: #fff;
            margin-left: 90px;
            margin-top: 20px;
            border-radius: 4px;
        }

        #send {
            padding: 6px 16px;
            background: deepskyblue;
            border: 1px solid deepskyblue;
            cursor: pointer;
            color: #fff;
            margin-left: 10px;
            border-radius: 4px;
        }

        a {
            padding: 6px 45px;
            background: deepskyblue;
            border: 1px solid deepskyblue;
            cursor: pointer;
            color: #fff;
            text-decoration: none;
            margin-left: 10px;
            border-radius: 4px;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="input-item">
                <asp:Label ID="Label1" runat="server" Text="姓名"></asp:Label>
                <asp:TextBox ID="user_name" runat="server"></asp:TextBox>
            </div>
            <div class="input-item">
                <asp:Label ID="Label5" runat="server" Text="密码"></asp:Label>
                <asp:TextBox ID="user_password" runat="server"></asp:TextBox>
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
            <div class="input-item">
                <asp:Label ID="Label4" runat="server" Text="邮箱"></asp:Label>
                <asp:TextBox ID="user_email" runat="server"></asp:TextBox>
                <asp:Button ID="send" runat="server" Text="发送验证码" OnClick="send_Click" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="user_email" Display="Dynamic" ErrorMessage="邮箱不能为空!"></asp:RequiredFieldValidator>
            </div>
            <div class="input-item">
                <asp:Label ID="Label2" runat="server" Text="验证码"></asp:Label>
                <asp:TextBox ID="user_code" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="submit" runat="server" Text="确定注册" OnClick="submit_Click" />
            <a href="login.aspx">点击登录</a>
        </div>
    </form>
</body>
</html>
