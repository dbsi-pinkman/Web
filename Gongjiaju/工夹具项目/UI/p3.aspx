<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="p3.aspx.cs" Inherits="工夹具项目.UI.p3" %>

<!doctype html>
<html lang="zh-CN">
<head>
  <meta charset="UTF-8">
    <link href="../css/common.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/easyui.css" rel="stylesheet" />
    <link href="../css/themes/icon.css" rel="stylesheet" />
    <script src="../js/jquery.min.js"></script>
    <script src="../js/jquery.easyui.min.js"></script>
    <script src="../js/jquery.SuperSlide.js"></script>
    <script src="../js/easyui-lang-zh_CN.js"></script>
  
  <script type="text/javascript">
  $(function(){
      $(".sideMenu").slide({
         titCell:"h3", 
         targetCell:"ul",
         defaultIndex:0, 
         effect:'slideDown', 
         delayTime:'500' , 
         trigger:'click', 
         triggerTime:'150', 
         defaultPlay:true, 
         returnDefault:false,
         easing:'easeInQuint',
         endFun:function(){
              scrollWW();
         }
       });
      $(window).resize(function() {
          scrollWW();
      });
  });
  function scrollWW(){
    if($(".side").height()<$(".sideMenu").height()){
       $(".scroll").show();
       var pos = $(".sideMenu ul:visible").position().top-38;
       $('.sideMenu').animate({top:-pos});
    }else{
       $(".scroll").hide();
       $('.sideMenu').animate({top:0});
       n=1;
    }
  } 

var n=1;
function menuScroll(num){
  var Scroll = $('.sideMenu');
  var ScrollP = $('.sideMenu').position();
  /*alert(n);
  alert(ScrollP.top);*/
  if(num==1){
     Scroll.animate({top:ScrollP.top-38});
     n = n+1;
  }else{
    if (ScrollP.top > -38 && ScrollP.top != 0) { ScrollP.top = -38; }
    if (ScrollP.top<0) {
      Scroll.animate({top:38+ScrollP.top});
    }else{
      n=1;
    }
    if(n>1){
      n = n-1;
    }
  }
}
  </script>
  <title>高级用户管理界面</title>
</head>
<body>
    <div class="top">
      <div id="top_t">
        <div id="logo" class="fl"></div>
        <div id="photo_info" class="fr">
          <div id="photo" class="fl">
            <a href="#"><img src="images/a.png" alt="" width="60" height="60"></a>
          </div>
          <div id="base_info" class="fr">
            <div class="help_info">
              <a href="/Html/404.html" id="hp">&nbsp;</a>
              <a href="/Html/404.html" id="gy">&nbsp;</a>
              <a href="/Html/404.html" id="out">&nbsp;</a>
            </div>
            <div class="info_center">
               
              <span id="nt"></span><span><a href="#" id="notice">3</a></span>
            </div>
          </div>
        </div>
      </div>
      <div id="side_here">
        <div id="side_here_l" class="fl"></div>
        <div id="here_area" class="fl">当前位置：工夹具基础信息管理</div>
      </div>
    </div>
    <div class="side">
        <div class="sideMenu" style="margin:0 auto">
          <h3>工夹具信息</h3>
          <ul>
            <li>夹具代码</li>
            <li>所属工作部</li>
            <li>配备数量</li>
            <li >保养周期</li>
            <li>责任人</li>
          </ul>
          <h3> 采购入库</h3>
          <ul>
            <li></li>
            <li>用户提交</li>
            <li class="on">初次审核</li>
            <li>监管员审核</li>
            <li>WC终审</li>
          </ul>
          <h3> 进出库管理</h3>
          <ul>
            <li>员工申请</li>
            <li>仓管员录入</li>
            <li>出库</li>
            <li>返库</li>
            <li>终审</li>
          </ul>
          <h3>报修申请</h3>
          <ul>
            <li >初级用户提交</li>
            <li>高级用户审核</li>
            <li>终审</li>
            <li class="on">邮箱验证</li>
            
          </ul>
          <h3> 报废申请</h3>
          <ul>
            <li>高级用户提交</li>
            <li>监管员初审</li>
            <li>Workcell终审</li>
            
          </ul>
          <h3> 权限管理</h3>
          <ul>
            <li>添加用户</li>
            <li>修改信息</li>
            <li>权限修改</li>
          </ul>
 
 
 

       </div>
    </div>
    <div class="main">
       <iframe name="right" id="rightMain" src="/Html/ToolsBasicManage.html" frameborder="no" scrolling="auto" width="100%" height="auto" allowtransparency="true"></iframe>
    </div>
    <div class="bottom">
      <div id="bottom_bg">2020 @XuGuo 版权所有</div>
    </div>
    <div class="scroll">
          <a href="javascript:;" class="per" title="使用鼠标滚轴滚动侧栏" onclick="menuScroll(1);"></a>
          <a href="javascript:;" class="next" title="使用鼠标滚轴滚动侧栏" onclick="menuScroll(2);"></a>
    </div>
</body>

</html>

