using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// ValidateReg 的摘要说明
    /// </summary>
    public class ValidateReg : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request["action"];
            if (action == "code")
            {
                string validatecode = context.Request["validatecode"];

                if (Common.WebCommon.CheckValidateCode(validatecode))
                {
                    HttpContext.Current.Session["vcode"] = validatecode;
                    context.Response.Write("验证码正确！");
                }
                else
                {
                    context.Response.Write("验证码错误！");
                }
            }
            else if (action == "name")
            {
                string name = context.Request["id"];
                Dal.UsersDAL usersDAL = new Dal.UsersDAL();
                if (usersDAL.GetModel(name) != null)
                {
                    context.Response.Write("账号可以使用");
                }
                else
                {
                    context.Response.Write("账号不存在！");
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}