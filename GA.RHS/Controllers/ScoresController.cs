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
        [HttpGet]
        [Route("Scores/full")]
        public IHttpActionResult GetScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                List<SP_GetScores_Result> scores = db.SP_GetScores().ToList<SP_GetScores_Result>();
                return Ok(scores);
            }
        }

        // GET: api/Scores/GetCityScores
        [HttpGet]
        [Route("Scores/city")]
        public IHttpActionResult GetCityScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetAvgScoresByCity().ToList();
                return Ok(scores);
            }
        }

        // GET: api/Scores/GetRestaurentScores
        [HttpGet]
        [Route("Scores/restaurent")]
        public IHttpActionResult GetRestaurentScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetAvgScoresByRestaurent().ToList();
                return Ok(scores);
            }
        }

        // GET: api/Scores/GetZipScores
        [HttpGet]
        [Route("Scores/zip")]
        public IHttpActionResult GetZipScores()
        {
            using (RHSEntities db = new RHSEntities())
            {
                var scores = db.SP_GetScoresByZip().ToList();
                return Ok(scores);
            }
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
