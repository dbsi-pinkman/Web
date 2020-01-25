using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 工夹具项目.Member
{
    
    public partial class Login : System.Web.UI.Page
    {
        public string Name { get; set; }
        public string Returnurl = string.Empty;
        Dal.UsersDAL UsersDAL = new Dal.UsersDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack)//判断是否是post请求
            {
                //接收用户输入的用户名，存入cookie中 并设置7天的过期时间
                string name = Context.Request["username"];
                Response.Cookies["name"].Value = HttpUtility.UrlEncode(name);
                Response.Cookies["name"].Expires = DateTime.Now.AddDays(7);
                //接受用户输入的验证码
                string validateCode = Context.Request["txtValidate"];
                if(Common.WebCommon.CheckValidateCode(validateCode))
                {
                    checkPwd();//验证码正确就判断密码是否正确
                }
                else
                {
                    Context.Response.Write("验证码错误！！！！");
                }
            }
            else
            {
                if(Request.Cookies["name"]!=null)//判断get请求中cookie是否有值
                {
                    //实现记住用户名
                    Name = HttpUtility.UrlDecode(Request.Cookies["name"].Value, Encoding.GetEncoding("UTF-8"));
                }

                ////如果能接受到传递过来的参数（存储的是用户接下来要访问的URL地址），把数据存到隐藏域中
                //Returnurl = Request["returnurl"];
                ////校验cookie中是有值
                //CheckCookieInfo();
            }
        }
        ///// <summary>
        ///// 校验cookie中是否有值
        ///// </summary>
        //private void CheckCookieInfo()
        //{
        //    if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
        //    {
        //        string username = Request.Cookies["cp1"].Value;
        //        string pwd = Request.Cookies["cp2"].Value;
        //        Model.Users users = UsersDAL.GetModel(username); /*usersDal.GetModel(username);*/
        //        if (users != null)
        //        {
        //            if (pwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(users.Loginpwd)))
        //            {
        //                Session["userinfor"] = users;
        //                if (string.IsNullOrWhiteSpace(Request["hiddenUrl"]))
        //                {
        //                    Context.Response.Redirect("/工夹具/index.html");
        //                }
        //                else
        //                {
        //                    Context.Response.Redirect(Request["hiddenUrl"]);
        //                }
        //            }
        //        }
        //        Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
        //        Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
        //    }
        //}
        private void checkPwd()
        {
            //接受用户输入的信息
            string userName = Context.Request["username"];
            string userPwd = Context.Request["pwd"];
            Dal.UsersDAL usersDAL = new Dal.UsersDAL();
            Model.Users users= usersDAL.GetModel(userName);
            if(users!=null)
            {
                if(users.UserPwd.Trim()==userPwd.Trim())
                {
                    Session["UserInfo"] = users;
                    if(users.Permission.Trim()=="1")
                    {
                        Context.Response.Redirect("/UI/p1.aspx");
                    }
                    else if(users.Permission.Trim()=="2")
                    {
                        Context.Response.Redirect("/UI/p2.aspx");
                    }
                    else if (users.Permission.Trim() == "3")
                    {
                        Context.Response.Redirect("/UI/p3.aspx");
                    }
                    else if (users.Permission.Trim() == "4")
                    {
                        Context.Response.Redirect("/UI/p4.aspx");
                    }
                }
                else
                {
                    Context.Response.Write("密码错误，请检查！！！");
                }
            }
            else
            {
                Context.Response.Write("该用户不存在！！！");
            }
        }
    }
}