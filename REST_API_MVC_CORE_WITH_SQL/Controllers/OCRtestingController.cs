using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API_MVC_CORE_WITH_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OCRtestingController : ControllerBase
    {
        // GET: api/<OCRtestingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OCRtestingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OCRtestingController>
        [HttpPost]
        public JsonResult Post([FromBody] string photo)
        {
            string restfulAPILink_fulltextbb = "https://custom-ocr.klippa.com/api/v1/";
            string base64img = photo;
            var client = new RestClient(restfulAPILink_fulltextbb);
            var request = new RestRequest("parseDocument/fulltext_bb", Method.Post);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("X-Auth-Key", "y6HTv25VF03LgZ3t6YArG9dquPmuG0Gs");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"  ""document"": """ + base64img + "\"" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var resp = client.Execute(request);
            return new JsonResult(resp.Content + " " + resp.ResponseStatus + " " + resp.StatusCode + " " + resp.ErrorMessage + " " + resp.ErrorException);
        }

        // PUT api/<OCRtestingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OCRtestingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
