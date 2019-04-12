using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PilldropApi.Controllers
{
    public class MedicationController : ApiController
    {
        public MedicationController()
        {
            
        }
        // GET: api/Medication
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Medication/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Medication
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Medication/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Medication/5
        public void Delete(int id)
        {
        }
    }
}
