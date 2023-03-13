using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using REST_API_MVC_CORE_WITH_SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace REST_API_MVC_CORE_WITH_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SAPSUBMITController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SAPSUBMITController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult Post([FromBody] ANDROID_SAP_SUBMIT data)
        {
            decimal qty = 0;
            BARC_STOCK_DETAILS row_data = new BARC_STOCK_DETAILS();
            row_data.MATERIAL = data.MATERIAL;
            row_data.WRONG_MATERIAL = "";

            foreach (BARC_STOCK_DETAILS k in data.labeldata)
            {
                if (row_data.MATERIAL == k.MATERIAL)
                {
                    decimal qty_s = k.QUANTITY;
                    qty = qty_s + qty;

                }
                else
                {
                    row_data.WRONG_MATERIAL = k.MATERIAL;
                }

            }
            row_data.QUANTITY = qty;

            return new JsonResult(row_data);
        }

    }
}
