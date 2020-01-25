using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.Toolsashx
{
    /// <summary>
    /// registerToolsInfo 的摘要说明
    /// </summary>
    public class registerToolsInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string code = context.Request["code"];
            Dal.Tools_DefinationDAL tools = new Dal.Tools_DefinationDAL();
            Model.Tools_Defination tools_Defination = tools.GetModel(code);
            tools_Defination.Name = context.Request["name"];
            tools_Defination.Code = context.Request["code"];
            tools_Defination.PartNo = context.Request["partno"];
            tools_Defination.Model = context.Request["model"];
            tools_Defination.Family = context.Request["family"];
            tools_Defination.EditOn = DateTime.Now;
            
            if (tools.Update(tools_Defination))
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