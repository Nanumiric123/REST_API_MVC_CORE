using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API_MVC_CORE_WITH_SQL.Models
{
    public class REEL_PHOTO
    {
        public int ID { get; set; }
        public string PHOTO { get; set; }
        public string VENDOR { get; set; }
        public string LABEL_DATE { get; set; }
        public string PART_NO { get; set; }
        public string CARTON_REEL_NO { get; set; }
        public string BATCH_NO { get; set; }
        public decimal QUANTITY { get; set; }
        public string UOM { get; set; }
    }

    public class INCOMING_DATA
    {
        public string Barcode { get; set; }
        public string Image { get; set; }
    }
    public class BARC_STOCK_DETAILS
    {
        public string MATERIAL { get; set; }
        public string WRONG_MATERIAL { get; set; }
        public decimal QUANTITY { get; set; }
    }
    public class ANDROID_SAP_SUBMIT
    {
        public BARC_STOCK_DETAILS[] labeldata { get; set; }
        public string MATERIAL { get; set; }
    }
    public class MPQT32
    {
        public string BINNO { get; set; }
        public string MATERIAL { get; set; }
        public string STORAGELOCATION { get; set; } 
        public string BADGENUM{ get; set; }
    }
}
