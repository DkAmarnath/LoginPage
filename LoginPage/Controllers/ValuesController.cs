using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginPage.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("api/getnames")]
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
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("api/logincheck")]
        public string GetLogindetails(string Username,string password)
        {
            Jan192019Entities db = new Jan192019Entities();
            var s = db.LoginCheck(Username, password);
            return s.FirstOrDefault();

        }
    }
}
