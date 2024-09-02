using Clinic2104API.Model;

namespace Clinic2104API.Services
{
    public interface IPatientService
    {
        void Insert(PatientDTO patientDTO);

        List<PatientDTO> LoadAll();

        List<PatientDTO> Search(string? Phone, string? name);

        PatientDTO Load(int Id);

        void Update(PatientDTO patientDTO);
    }
}
