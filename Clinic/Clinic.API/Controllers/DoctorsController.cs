using AutoMapper;
using Clinic.API.Models;
using Clinic.Core.Dto;
using Clinic.Core.Models;
using Clinic.Core.Services;
using Clinic.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorsService doctorsSe,IMapper mapper)
        {
            _doctorsService = doctorsSe;
            _mapper = mapper;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            var list = _doctorsService.GetList();
            var listDto=_mapper.Map<IEnumerable<DoctorDto>>(list);
            return Ok(listDto);
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Doctor doctor = _doctorsService.GetById(id);
            var doctorDto = _mapper.Map<DoctorDto>(doctor);
            return Ok(doctorDto);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        //add
        public async Task<ActionResult> Post(DoctorPostModel d)
        {
            var dToPost = new Doctor { Doctor_name = d.Doctor_name, occupation = d.occupation, phone = d.phone };
            Doctor doctor = await _doctorsService.AddAsync(dToPost);
            return Ok(doctor);
            //_doctorsService.SaveChanges();
        }

        // PUT api/<DoctorsController>/5
        //עדכון -update 
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] DoctorPostModel doctor)
        {
            var dToPost = new Doctor { Doctor_name = doctor.Doctor_name, occupation = doctor.occupation, phone = doctor.phone };
            Doctor updatedDoctor = _doctorsService.Update(dToPost);
            /*if (updatedDoctor is null)
            {
                return NotFound("id not found");
            }*/
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
