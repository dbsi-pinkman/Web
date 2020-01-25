using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// addUserInfo 的摘要说明
    /// </summary>
    public class addUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Model.Users users = new Model.Users();
            users.UserName = context.Request["name"];
            users.UserPwd = context.Request["pwd"];
            users.Phone = context.Request["phone"];
            users.Mail = context.Request["email"];
            users.Permission = context.Request["permission"];
            Dal.UsersDAL usersDAL = new Dal.UsersDAL();
            if (usersDAL.Add(users)>0)
            {
                context.Response.Write("ok");
            }
            else
            {
                context.Response.Write("no");
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