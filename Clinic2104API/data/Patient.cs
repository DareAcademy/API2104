using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic2104API.data
{
    [Table("Patient")]
    public class Patient
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FName { get; set; }
        [StringLength(50)]
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }

        public string? Email { get; set; }

        [ForeignKey("country")]
        public int Country_Id { get; set; }

        public Country country { get; set; }
    }
}
