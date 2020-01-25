using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Dal;

namespace Dal
{
    /// <summary>
    /// [Users]表数据访问类
    /// 作者:许郭
    /// 创建时间:2020-01-21 10:42:04
    /// </summary>
    public class UsersDAL
    {
        public UsersDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Users](");
            strSql.Append("[UserName], [UserPwd], [Phone], [Mail], [Permission] )");
            strSql.Append(" values (");
            strSql.Append("@UserName, @UserPwd, @Phone, @Mail, @Permission )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.UserName == null)
            {
                 h.AddParameter("@UserName", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UserName", model.UserName);
            }
            if (model.UserPwd == null)
            {
                 h.AddParameter("@UserPwd", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UserPwd", model.UserPwd);
            }
            if (model.Phone == null)
            {
                 h.AddParameter("@Phone", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Phone", model.Phone);
            }
            if (model.Mail == null)
            {
                 h.AddParameter("@Mail", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Mail", model.Mail);
            }
            if (model.Permission == null)
            {
                 h.AddParameter("@Permission", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Permission", model.Permission);
            }
            int result;
            string obj = h.ExecuteScalar();
            if (!int.TryParse(obj, out result))
            {
                return 0;
            }
            return result;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Users] set ");
            strSql.Append("[UserName]=@UserName, [UserPwd]=@UserPwd, [Phone]=@Phone, [Mail]=@Mail, [Permission]=@Permission   ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.ID.ToString() == null)
            {
                 h.AddParameter("@ID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@ID", model.ID);
            }
            if (model.UserName == null)
            {
                 h.AddParameter("@UserName", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UserName", model.UserName);
            }
            if (model.UserPwd == null)
            {
                 h.AddParameter("@UserPwd", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UserPwd", model.UserPwd);
            }
            if (model.Phone == null)
            {
                 h.AddParameter("@Phone", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Phone", model.Phone);
            }
            if (model.Mail == null)
            {
                 h.AddParameter("@Mail", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Mail", model.Mail);
            }
            if (model.Permission == null)
            {
                 h.AddParameter("@Permission", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Permission", model.Permission);
            }
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Users] ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", keyId);
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        public bool DeleteByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Users] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            return h.ExecuteNonQuery();
        }
		
        /// <summary>
        /// 取一个字段的值
        /// </summary>
        /// <param name="filed">字段，如sum(je)</param>
        /// <param name="cond">条件，如userid=2</param>
        /// <returns></returns>
        public string GetOneFiled(string filed, string cond)
        {
            string sql = "select " + filed + " from [Users]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return h.ExecuteScalar();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Users GetModel(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Users] ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", keyId);
            Model.Users model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }
        /// <summary>
        /// 根据用户名得到一个实体
        /// </summary>
        /// <param name="keyId"></param>
        /// <returns></returns>
        public Model.Users GetModel(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Users] ");
            strSql.Append(" where UserName=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", UserName);
            Model.Users model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }
        /// <summary>
        /// 根据用户名得到一个实体
        /// </summary>
        /// <param name="keyId"></param>
        /// <returns></returns>
        public Model.Users GetModel(string mail,int a)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Users] ");
            strSql.Append(" where Mail=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", mail);
            Model.Users model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }
        /// <summary>
        /// 根据条件得到一个对象实体
        /// </summary>
        public Model.Users GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [Users] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            Model.Users model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Users] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            DataTable dt = h.ExecuteQuery();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Users]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            DataTable dt = h.ExecuteQuery();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>
        /// 获得数据列表（比DataSet效率高，推荐使用）
        /// </summary>
        public List<Model.Users> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Users] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<Model.Users> list = new List<Model.Users>();
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            using (IDataReader dataReader = h.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
                h.CloseConn();
            }
            return list;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<Model.Users> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Users]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            List<Model.Users> list = new List<Model.Users>();
            using (IDataReader dataReader = h.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
                h.CloseConn();
            }
            return list;
        }

        /// <summary>
        /// 对象实体绑定数据
        /// </summary>
        public Model.Users ReaderBind(IDataReader dataReader)
        {
            Model.Users model = new Model.Users();
            object ojb;
            ojb = dataReader["ID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.ID = int.Parse(ojb.ToString());
            }
                model.UserName = dataReader["UserName"].ToString();
                model.UserPwd = dataReader["UserPwd"].ToString();
                model.Phone = dataReader["Phone"].ToString();
                model.Mail = dataReader["Mail"].ToString();
                model.Permission = dataReader["Permission"].ToString();
            return model;
        }

        /// <summary>
        /// 计算记录数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [Users]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return int.Parse(h.ExecuteScalar());
        }
    }
}
