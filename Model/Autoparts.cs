using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 零件
    /// </summary>
    [DataContract]
    public class Autoparts
    {
        /// <summary>
        /// 零件编号
        /// </summary>
        [DataMember]
        public string AUTO_PARTSID
        {
            get; set;
        }

        /// <summary>
        /// 配件来源编号
        /// </summary>
        [DataMember]
        public Auto_partssource AUTO_PARTSSOURCE
        {
            get; set;
        }

        /// <summary>
        /// 用途分类编码
        /// </summary>
        [DataMember]
        public Parts_usetype PARTS_USETYPE
        {
            get; set;
        }

        /// <summary>
        /// TPYEID类型编号
        /// </summary>
        [DataMember]
        public Partstype PARTSTYPE
        {
            get; set;
        }

        /// <summary>
        /// 零件名
        /// </summary>
        [DataMember]
        public string AUTO_PARTSNAME
        {
            get; set;
        }

        /// <summary>
        /// 产地
        /// </summary>
        [DataMember]
        public string PRODUCEPLACE
        {
            get; set;
        }

        /// <summary>
        /// 材料单位
        /// </summary>
        [DataMember]
        public string UNIT
        {
            get; set;
        }

        /// <summary>
        /// 含税价
        /// </summary>
        [DataMember]
        public double TAXPRICE
        {
            get; set;
        }

        /// <summary>
        /// 税率
        /// </summary>
        [DataMember]
        public double TAXRATE
        {
            get; set;
        }

        /// <summary>
        /// 自编码
        /// </summary>
        [DataMember]
        public string USERCODE
        {
            get; set;
        }

        /// <summary>
        /// 条形码
        /// </summary>
        [DataMember]
        public string BARCODE
        {
            get; set;
        }

        /// <summary>
        /// 每车用量
        /// </summary>
        [DataMember]
        public double PER_QUANTITY
        {
            get; set;
        }

        /// <summary>
        /// 容积
        /// </summary>
        [DataMember]
        public double VOLUME
        {
            get; set;
        }

        /// <summary>
        /// 净重
        /// </summary>
        [DataMember]
        public double WEIGHT
        {
            get; set;
        }

        /// <summary>
        /// 统一售价
        /// </summary>
        [DataMember]
        public double UNIFORMPRICE
        {
            get; set;
        }

        /// <summary>
        /// 英文名
        /// </summary>
        [DataMember]
        public string ENGLISHNAME
        {
            get; set;
        }

        /// <summary>
        /// 零件说明
        /// </summary>
        [DataMember]
        public string PARTDESCRIPTION
        {
            get; set;
        }

        /// <summary>
        /// 零件备注
        /// </summary>
        [DataMember]
        public string AUTO_PARTSMEMO
        {
            get; set;
        }

        /// <summary>
        /// 厂家零件号
        /// </summary>
        [DataMember]
        public string PARTNUMBER
        {
            get; set;
        }

        /// <summary>
        /// 生产厂家
        /// </summary>
        [DataMember]
        public string MANUFACTURER
        {
            get; set;
        }

        /// <summary>
        /// 是否退货
        /// </summary>
        [DataMember]
        public int ISRETURN
        {
            get; set;
        }

        /// <summary>
        /// 是否存在有效期
        /// </summary>
        [DataMember]
        public int ISVALIDITYPERIOD
        {
            get; set;
        }

        /// <summary>
        /// 是否入库分批次
        /// </summary>
        [DataMember]
        public int ISBATCH
        {
            get; set;
        }
    }
}
