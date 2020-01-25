using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// ValidateCode 的摘要说明
    /// </summary>
    public class ValidateCode : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Common.ValidateCode code = new Common.ValidateCode();
            string yzm = code.CreateValidateCode(4);
            context.Session.Add("vcode", yzm);
            code.CreateValidateGraphic(yzm);
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