<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindPwd.aspx.cs" Inherits="工夹具项目.Member.FindPwd" %>

<!doctype html>
<html lang="zh-CN">
<head>
	<meta charset="UTF-8">
    <link href="../css/login.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
    <%--<link rel="stylesheet" href="css/login.css">
    <script type="text/javascript" src="js/jquery.min.js"></script>--%>
	<title>找回密码</title>
    <style>
        .username,.pwd{
            width:300px;
        }
        .sub_btn{
            left:300px;
        }
    </style>
    <script>
        $(function () {
            $("#sub_btn").click(function () {
                findPwd();
            });
        });
        function findPwd() {
            var txtName = $("#username").val();
            var txtMail = $("#pwd").val();
            if (txtMail != ""&&txtName !="") {
                $.post("/ashx/FindPwd.ashx", { "txtName": txtName, "txtMail": txtMail }, function(data) {
                    alert(data);
                });
            } else {
                alert("用户名或邮箱不能为空！");
            }
        } 
    </script>
</head>
<body>
	<div id="login_top">
		<div id="welcome">
			欢迎使工夹具全寿命智能管理系统
		</div>
		<div id="back">
			<a href="Login.aspx">返回首页</a>&nbsp;&nbsp; | &nbsp;&nbsp;
			<a href="#">帮助</a>
		</div>
	</div>
	<div id="login_center">
		<div id="login_area">
			<div id="login_form">
				<form method="post" runat="server">
					<div id="login_tip">
						请输入有户名和邮箱，以便找回密码！&nbsp;&nbsp;
					</div>
					<div><b>用户名：</b><input type="text" class="username" id="username"></div>
					<div><b>邮箱：</b>&nbsp;&nbsp;&nbsp;<input type="text" class="pwd" id="pwd"></div>
					<div id="btn_area">
						<input type="button" name="submit" id="sub_btn" value="找&nbsp;回&nbsp;密&nbsp;码">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						
					</div>
				</form>
			</div>
		</div>
	</div>
	<div id="login_bottom">
		版权归Xu Guo所有
	</div>
</body>
</html>
