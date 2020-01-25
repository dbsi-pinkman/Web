using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.Toolsashx
{
    /// <summary>
    /// DeleteTools 的摘要说明
    /// </summary>
    public class DeleteTools : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id =int.Parse(context.Request.Form["id"]);
            Dal.Tools_DefinationDAL tools_DefinationDAL = new Dal.Tools_DefinationDAL();
            //Model.Tools_Defination tools_Defination = tools_DefinationDAL.GetModel(id);
            if(tools_DefinationDAL.Delete(id))
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