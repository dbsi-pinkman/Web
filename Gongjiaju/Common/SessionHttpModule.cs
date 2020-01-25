using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class SessionHttpModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.AcquireRequestState += Context_AcquireRequestState;
        }

        private void Context_AcquireRequestState(object sender, EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            HttpContext context= application.Context;//请求报文都在context中存储
            string url= context.Request.Url.ToString();//获取用户请求的URL地址
            if(url.Contains("UI"))//网页在admin文件夹下就要执行session校验
            {
                if(context.Session["UserInfo"]==null)
                {
                    context.Response.Redirect("/Member/Login.aspx");//跳转到登录页面
                }
            }
        }
    }
}
