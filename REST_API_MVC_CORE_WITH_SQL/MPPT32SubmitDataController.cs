using Microsoft.AspNetCore.Mvc;
using REST_API_MVC_CORE_WITH_SQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API_MVC_CORE_WITH_SQL
{
    [Route("api/[controller]")]
    [ApiController]
    public class MPPT32SubmitDataController : ControllerBase
    {
        // GET: api/<MPPT32SubmitDataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MPPT32SubmitDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MPPT32SubmitDataController>
        [HttpPost]
        public JsonResult Post([FromBody] MPQT32 value)
        {
            PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient.EndpointConfiguration endpoint;
            endpoint = PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient.EndpointConfiguration.Local_Ws_secondSoap12;

            PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient CLIENT = new PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient(endpoint);
            Task<string> result = CLIENT.MPPsubmitToSAPT32Async(value.BINNO, value.MATERIAL, value.STORAGELOCATION, value.BADGENUM);
            result.Wait();

            return new JsonResult(result.Status.ToString() + " - " + result.Result.ToString());

        }

        // PUT api/<MPPT32SubmitDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MPPT32SubmitDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
