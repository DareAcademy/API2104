using Clinic2104API.data;
using Clinic2104API.Model;
using Clinic2104API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic2104API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Doctor")]
    public class PatientController : ControllerBase
    {
        IPatientService patientService;
        public PatientController(IPatientService _patientService)
        {
            patientService = _patientService;
        }

        [HttpPost]
        public void SavePatient(PatientDTO patientDTO)
        {
            patientService.Insert(patientDTO);
        }

        [HttpGet]
        [Route("PatientList")]
        public List<PatientDTO> PatientList()
        {
            List<PatientDTO> patients = patientService.LoadAll();
            return patients;
        }

        [HttpGet]
        [Route("SearchPatient")]
        public List<PatientDTO> SearchPatient(string? phone,string? name)
        {
            List<PatientDTO> patients = patientService.Search(phone, name);
            return patients;
        }

        [HttpGet]
        [Route("LoadPatient")]
        public PatientDTO LoadPatient(int Id)
        {
            PatientDTO patientDTO = patientService.Load(Id);
            return patientDTO;
        }

        [HttpPut]
        public void UpdatePatient(PatientDTO patientDTO)
        {
            patientService.Update(patientDTO);
            
        }


    }
}
