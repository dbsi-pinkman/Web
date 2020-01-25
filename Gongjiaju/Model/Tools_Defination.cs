using System;
namespace Model
{
    /// <summary>
    /// [Tools_Defination]表实体类
    /// 作者:许郭
    /// 创建时间:2020-01-21 10:49:45
    /// </summary>
    [Serializable]
    public partial class Tools_Defination
    {
        public Tools_Defination()
        { }
        private int _ID ;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }
        private string _WorkceIIID ;
        /// <summary>
        /// 
        /// </summary>
        public string WorkceIIID
        {
            set { _WorkceIIID = value; }
            get { return _WorkceIIID; }
        }
        private string _WorkceII ;
        /// <summary>
        /// 
        /// </summary>
        public string WorkceII
        {
            set { _WorkceII = value; }
            get { return _WorkceII; }
        }
        private string _FamilyID ;
        /// <summary>
        /// 
        /// </summary>
        public string FamilyID
        {
            set { _FamilyID = value; }
            get { return _FamilyID; }
        }
        private string _Family ;
        /// <summary>
        /// 
        /// </summary>
        public string Family
        {
            set { _Family = value; }
            get { return _Family; }
        }
        private string _Code ;
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            set { _Code = value; }
            get { return _Code; }
        }
        private string _Name ;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }
        private string _Model ;
        /// <summary>
        /// 
        /// </summary>
        public string Model
        {
            set { _Model = value; }
            get { return _Model; }
        }
        private string _PartNo ;
        /// <summary>
        /// 
        /// </summary>
        public string PartNo
        {
            set { _PartNo = value; }
            get { return _PartNo; }
        }
        private string _UsedFor ;
        /// <summary>
        /// 
        /// </summary>
        public string UsedFor
        {
            set { _UsedFor = value; }
            get { return _UsedFor; }
        }
        private int? _UPL ;
        /// <summary>
        /// 
        /// </summary>
        public int? UPL
        {
            set { _UPL = value; }
            get { return _UPL; }
        }
        private string _Owner ;
        /// <summary>
        /// 
        /// </summary>
        public string Owner
        {
            set { _Owner = value; }
            get { return _Owner; }
        }
        private string _OwnerNamer ;
        /// <summary>
        /// 
        /// </summary>
        public string OwnerNamer
        {
            set { _OwnerNamer = value; }
            get { return _OwnerNamer; }
        }
        private string _Remark ;
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _Remark = value; }
            get { return _Remark; }
        }
        private string _PMperiord ;
        /// <summary>
        /// 
        /// </summary>
        public string PMperiord
        {
            set { _PMperiord = value; }
            get { return _PMperiord; }
        }
        private DateTime? _RecOn ;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RecOn
        {
            set { _RecOn = value; }
            get { return _RecOn; }
        }
        private string _RecBy ;
        /// <summary>
        /// 
        /// </summary>
        public string RecBy
        {
            set { _RecBy = value; }
            get { return _RecBy; }
        }
        private string _RecByName ;
        /// <summary>
        /// 
        /// </summary>
        public string RecByName
        {
            set { _RecByName = value; }
            get { return _RecByName; }
        }
        private DateTime? _EditOn ;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EditOn
        {
            set { _EditOn = value; }
            get { return _EditOn; }
        }
        private string _EditBy ;
        /// <summary>
        /// 
        /// </summary>
        public string EditBy
        {
            set { _EditBy = value; }
            get { return _EditBy; }
        }
        private string _EditByName ;
        /// <summary>
        /// 
        /// </summary>
        public string EditByName
        {
            set { _EditByName = value; }
            get { return _EditByName; }
        }
    }
}
