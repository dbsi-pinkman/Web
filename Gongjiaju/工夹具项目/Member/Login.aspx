<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="工夹具项目.Member.Login" %>

<!doctype html>
<html lang="zh-CN">
<head>
	<meta charset="UTF-8">

    <link href="../css/login.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
	<title>登录界面</title>
    <style>
        #showMessage{
            color:tomato;
        }
    </style>
    <script>
        $(function () {
            $(".username").blur(function () {
                checkName();
            });
            $(".username").focus(function () {
                $("#showMessage").text("");
            });
            $("#validateCode").blur(function () {
                checkValidate();
            });
            $("#validateCode").focus(function () {
                $("#showMessage").text("");
            });
            
        });
        ///用户名Ajax检验
        function checkName() {
            var username = $(".username").val();
            if (username == "") {
                $("#showMessage").text("用户名不能为空！");
            } else {
                $.post("/ashx/ValidateReg.ashx", { "id": username,"action":"name" }, function (data) {
                        $("#showMessage").text(data);
                    });
            }
        }
        ///验证码检验
        function checkValidate() {
            var code = $("#validateCode").val();
                if (code != "") {
                    var reg = /^[0-9]*$/;
                    if (reg.test(code)) {
                        $.post("/ashx/ValidateReg.ashx", { "action": "code", "validatecode": code }, function (data) {
                            $("#showMessage").text(data);
                        });
                    } else {
                        $("#showMessage").text("请输入正确的格式！");
                    }
                } else {
                    $("#showMessage").text("验证码不能为空！");
                }
        }
        
    </script>
</head>
<body>
	<div id="login_top">
		<div id="welcome">
			欢迎使用工夹具全寿命智能管理系统
		</div>
		<div id="back">
			<a href="#">返回首页</a>&nbsp;&nbsp; | &nbsp;&nbsp;
			<a href="/Html/404.html">帮助</a>
		</div>
	</div>
	<div id="login_center">
		<div id="login_area">
			<div id="login_form">
				<form method="post" runat="server">
					<div id="login_tip">
						用户登录&nbsp;&nbsp;<span id="showMessage"></span>
					</div>
					<div><input type="text" class="username" name="username" value="<%=Name %>""></div>
					<div><input type="text" class="pwd" name="pwd"></div>
					<div id="btn_area">
						<input type="submit" name="submit" id="sub_btn" value="登&nbsp;&nbsp;录">&nbsp;&nbsp;
						<input type="text" class="verify" id="validateCode" name="txtValidate">
						<img src="/ashx/ValidateCode.ashx" alt="" width="80" height="40"><br/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        <a href="FindPwd.aspx">找回密码</a><input type="hidden" name="hiddenUrl" value="<%=Returnurl %>"" />
					</div>
				</form>
			</div>
		</div>
	</div>
	<div id="login_bottom">
		2020 @XuGuo 版权所有
	</div>
</body>
</html>
