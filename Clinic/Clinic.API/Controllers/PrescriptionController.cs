using Clinic.Core.Models;
using Clinic.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionService _prescriptionsService;
        public PrescriptionController(IPrescriptionService p)
        {
            _prescriptionsService = p;
        }
        // GET: api/<PrescriptionController>
        [HttpGet]
        public List<Prescription> Get()
        {
            return _prescriptionsService.GetList();
        }

        // GET api/<PrescriptionController>/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Prescription prescription = _prescriptionsService.GetList().FirstOrDefault(p => p.Id == id);
            return prescription != null ? Ok(prescription) : NotFound("id doesn't exists!!!");
        }

        // POST api/<PrescriptionController>
        [HttpPost]
        public ActionResult Post([FromBody] Prescription value)
        {
            Prescription p = _prescriptionsService.Add(value);
            return Ok(p);
        }

        // PUT api/<PrescriptionController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] bool value)
        {
            //Prescription prescription = _prescriptionsService.GetList().FirstOrDefault(p => p.Id == id);
            Prescription prescription = _prescriptionsService.GetById(id);
            if (prescription != null)
            {
                prescription.Date_passed = value;
                return Ok();
            }
            return NotFound("id doesn't exists!!!");
        }

        // DELETE api/<PrescriptionController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //Prescription prescription = _prescriptionsService .GetList().FirstOrDefault(p => p.Id == id);
            Prescription prescription = _prescriptionsService.GetById(id);

            if (prescription != null)
            {
                _prescriptionsService.GetList().Remove(prescription);
                return Ok();
            }

            return NotFound("id doesn't exists!!!");
        }
    }
}
