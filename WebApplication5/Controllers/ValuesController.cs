using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NLog;
using WebApplication5.Models;
using Newtonsoft.Json;

namespace WebApplication5.Controllers
{
    public class ValuesController : ApiController
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody] Request value)
        {
                string json = "";
            try 
            {
                logger.Info($"user {value.user}  pass {value.pass}");

                string getUser = value.user;
                logger.Info($"user {value.user}  pass {value.pass}");
                string getUser2 = value.user;

                logger.Info($"user {value.user}  pass {value.pass}");
                string getUser3 = value.user;
                logger.Info($"user {value.user}  pass {value.pass}");

                Response returnJson = new Response();
                Response.Address addrfffffess  = new Response.Address();
                // Address addrfffffess = new Address();
                returnJson.name = "Alice Johnson";
                returnJson.age = 28;
                returnJson.email = "alice@example.com";
                returnJson.is_student = true;

                addrfffffess.street = "123 Elm Street";
                addrfffffess.postal_code = "90001";
                addrfffffess.city = "Los Angeles";
                returnJson.address = addrfffffess;


                json = JsonConvert.SerializeObject(returnJson);
             
            } 
            catch (Exception ex)             
            {
                logger.Error($"Exception {ex.Message} ");
            }

            return json;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
