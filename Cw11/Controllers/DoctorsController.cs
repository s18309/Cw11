using Cw11.Models;
using Cw11.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDBService Db;

        public DoctorsController([FromServices] IDBService Db)
        {
            this.Db = Db;
        }

        [HttpGet]
        public IActionResult getDoctors()
        {
           
            return Ok(Db.getDoctors());
        }

        [HttpPut]
        public IActionResult addDoctor([FromBody]Doctor D)
        {
            return Db.addDoctor(D);
        }

        [HttpPost]
        public IActionResult modifyDoctor([FromBody] Doctor D)
        {
            return Db.ModifyDoctor(D);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult deleteDoctor([FromRoute] int id)
        {
            return Db.RemoveDoctor(id);

        }
    }
}