using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// registerUserInfo 的摘要说明
    /// </summary>
    public class registerUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name= context.Request["name"];
            Dal.UsersDAL usersDAL = new Dal.UsersDAL();
            Model.Users users = usersDAL.GetModel(name);
            users.UserName = context.Request["name"];
            users.UserPwd = context.Request["pwd"];
            users.Phone = context.Request["phone"];
            users.Mail = context.Request["email"];
            users.Permission = context.Request["permission"];
            
            if (usersDAL.Update(users))
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