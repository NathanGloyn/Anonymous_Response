using System.Web.Http;

namespace Anonymous_Response.Controllers
{
    public class DataController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json(new { id = 1 });
        }


        public IHttpActionResult GetAll()
        {
            return Json(new {items = new[] {"1", "2", "3"}});
        }
    }
}
