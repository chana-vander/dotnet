using AutoMapper;
using Clinic.API.Models;
using Clinic.Core.Dto;
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
        private readonly IMapper _mapper;

        public PatientController(IPatientService p,IMapper mapper)
        {
            _patientsService = p;
            _mapper = mapper;
        }
        // GET: api/<PatientController>
        [HttpGet]
        public ActionResult<PatientDto> Get()
        {
            var patients = _patientsService.GetList();
            var listDto=_mapper.Map<IEnumerable<Patient>>(patients);
            return Ok(listDto);
        }
        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public ActionResult<PatientDto> Get(int id)
        {
            Patient patient = _patientsService.GetById(id);
            var patientDto=_mapper.Map<Patient>(patient);
            return Ok(patientDto);
        }

        // POST api/<PatientController>
        [HttpPost]
        //הוספה
        public ActionResult Post([FromBody] PatientPostModel p)
        {
            var pToPost=new Patient() { name=p.name,phone=p.phone,above18=p.above18,status=p.status};
            Patient patient =_patientsService.Add(pToPost);
            return Ok(patient);
            //_patients.SaveChanges();
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PatientPostModel p)
        {
            /* Patient patient = _patients.GetAll().FirstOrDefault(p => p.id_tz == id);
             if (patient != null)
             {
                 patient.above18 = value;
                 return Ok();
             }*/
            var pToPost = new Patient() { name = p.name, phone = p.phone, above18 = p.above18, status = p.status };
            Patient patient = _patientsService.Update(pToPost);

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
