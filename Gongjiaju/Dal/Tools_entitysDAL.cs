using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Dal
{
    /// <summary>
    /// [Tools_entitys]表数据访问类
    /// 作者:许郭
    /// 创建时间:2020-01-21 10:49:45
    /// </summary>
    public class Tools_entitysDAL
    {
        public Tools_entitysDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Tools_entitys model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Tools_entitys](");
            strSql.Append("[Code], [SeqID], [BillNo], [RegDate], [UserCount], [Location] )");
            strSql.Append(" values (");
            strSql.Append("@Code, @SeqID, @BillNo, @RegDate, @UserCount, @Location )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.Code == null)
            {
                 h.AddParameter("@Code", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Code", model.Code);
            }
            if (model.SeqID == null)
            {
                 h.AddParameter("@SeqID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@SeqID", model.SeqID);
            }
            if (model.BillNo == null)
            {
                 h.AddParameter("@BillNo", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@BillNo", model.BillNo);
            }
            if (model.RegDate == null)
            {
                 h.AddParameter("@RegDate", DateTime.Now);
            }
            else
            {
                 h.AddParameter("@RegDate", model.RegDate);
            }
            if (model.UserCount == null)
            {
                 h.AddParameter("@UserCount", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UserCount", model.UserCount);
            }
            if (model.Location == null)
            {
                 h.AddParameter("@Location", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Location", model.Location);
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
        public bool Update(Model.Tools_entitys model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Tools_entitys] set ");
            strSql.Append("[Code]=@Code, [SeqID]=@SeqID, [BillNo]=@BillNo, [RegDate]=@RegDate, [UserCount]=@UserCount, [Location]=@Location   ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.Code == null)
            {
                 h.AddParameter("@Code", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Code", model.Code);
            }
            if (model.SeqID == null)
            {
                 h.AddParameter("@SeqID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@SeqID", model.SeqID);
            }
            if (model.BillNo == null)
            {
                 h.AddParameter("@BillNo", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@BillNo", model.BillNo);
            }
            if (model.RegDate == null)
            {
                 h.AddParameter("@RegDate", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@RegDate", model.RegDate);
            }
            if (model.UserCount == null)
            {
                 h.AddParameter("@UserCount", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UserCount", model.UserCount);
            }
            if (model.Location == null)
            {
                 h.AddParameter("@Location", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Location", model.Location);
            }
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Tools_entitys] ");
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
            strSql.Append("delete from [Tools_entitys] ");
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
            string sql = "select " + filed + " from [Tools_entitys]";
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
        public Model.Tools_entitys GetModel(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Tools_entitys] ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", keyId);
            Model.Tools_entitys model = null;
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
        public Model.Tools_entitys GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [Tools_entitys] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            Model.Tools_entitys model = null;
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
            strSql.Append(" FROM [Tools_entitys] ");
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
            h.AddParameter("@tblName", "[Tools_entitys]");
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
        public List<Model.Tools_entitys> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Tools_entitys] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<Model.Tools_entitys> list = new List<Model.Tools_entitys>();
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
        public List<Model.Tools_entitys> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Tools_entitys]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            List<Model.Tools_entitys> list = new List<Model.Tools_entitys>();
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
        public Model.Tools_entitys ReaderBind(IDataReader dataReader)
        {
            Model.Tools_entitys model = new Model.Tools_entitys();
            object ojb;
                model.Code = dataReader["Code"].ToString();
                model.SeqID = dataReader["SeqID"].ToString();
                model.BillNo = dataReader["BillNo"].ToString();
            ojb = dataReader["RegDate"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.RegDate = DateTime.Parse(ojb.ToString());
            }
            ojb = dataReader["UserCount"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.UserCount = int.Parse(ojb.ToString());
            }
                model.Location = dataReader["Location"].ToString();
            return model;
        }

        /// <summary>
        /// 计算记录数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [Tools_entitys]";
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
