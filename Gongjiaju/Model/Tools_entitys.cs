using System;
namespace Model
{
    /// <summary>
    /// [Tools_entitys]表实体类
    /// 作者:许郭
    /// 创建时间:2020-01-21 10:49:45
    /// </summary>
    [Serializable]
    public partial class Tools_entitys
    {
        public Tools_entitys()
        { }
        private string _Code ;
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            set { _Code = value; }
            get { return _Code; }
        }
        private string _SeqID ;
        /// <summary>
        /// 
        /// </summary>
        public string SeqID
        {
            set { _SeqID = value; }
            get { return _SeqID; }
        }
        private string _BillNo ;
        /// <summary>
        /// 
        /// </summary>
        public string BillNo
        {
            set { _BillNo = value; }
            get { return _BillNo; }
        }
        private DateTime? _RegDate ;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RegDate
        {
            set { _RegDate = value; }
            get { return _RegDate; }
        }
        private int? _UserCount ;
        /// <summary>
        /// 
        /// </summary>
        public int? UserCount
        {
            set { _UserCount = value; }
            get { return _UserCount; }
        }
        private string _Location ;
        /// <summary>
        /// 
        /// </summary>
        public string Location
        {
            set { _Location = value; }
            get { return _Location; }
        }
    }
}
