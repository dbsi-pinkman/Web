using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    /// <summary>
    /// [Settings]表数据访问类
    /// 作者:许郭
    /// 创建时间:2020-01-21 17:46:20
    /// </summary>
    public class SettingsDAL
    {
        public SettingsDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Settings model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Settings](");
            strSql.Append("[Id], [Name], [Value] )");
            strSql.Append(" values (");
            strSql.Append("@Id, @Name, @Value )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.Id == null)
            {
                h.AddParameter("@Id", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Id", model.Id);
            }
            if (model.Name == null)
            {
                h.AddParameter("@Name", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Name", model.Name);
            }
            if (model.Value == null)
            {
                h.AddParameter("@Value", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Value", model.Value);
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
        public bool Update(Model.Settings model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Settings] set ");
            strSql.Append("[Id]=@Id, [Name]=@Name, [Value]=@Value   ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.Id == null)
            {
                h.AddParameter("@Id", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Id", model.Id);
            }
            if (model.Name == null)
            {
                h.AddParameter("@Name", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Name", model.Name);
            }
            if (model.Value == null)
            {
                h.AddParameter("@Value", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Value", model.Value);
            }
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Settings] ");
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
            strSql.Append("delete from [Settings] ");
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
            string sql = "select " + filed + " from [Settings]";
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
        public Model.Settings GetModel(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Settings] ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", keyId);
            Model.Settings model = null;
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
        /// 得到一个对象实体
        /// </summary>
        public Model.Settings GetModel(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Settings] ");
            strSql.Append(" where Name=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", name);
            Model.Settings model = null;
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
        public Model.Settings GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [Settings] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            Model.Settings model = null;
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
            strSql.Append(" FROM [Settings] ");
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
            h.AddParameter("@tblName", "[Settings]");
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
        public List<Model.Settings> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Settings] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<Model.Settings> list = new List<Model.Settings>();
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
        public List<Model.Settings> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Settings]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            List<Model.Settings> list = new List<Model.Settings>();
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
        public Model.Settings ReaderBind(IDataReader dataReader)
        {
            Model.Settings model = new Model.Settings();
            object ojb;
            ojb = dataReader["Id"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Id = int.Parse(ojb.ToString());
            }
            model.Name = dataReader["Name"].ToString();
            model.Value = dataReader["Value"].ToString();
            return model;
        }

        /// <summary>
        /// 计算记录数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [Settings]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return int.Parse(h.ExecuteScalar());
        }
        /// <summary>
        /// 根据数据项的名称，获取具体配置的值
        /// </summary>
        /// <param name="key">配置项的名称</param>
        /// <returns></returns>
        public string GetValue(string key)
        {
            //判断缓存中有无数据
            if (Common.CacheHelper.Get("setting_" + key) == null)
            {
                Dal.SettingsDAL settingsDAL = new SettingsDAL();
                string value = settingsDAL.GetModel(key).Value;
                Common.CacheHelper.Set("setting_" + key, value);
                return value;
            }
            else
            {
                return Common.CacheHelper.Get("setting_" + key).ToString();
            }
        }
    }
    
}
