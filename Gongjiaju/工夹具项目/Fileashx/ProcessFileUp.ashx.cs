using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace 工夹具项目.Fileashx
{
    /// <summary>
    /// ProcessFileUp 的摘要说明
    /// </summary>
    public class ProcessFileUp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<string> list = new List<string>();
            //将常见图片的格式添加到数组中
            string[] img = { ".jpg", ".jpeg", ".bmp", ".png", ".tif", ".gif", ".pcx", ".tga", ".exif", ".fpx" };
            list.AddRange(img);

            context.Response.ContentType = "text/html";
            context.Response.Write(context.Request.Form["txtname"]);
            HttpPostedFile file = context.Request.Files[0];//获取上传的文件
            if (file.ContentLength > 0)
            {
                string name = Path.GetFileName(file.FileName);//获取上传文件的文件名+扩展名
                string filetxt = Path.GetExtension(name);//获取文件的扩展名
                //对上传的文件类型进行
                if (list.Contains(filetxt))
                {
                    //1.对上传的文件进行重命名，防止文件被覆盖
                    string newFileName = Guid.NewGuid().ToString();
                    //2.将文件保存在不同的文件夹中，避免用户上传文件过多，造成在一个文件夹中查找，操作困难的问题
                    //按日期建立文件夹
                    string src = "/ImageUpLoad/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/";
                    //创建文件夹

                    if (!Directory.Exists(context.Request.MapPath(src)))
                    {
                        Directory.CreateDirectory(context.Request.MapPath(src));
                    }

                    string fulldir = src + newFileName + filetxt;//文件存放的完整路径

                    file.SaveAs(context.Request.MapPath(fulldir));//完成文件的保存
                    context.Response.Write("保存成功！！");
                }
            }
            else
            {
                context.Response.Write("只能保存图片文件!");
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