using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [Settings]表实体类
    /// 作者:许郭
    /// 创建时间:2020-01-21 17:47:59
    /// </summary>
    [Serializable]
    public partial class Settings
    {
        public Settings()
        { }
        private int _Id;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }
        private string _Name;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        private string _Value;
        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            set { _Value = value; }
            get { return _Value; }
        }
    }

}
