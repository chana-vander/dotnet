using Clinic.Core.Models;
using Clinic.Core.Services;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        //this line:
        private readonly IDoctorsService _doctorsService;
        public DoctorsController(IDoctorsService doctorsSe)
        {
            _doctorsService = doctorsSe;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            var doctors = _doctorsService.GetList();
            return Ok(doctors);
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            //Doctor doctor = _doctorsService.GetAll().FirstOrDefault(d => d.id == id);
            Doctor doctor = _doctorsService.GetById(id);
            if (doctor is not null)
            {
                return Ok(doctor);

            }
            return NotFound();
        }

        // POST api/<DoctorsController>
        [HttpPost]
        //add
        public ActionResult Post(Doctor d)
        {
            Doctor doctor = _doctorsService.Add(d);
            return Ok(doctor);
            //_doctorsService.SaveChanges();
        }

        // PUT api/<DoctorsController>/5
        //עדכון -update 
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
            Doctor updatedDoctor = _doctorsService.Update(doctor);
            if (updatedDoctor is null)
            {
                return NotFound("id not found");
            }
            return Ok(updatedDoctor);
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Doctor doctor = _doctorsService.GetById(id);
            if (doctor is not null)
            {
                _doctorsService.Delete(id);
                return Ok();
            }
            return NotFound();

        }

    }
}
