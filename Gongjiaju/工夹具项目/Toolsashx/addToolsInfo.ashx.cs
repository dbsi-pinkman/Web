using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.Toolsashx
{
    /// <summary>
    /// addToolsInfo 的摘要说明
    /// </summary>
    public class addToolsInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
            Model.Tools_Defination tools_Defination = new Model.Tools_Defination();
            tools_Defination.Name = context.Request["name"];
            tools_Defination.Code = context.Request["code"];
            tools_Defination.RecBy = context.Request["recby"];
            tools_Defination.RecOn = DateTime.Now;
            tools_Defination.PartNo = context.Request["partno"];
            tools_Defination.Model = context.Request["model"];
            tools_Defination.Family = context.Request["family"];
            tools_Defination.RecOn = DateTime.Now;
            Dal.Tools_DefinationDAL tools = new Dal.Tools_DefinationDAL();
            if (tools.Add(tools_Defination) > 0)
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