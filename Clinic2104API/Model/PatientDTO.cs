using AutoMapper;
using Clinic2104API.data;
using System.ComponentModel.DataAnnotations;

namespace Clinic2104API.Model
{
    [AutoMap(typeof(Patient), ReverseMap = true)]
    public class PatientDTO
    {
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [RegularExpression(@"07(7|8|9)\d{7}")]
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required]
        public int Country_Id { get; set; }

        public CountryDTO? country { get; set; }
    }
}
