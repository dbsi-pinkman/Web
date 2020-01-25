using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [Users]表实体类
    /// 作者:许郭
    /// 创建时间:2020-01-21 10:35:04
    /// </summary>
    [Serializable]
    public partial class Users
    {
        public Users()
        { }
        private int _ID;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        private string _UserName;
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _UserName = value; }
            get { return _UserName; }
        }
        private string _UserPwd;
        /// <summary>
        /// 
        /// </summary>
        public string UserPwd
        {
            set { _UserPwd = value; }
            get { return _UserPwd; }
        }
        private string _Phone;
        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            set { _Phone = value; }
            get { return _Phone; }
        }
        private string _Mail;
        /// <summary>
        /// 
        /// </summary>
        public string Mail
        {
            set { _Mail = value; }
            get { return _Mail; }
        }
        private string _Permission;
        /// <summary>
        /// 
        /// </summary>
        public string Permission
        {
            set { _Permission = value; }
            get { return _Permission; }
        }

    }
}
