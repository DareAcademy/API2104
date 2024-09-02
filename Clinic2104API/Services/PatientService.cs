using AutoMapper;
using Clinic2104API.data;
using Clinic2104API.Model;
using Microsoft.EntityFrameworkCore;

namespace Clinic2104API.Services
{
    public class PatientService:IPatientService
    {
        ClinicContext context;
        IMapper mapper;
        public PatientService(ClinicContext _context,
                              IMapper _mapper  ) 
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(PatientDTO patientDTO)
        {
            Patient newPatient = mapper.Map<Patient>(patientDTO);
            context.patients.Add(newPatient);
            context.SaveChanges();
        }

        public List<PatientDTO> LoadAll()
        {
            List<Patient> allPatients = context.patients.Include("country").ToList();
            List<PatientDTO> patients = new List<PatientDTO>();
            patients = mapper.Map<List<PatientDTO>>(allPatients);
            return patients;
        }

        public PatientDTO Load(int Id)
        {
            Patient patient = context.patients.Find(Id);
            PatientDTO patientDTO = mapper.Map<PatientDTO>(patient);
            return patientDTO;
        }

        public List<PatientDTO> Search(string? Phone,string? name)
        {

            IQueryable<Patient> query = context.patients.Include("country").AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                query=query.Where(p => p.FName.Contains(name) || p.LName.Contains(name));
            }
            if (!string.IsNullOrEmpty(Phone))
            {
                query = query.Where(p => p.Phone == Phone);
            }
            //List<Patient> allpatients = context.patients.Include("country").Where(p => p.Phone == Phone).ToList();
            List<PatientDTO> patients = new List<PatientDTO>();
            patients = mapper.Map<List<PatientDTO>>(query);
            return patients;
        }

        public void Update(PatientDTO patientDTO)
        {
            Patient newPatient = mapper.Map<Patient>(patientDTO);
            context.patients.Attach(newPatient);
            context.Entry(newPatient).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
