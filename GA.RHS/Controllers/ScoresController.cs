using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GA.RHS.EnityFramework;
namespace GA.RHS.Controllers
{
    public class ScoresController : ApiController
    {
        // GET: api/Scores
        public IHttpActionResult Get()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetScores().ToList();
                return Ok(scores);
            }
        }

        // GET: api/Scores/GetCityScores
        public IHttpActionResult GetCityScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetAvgScoresByCity().ToList();
                return Ok(scores);
            }
        }

        // GET: api/Scores/GetRestaurentScores
        public IHttpActionResult GetRestaurentScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetAvgScoresByRestaurent().ToList();
                return Ok(scores);
            }
        }

        // GET: api/Scores/GetZipScores
        public IHttpActionResult GetZipScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetScoresByZip().ToList();
                return Ok(scores);
            }
        }

        // GET: api/Scores/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Scores
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Scores/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Scores/5
        public void Delete(int id)
        {
        }
    }
}
