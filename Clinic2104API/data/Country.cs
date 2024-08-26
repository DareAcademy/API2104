using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic2104API.data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Patient> Patients { get; set; }
    }
}
