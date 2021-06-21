<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="user_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
    <style type="text/css">
        @import"https://cdn.bootcss.com/font-awesome/5.8.2/css/all.css";

        body {
            margin: 0;
            padding: 0;
            font-family: sans-serif;
            background: url(https://pic4.zhimg.com/f56513788384645db768d0ec542dec33_r.jpg?source=1940ef5c) no-repeat;
            background-size: cover;
            background-color: black;
        }

        .login-box {
            width: 280px;
            position: absolute;
            top: 35%;
            left: 50%;
            transform: translate(-50%,-50%);
            color: white;
        }

            .login-box h1 {
                float: left;
                font-size: 35px;
                border-bottom: 6px solid #87CEEB;
                margin-bottom: 50px;
                padding: 13px 0;
            }

        .textbox {
            width: 100%;
            overflow: hidden;
            font-size: 20px;
            padding: 8px 0;
            margin: 8px 0;
            border-bottom: 1px solid white;
        }

            .textbox i {
                width: 26px;
                float: left;
                text-align: center;
                margin-top: 8px;
            }

        #userid {
            width: 100%;
            overflow: hidden;
            font-size: 20px;
            padding: 8px 0;
            margin: 8px 0;
            border-bottom: 1px solid #b1c9d5;
            border: white;
            outline: none;
            background: none;
            color: white;
            font-size: 18px;
            width: 80%;
            float: left;
            margin: 0 10px;
        }

        #password {
            width: 100%;
            overflow: hidden;
            font-size: 20px;
            padding: 8px 0;
            margin: 8px 0;
            border-bottom: 1px solid #b1c9d5;
            border: white;
            outline: none;
            background: none;
            color: white;
            font-size: 18px;
            width: 80%;
            float: left;
            margin: 0 10px;
        }

        .auto-style1 {
            margin-left: 0px;
        }

        #login {
            width: 100%;
            background: none;
            border: 2px solid #87CEEB;
            color: white;
            padding: 5px;
            font-size: 18px;
            cursor: pointer;
            margin: 12px 0;
        }

        #register {
            width: 100%;
            background: none;
            border: 2px solid #87CEEB;
            color: white;
            padding: 5px;
            font-size: 18px;
            text-align: center;
            cursor: pointer;
            text-decoration: none;
            margin: 12px 0;
        }

    </style>
</head>
<body>
    <form runat="server" class="login-box">
        <h1 style="color: grey">项目外包管理系统</h1>
        <div class="textbox">
            <i class="fa fa-user" aria-hidden="true"></i>
            <asp:TextBox ID="userid" runat="server" placeholder="请输入工号"></asp:TextBox>
        </div>
        <div class="textbox">
            <i class="fa fa-lock" aria-hidden="true"></i>
            <asp:TextBox ID="password" runat="server" placeholder="请输入密码" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="login" runat="server" Text="登录" CssClass="auto-style1" Width="280px" OnClick="login_Click" Style="color: grey;" />
        <br />
        <asp:LinkButton ID="register" runat="server" Text="我要注册" CssClass="auto-style1" Width="267px" PostBackUrl="../common/sign.aspx" Style="color: grey;" />
    </form>
    
</body>
</html>
