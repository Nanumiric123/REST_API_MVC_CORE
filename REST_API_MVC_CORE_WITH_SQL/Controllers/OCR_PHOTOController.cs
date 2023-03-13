using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace REST_API_MVC_CORE_WITH_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OCR_PHOTOController : Controller
    {
        private readonly IConfiguration _configuration;
        public OCR_PHOTOController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        SqlConnection cnn = new SqlConnection();

        [HttpPost]
        public JsonResult Post([FromBody] string photo)
        {
            cnn.ConnectionString = @"Data Source=172.16.206.20;Initial Catalog=IBusinessTest;User ID=Data_writer;Password=Pasmy@2791381230";

            string img = photo.Replace("\n","");
            string error = "";
            string restfulAPILink_fulltextbb = "https://custom-ocr.klippa.com/api/v1/";

            try
            {
                var client = new RestClient(restfulAPILink_fulltextbb);
                error = "1";
                var request = new RestRequest("parseDocument/fulltext_bb", Method.Post);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("X-Auth-Key", "y6HTv25VF03LgZ3t6YArG9dquPmuG0Gs");
                request.AddHeader("Content-Type", "application/json");
                error = "2";
                var body = @"{" + "\n" +
                @"  ""document"": """ + img + "\"" + "\n" +
                @"}";
                error = "3";
                //request.AddParameter("application/json", body, ParameterType.RequestBody);
                request.AddJsonBody(body);
                error = "4";
                var resp = client.Execute(request);
                error = "5";

                //var res = JsonConvert.DeserializeObject<RESULT_DATA>(resp.Content);
                error = "6";
                                                    /*
                if (res.result == "success")
                {

                    string B = "";

                    foreach (var i in res.data.ocr.pages)
                    {
                        foreach (var j in i.lines)
                        {
                            foreach (var k in j.words)
                            {
                                B = B + " " + k.text;
                            }
                        }
                    }

                    if (B.Contains("'"))
                    {
                        B = B.Replace("'", "");
                    }

                    string sqlCmd = "INSERT INTO [dbo].[PASMY_PHOTOS] ([PHOTO],[NAME]) VALUES ('" + photo + "','" + B + "')";
                    SqlCommand cmd = new SqlCommand(sqlCmd, cnn);
                    cnn.Open();
                    //cmd.ExecuteNonQuery();
                    cnn.Close();



                }
                else
                {
                    return new JsonResult("Fail");
                }
                                                    */
                return new JsonResult(resp.Content + " " + resp.ResponseStatus + " " + resp.StatusCode + " " + resp.ErrorMessage + " " + resp.ErrorException);

            }
            catch (Exception EX)
            {
                return new JsonResult("RESTAPI ERROR :" + error + " : " + EX.Message.ToString());
            }


        }

    }

    class RESULT_DATA
    {
        public string result { get; set; }
        public ocr_field data { get; set; }
        public string request_id { get; set; }
    }

    class ocr_field
    {
        public pages_field ocr { get; set; }
    }

    class pages_field
    {
        public line_size[] pages { get; set; }
    }

    class line_size
    {
        public int[] size { get; set; }
        public lines_i[] lines { get; set; }
    }

    class lines_i
    {
        public string text { get; set; }
        public int[,] bounding_box { get; set; }
        public text_bb[] words { get; set; }
    }

    class text_bb
    {
        public string text { get; set; }
        public int[,] bounding_box { get; set; }
    }


}
