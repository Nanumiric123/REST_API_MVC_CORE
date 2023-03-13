using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API_MVC_CORE.Models;
using System.Text.Json;
using REST_API_MVC_CORE.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API_MVC_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class REEL_PHOTOController : ControllerBase
    {
        // GET: api/<REEL_PHOTOController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<REEL_PHOTOController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }



        // POST api/<REEL_PHOTOController>
        [HttpPost]
        public string Post([FromBody] string[] test)
        {

            string image = test[1];

            try
            {
                string[] barcode_result = test[0].Split('(', ')');
                string vendor_num = barcode_result[2];
                string label_Date = barcode_result[4];
                string part_no = barcode_result[6];
                string carton_reel_no = barcode_result[8];
                string lot_no = barcode_result[10];
                decimal qty = decimal.Parse(barcode_result[12]);
                string uom = barcode_result[14];
            }
            catch
            {

            }
          

            return "Success";



        }

        // PUT api/<REEL_PHOTOController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<REEL_PHOTOController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
