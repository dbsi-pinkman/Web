using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// DeleteUser 的摘要说明
    /// </summary>
    public class DeleteUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request.Form["id"]);
            Dal.UsersDAL usersDAL = new Dal.UsersDAL();
            if (usersDAL.Delete(id))
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