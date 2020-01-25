using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.Toolsashx
{
    /// <summary>
    /// ToolsList 的摘要说明
    /// </summary>
    public class ToolsList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
            Dal.Tools_DefinationDAL tools_DefinationDAL = new Dal.Tools_DefinationDAL();
            List<Model.Tools_Defination> tools_Definations = tools_DefinationDAL.GetListArray("ID>0");
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string str = js.Serialize(tools_Definations);
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