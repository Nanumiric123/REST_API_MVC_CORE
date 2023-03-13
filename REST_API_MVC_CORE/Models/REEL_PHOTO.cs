using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API_MVC_CORE.Models
{
    public class REEL_PHOTO
    {
        string PHOTO {get;set;}
        string VENDOR { get; set; }
        string PART_NO { get; set; }
        string CARTON_REEL_NO { get; set; }
        decimal QUANTITY { get; set; }
        string BATCH_NO { get; set; }
        string UOM { get; set; }

    }
}
