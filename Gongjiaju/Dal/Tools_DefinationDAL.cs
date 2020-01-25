using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Dal

{
    /// <summary>
    /// [Tools_Defination]表数据访问类
    /// 作者:许郭
    /// 创建时间:2020-01-21 10:49:45
    /// </summary>
    public class Tools_DefinationDAL
    {
        public Tools_DefinationDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Tools_Defination model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Tools_Defination](");
            strSql.Append("[WorkceIIID], [WorkceII], [FamilyID], [Family], [Code], [Name], [Model], [PartNo], [UsedFor], [UPL], [Owner], [OwnerNamer], [Remark], [PMperiord], [RecOn], [RecBy], [RecByName], [EditOn], [EditBy], [EditByName] )");
            strSql.Append(" values (");
            strSql.Append("@WorkceIIID, @WorkceII, @FamilyID, @Family, @Code, @Name, @Model, @PartNo, @UsedFor, @UPL, @Owner, @OwnerNamer, @Remark, @PMperiord, @RecOn, @RecBy, @RecByName, @EditOn, @EditBy, @EditByName )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.WorkceIIID == null)
            {
                 h.AddParameter("@WorkceIIID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@WorkceIIID", model.WorkceIIID);
            }
            if (model.WorkceII == null)
            {
                 h.AddParameter("@WorkceII", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@WorkceII", model.WorkceII);
            }
            if (model.FamilyID == null)
            {
                 h.AddParameter("@FamilyID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@FamilyID", model.FamilyID);
            }
            if (model.Family == null)
            {
                 h.AddParameter("@Family", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Family", model.Family);
            }
            if (model.Code == null)
            {
                 h.AddParameter("@Code", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Code", model.Code);
            }
            if (model.Name == null)
            {
                 h.AddParameter("@Name", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Name", model.Name);
            }
            if (model.Model == null)
            {
                 h.AddParameter("@Model", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Model", model.Model);
            }
            if (model.PartNo == null)
            {
                 h.AddParameter("@PartNo", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@PartNo", model.PartNo);
            }
            if (model.UsedFor == null)
            {
                 h.AddParameter("@UsedFor", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UsedFor", model.UsedFor);
            }
            if (model.UPL == null)
            {
                 h.AddParameter("@UPL", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UPL", model.UPL);
            }
            if (model.Owner == null)
            {
                 h.AddParameter("@Owner", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Owner", model.Owner);
            }
            if (model.OwnerNamer == null)
            {
                 h.AddParameter("@OwnerNamer", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@OwnerNamer", model.OwnerNamer);
            }
            if (model.Remark == null)
            {
                 h.AddParameter("@Remark", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Remark", model.Remark);
            }
            if (model.PMperiord == null)
            {
                 h.AddParameter("@PMperiord", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@PMperiord", model.PMperiord);
            }
            if (model.RecOn == null)
            {
                 h.AddParameter("@RecOn", DateTime.Now);
            }
            else
            {
                 h.AddParameter("@RecOn", model.RecOn);
            }
            if (model.RecBy == null)
            {
                 h.AddParameter("@RecBy", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@RecBy", model.RecBy);
            }
            if (model.RecByName == null)
            {
                 h.AddParameter("@RecByName", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@RecByName", model.RecByName);
            }
            if (model.EditOn == null)
            {
                 h.AddParameter("@EditOn", DateTime.Now);
            }
            else
            {
                 h.AddParameter("@EditOn", model.EditOn);
            }
            if (model.EditBy == null)
            {
                 h.AddParameter("@EditBy", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@EditBy", model.EditBy);
            }
            if (model.EditByName == null)
            {
                 h.AddParameter("@EditByName", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@EditByName", model.EditByName);
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
        public bool Update(Model.Tools_Defination model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Tools_Defination] set ");
            strSql.Append("[WorkceIIID]=@WorkceIIID, [WorkceII]=@WorkceII, [FamilyID]=@FamilyID, [Family]=@Family, [Code]=@Code, [Name]=@Name, [Model]=@Model, [PartNo]=@PartNo, [UsedFor]=@UsedFor, [UPL]=@UPL, [Owner]=@Owner, [OwnerNamer]=@OwnerNamer, [Remark]=@Remark, [PMperiord]=@PMperiord, [RecOn]=@RecOn, [RecBy]=@RecBy, [RecByName]=@RecByName, [EditOn]=@EditOn, [EditBy]=@EditBy, [EditByName]=@EditByName   ");
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
            if (model.WorkceIIID == null)
            {
                 h.AddParameter("@WorkceIIID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@WorkceIIID", model.WorkceIIID);
            }
            if (model.WorkceII == null)
            {
                 h.AddParameter("@WorkceII", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@WorkceII", model.WorkceII);
            }
            if (model.FamilyID == null)
            {
                 h.AddParameter("@FamilyID", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@FamilyID", model.FamilyID);
            }
            if (model.Family == null)
            {
                 h.AddParameter("@Family", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Family", model.Family);
            }
            if (model.Code == null)
            {
                 h.AddParameter("@Code", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Code", model.Code);
            }
            if (model.Name == null)
            {
                 h.AddParameter("@Name", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Name", model.Name);
            }
            if (model.Model == null)
            {
                 h.AddParameter("@Model", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Model", model.Model);
            }
            if (model.PartNo == null)
            {
                 h.AddParameter("@PartNo", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@PartNo", model.PartNo);
            }
            if (model.UsedFor == null)
            {
                 h.AddParameter("@UsedFor", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UsedFor", model.UsedFor);
            }
            if (model.UPL == null)
            {
                 h.AddParameter("@UPL", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@UPL", model.UPL);
            }
            if (model.Owner == null)
            {
                 h.AddParameter("@Owner", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Owner", model.Owner);
            }
            if (model.OwnerNamer == null)
            {
                 h.AddParameter("@OwnerNamer", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@OwnerNamer", model.OwnerNamer);
            }
            if (model.Remark == null)
            {
                 h.AddParameter("@Remark", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Remark", model.Remark);
            }
            if (model.PMperiord == null)
            {
                 h.AddParameter("@PMperiord", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@PMperiord", model.PMperiord);
            }
            if (model.RecOn == null)
            {
                 h.AddParameter("@RecOn", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@RecOn", model.RecOn);
            }
            if (model.RecBy == null)
            {
                 h.AddParameter("@RecBy", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@RecBy", model.RecBy);
            }
            if (model.RecByName == null)
            {
                 h.AddParameter("@RecByName", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@RecByName", model.RecByName);
            }
            if (model.EditOn == null)
            {
                 h.AddParameter("@EditOn", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@EditOn", model.EditOn);
            }
            if (model.EditBy == null)
            {
                 h.AddParameter("@EditBy", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@EditBy", model.EditBy);
            }
            if (model.EditByName == null)
            {
                 h.AddParameter("@EditByName", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@EditByName", model.EditByName);
            }
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Tools_Defination] ");
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
            strSql.Append("delete from [Tools_Defination] ");
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
            string sql = "select " + filed + " from [Tools_Defination]";
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
        public Model.Tools_Defination GetModel(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Tools_Defination] ");
            strSql.Append(" where ID=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", keyId);
            Model.Tools_Defination model = null;
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
        public Model.Tools_Defination GetModel(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Tools_Defination] ");
            strSql.Append(" where Code=@ID ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@ID", code);
            Model.Tools_Defination model = null;
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
        public Model.Tools_Defination GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [Tools_Defination] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            Model.Tools_Defination model = null;
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
            strSql.Append(" FROM [Tools_Defination] ");
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
            h.AddParameter("@tblName", "[Tools_Defination]");
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
        public List<Model.Tools_Defination> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Tools_Defination] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<Model.Tools_Defination> list = new List<Model.Tools_Defination>();
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
        public List<Model.Tools_Defination> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Tools_Defination]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            List<Model.Tools_Defination> list = new List<Model.Tools_Defination>();
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
        public Model.Tools_Defination ReaderBind(IDataReader dataReader)
        {
            Model.Tools_Defination model = new Model.Tools_Defination();
            object ojb;
            ojb = dataReader["ID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.ID = int.Parse(ojb.ToString());
            }
                model.WorkceIIID = dataReader["WorkceIIID"].ToString();
                model.WorkceII = dataReader["WorkceII"].ToString();
                model.FamilyID = dataReader["FamilyID"].ToString();
                model.Family = dataReader["Family"].ToString();
                model.Code = dataReader["Code"].ToString();
                model.Name = dataReader["Name"].ToString();
                model.Model = dataReader["Model"].ToString();
                model.PartNo = dataReader["PartNo"].ToString();
                model.UsedFor = dataReader["UsedFor"].ToString();
            ojb = dataReader["UPL"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.UPL = int.Parse(ojb.ToString());
            }
                model.Owner = dataReader["Owner"].ToString();
                model.OwnerNamer = dataReader["OwnerNamer"].ToString();
                model.Remark = dataReader["Remark"].ToString();
                model.PMperiord = dataReader["PMperiord"].ToString();
            ojb = dataReader["RecOn"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.RecOn = DateTime.Parse(ojb.ToString());
            }
                model.RecBy = dataReader["RecBy"].ToString();
                model.RecByName = dataReader["RecByName"].ToString();
            ojb = dataReader["EditOn"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.EditOn = DateTime.Parse(ojb.ToString());
            }
                model.EditBy = dataReader["EditBy"].ToString();
                model.EditByName = dataReader["EditByName"].ToString();
            return model;
        }

        /// <summary>
        /// 计算记录数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [Tools_Defination]";
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
