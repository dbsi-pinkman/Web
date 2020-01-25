using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.Toolsashx
{
    /// <summary>
    /// ShowToolsDetail 的摘要说明
    /// </summary>
    public class ShowToolsDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request.Form["id"]);
            
            Dal.Tools_DefinationDAL tools_DefinationDAL = new Dal.Tools_DefinationDAL();
            Model.Tools_Defination tools_Defination = tools_DefinationDAL.GetModel(id);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string str = js.Serialize(tools_Defination);
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