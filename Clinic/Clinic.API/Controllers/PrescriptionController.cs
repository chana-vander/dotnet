using AutoMapper;
using Clinic.API.Models;
using Clinic.Core.Dto;
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
        private readonly IMapper _mapper;
        public PrescriptionController(IPrescriptionService p,IMapper mapper)
        {
            _prescriptionsService = p;
            _mapper = mapper;
        }
        // GET: api/<PrescriptionController>
        [HttpGet]
        public ActionResult<PrescriptionDto> Get()
        {
            var list= _prescriptionsService.GetList();
            var listDto=_mapper.Map<IEnumerable<PrescriptionDto>>(list);
            return Ok(listDto);
        }

        // GET api/<PrescriptionController>/5
        [HttpGet("{id}")]
        public ActionResult<PrescriptionDto> GetById(int id)
        {
            Prescription prescription = _prescriptionsService.GetById(id);
            var prescriptionDto=_mapper.Map<PrescriptionDto>(prescription);
            return prescription != null ? Ok(prescriptionDto) : NotFound("id doesn't exists!!!");
        }

        // POST api/<PrescriptionController>
        [HttpPost]
        public ActionResult Post([FromBody] PrescriptionPostModel pres)
        {
            var pToPost=new Prescription() {Date_passed=pres.Date_passed,Desecription=pres.Desecription };
            Prescription p = _prescriptionsService.Add(pToPost);
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
