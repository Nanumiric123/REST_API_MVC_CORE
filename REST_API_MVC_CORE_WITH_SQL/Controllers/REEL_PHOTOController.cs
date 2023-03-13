using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Extensions.Configuration.Json;
using System.Text.Json;

namespace REST_API_MVC_CORE_WITH_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class REEL_PHOTOController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public REEL_PHOTOController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult GET()
        {
            string query = "SELECT * FROM [IBusinessTest].[dbo].[REEL_PHOTO]";
            DataTable dt = new DataTable();
            string sqlds = _configuration.GetConnectionString("WebApiDatabase");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlds))
            {
                myCon.Open();
                using(SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    myReader = cmd.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();

                }
                myCon.Close();

            }

            return new JsonResult(dt);
        }

        [HttpPost]
        public JsonResult Post([FromBody] string[] photo)
        {
           
            string img = photo[0];
            string bc = photo[1];
            string barcode = bc;



            try
            {
                string[] barcode_result = barcode.Split('(', ')');
                string vendor_num = barcode_result[2];
                string label_Date = barcode_result[4];
                string part_no = barcode_result[6];
                string carton_reel_no = barcode_result[8];
                string lot_no = barcode_result[10];
                decimal qty = decimal.Parse(barcode_result[12]);
                string uom = barcode_result[14];

                string sql = "INSERT INTO [dbo].[REEL_PHOTO] ([PHOTO],[VENDOR],[LABEL_DATE],[PART_NO],[CARTON_REEL_NO],[BATCH_NO]," +
                "[QUANTITY],[UOM]) VALUES (@img,@vend,@lbldat,@pnum,@carrelno,@lotnum,@quant,@uomstr)";
                string cstr = _configuration.GetConnectionString("WebApiDatabase");
                SqlConnection cnn = new SqlConnection(cstr);
                SqlCommand cmd = new SqlCommand(sql, cnn);

                cmd.Parameters.Add("@img", System.Data.SqlDbType.NVarChar).Value = img;
                cmd.Parameters.Add("@vend", System.Data.SqlDbType.NVarChar).Value = vendor_num;
                cmd.Parameters.Add("@lbldat", System.Data.SqlDbType.NVarChar).Value = label_Date;
                cmd.Parameters.Add("@pnum", System.Data.SqlDbType.NVarChar).Value = part_no;
                cmd.Parameters.Add("@carrelno", System.Data.SqlDbType.NVarChar).Value = carton_reel_no;
                cmd.Parameters.Add("@lotnum", System.Data.SqlDbType.NVarChar).Value = lot_no;
                cmd.Parameters.Add("@quant", System.Data.SqlDbType.NVarChar).Value = qty;
                cmd.Parameters.Add("@uomstr", System.Data.SqlDbType.NVarChar).Value = uom;

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return new JsonResult("S");
                }
                catch (SqlException ex)
                {
                    return new JsonResult("F" + ":" + ex.Message.ToString());
                }

               
            }
            catch
            {
                return new JsonResult("fail to split barcode");
            }
            

        }

    }
}
