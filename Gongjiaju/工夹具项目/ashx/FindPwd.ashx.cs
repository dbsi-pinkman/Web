
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace 工夹具项目.ashx
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name = context.Request["txtName"];
            string mail = context.Request["txtMail"];
            Dal.UsersDAL usersDAL = new Dal.UsersDAL();
            Model.Users users = usersDAL.GetModel(name);
            if (users != null)
            {
                if (users.Mail == mail)
                {
                    Dal.SettingsDAL settingsDAL = new Dal.SettingsDAL();
                    //系统随机产生一个新密码，同时更新数据库，将新的秘密发到用户的邮箱中
                    string newPwd = Guid.NewGuid().ToString().Substring(0, 8);//产生新的密码
                    users.UserPwd = newPwd;
                    usersDAL.Update(users);//更新数据库（一定要将产生的密码加密后存入数据库，但是发送给用户邮箱的一定要是明文）

                    MailMessage mailMessage = new MailMessage();
                    //源邮件地址
                    mailMessage.From = new MailAddress(settingsDAL.GetValue("系统邮件地址"));
                    //目的邮件地址，可以有多个收件人
                    mailMessage.To.Add(new MailAddress(users.Mail));
                    mailMessage.Subject = "工夹具智能管理系统账号更新";//发送邮件的标题

                    StringBuilder sb = new StringBuilder();
                    sb.Append("用户名是" + users.UserName+ "的用户 ");
                    sb.Append("您的新密码是：" + newPwd);

                    mailMessage.Body = sb.ToString();//发送邮件的内容
                    SmtpClient client = new SmtpClient(settingsDAL.GetValue("系统邮件SMTP"));
                    client.Credentials = new NetworkCredential(settingsDAL.GetValue("系统邮件用户名"), settingsDAL.GetValue("系统邮件密码"));

                    try
                    {
                        client.Send(mailMessage);//发送大量邮件时会阻塞，可以将要发送的邮箱放入队列中
                        context.Response.Write("邮件发送成功！");
                    }
                    catch
                    {

                    }
                }
                else
                {
                    context.Response.Write("邮箱错误！");
                }
            }
            else
            {
                context.Response.Write("未查询到此用户！");
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