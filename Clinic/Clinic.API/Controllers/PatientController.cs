using Clinic.Core.Models;
using Clinic.Core.Repositories;
using Clinic.Core.Services;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientsService;
        public PatientController(IPatientService p)
        {
            _patientsService = p;
        }
        // GET: api/<PatientController>
        [HttpGet]
        public ActionResult<Patient> Get()
        {
            var patients = _patientsService.GetList();
            return Ok(patients);
        }
        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            Patient patient = _patientsService.GetById(id);
            if(patient is null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        // POST api/<PatientController>
        [HttpPost]
        //הוספה
        public ActionResult Post([FromBody] Patient p)
        {
            Patient patient =_patientsService.Add(p);
            return Ok(patient);
            //_patients.SaveChanges();
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Patient p)
        {
            /* Patient patient = _patients.GetAll().FirstOrDefault(p => p.id_tz == id);

             if (patient != null)
             {
                 patient.above18 = value;
                 return Ok();
             }*/
            Patient patient = _patientsService.Update(p);

            return Ok(patient);
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            /*Patient patient = _patients.GetAll().FirstOrDefault(p => p.id_tz == id);
            if (patient != null)
            {
                _patients.GetAll().Remove(patient);
                return Ok();
            }*/
            Patient patient = _patientsService.GetById(id);
            if(patient is not null)
            {
                _patientsService.Delete(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
