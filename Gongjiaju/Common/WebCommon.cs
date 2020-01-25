using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class WebCommon
    {
        /// <summary>
        /// 对字符串进行MD5运算
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMd5String(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] md5buffer = md5.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            foreach(byte b in md5buffer)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        /// <summary>
        /// 完成验证码的检验
        /// </summary>
        /// <returns></returns>
        public static bool CheckValidateCode(string validatecode)
        {
            bool isSuccess = false;
            if (HttpContext.Current.Session["vcode"] != null)
            {
                //string txtcode = HttpContext.Current.Request["txtvalidate"];//用户输入的验证码
                string syscode = HttpContext.Current.Session["vcode"].ToString();//Session中存的值
                if (validatecode.Equals(syscode, StringComparison.InvariantCultureIgnoreCase))
                {
                    isSuccess = true;
                    HttpContext.Current.Session["vcode"] = null;
                }
            }
            return isSuccess;
        }
        /// <summary>
        /// 跳转页面
        /// </summary>
        public static void RedirectPage()
        {
            HttpContext.Current.Response.Redirect("/Member/LoginPage.aspx?returnurl="+HttpContext.Current.Request.Url.ToString());
        }
    }
}
