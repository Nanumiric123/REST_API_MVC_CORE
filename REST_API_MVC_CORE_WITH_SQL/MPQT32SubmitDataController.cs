using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using REST_API_MVC_CORE_WITH_SQL.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Threading.Tasks;
using System.ServiceModel;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API_MVC_CORE_WITH_SQL
{
    [Route("api/[controller]")]
    [ApiController]
    public class MPQT32SubmitDataController : ControllerBase
    {
        // GET: api/<MPQT32SubmitDataController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MPQT32SubmitDataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MPQT32SubmitDataController>
        [HttpPost]
        public JsonResult Post([FromBody] MPQT32 value)
        {
            PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient.EndpointConfiguration endpoint;
            endpoint = PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient.EndpointConfiguration.Local_Ws_secondSoap12;
            PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient CLIENT = new PART_INFO_Local_Ws_second.Local_Ws_secondSoapClient(endpoint);
            Task<string> test = CLIENT.MPQsubmitToSAPT32Async(value.BINNO, value.MATERIAL, value.STORAGELOCATION,value.BADGENUM);

            test.Wait();

            return new JsonResult(test.Status.ToString() + " - " + test.Result.ToString());


        }

        // PUT api/<MPQT32SubmitDataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MPQT32SubmitDataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
