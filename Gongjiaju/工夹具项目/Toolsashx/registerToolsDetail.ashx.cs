using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.Toolsashx
{
    /// <summary>
    /// registerToolsDetail 的摘要说明
    /// </summary>
    public class registerToolsDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            Dal.Tools_DefinationDAL tools = new Dal.Tools_DefinationDAL();
            Model.Tools_Defination tools_Defination = tools.GetModel(id);
            tools_Defination.Name = context.Request["name"];
            tools_Defination.UsedFor = context.Request["usedfor"];
            tools_Defination.WorkceII = context.Request["workcell"];
            tools_Defination.PMperiord= context.Request["periord"];
            tools_Defination.RecBy = context.Request["recon"];
            tools_Defination.EditBy = context.Request["editby"];
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