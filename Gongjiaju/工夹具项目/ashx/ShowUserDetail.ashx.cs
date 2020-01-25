using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// ShowUserDetail 的摘要说明
    /// </summary>
    public class ShowUserDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request.Form["id"]);
            Dal.UsersDAL usersDAL = new Dal.UsersDAL();
            Users userInfo = usersDAL.GetModel(id);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string str = js.Serialize(userInfo);
            context.Response.Write(str);
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