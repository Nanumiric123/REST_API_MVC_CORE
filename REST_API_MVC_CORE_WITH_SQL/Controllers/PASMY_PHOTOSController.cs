using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API_MVC_CORE_WITH_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PASMY_PHOTOSController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public PASMY_PHOTOSController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult Post([FromBody] string[] photo)
        {

            string img = photo[0];
            string name = photo[1];

            try
            {
                

                string sql = "INSERT INTO [dbo].[PASMY_PHOTOS] ([PHOTO],[NAME]) VALUES (@img,@name)";
                string cstr = _configuration.GetConnectionString("WebApiDatabase");
                SqlConnection cnn = new SqlConnection(cstr);
                SqlCommand cmd = new SqlCommand(sql, cnn);

                cmd.Parameters.Add("@img", System.Data.SqlDbType.NVarChar).Value = img;
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                

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
            catch (Exception EX)
            {
                return new JsonResult(EX.Message.ToString());
            }


        }


    }
}
