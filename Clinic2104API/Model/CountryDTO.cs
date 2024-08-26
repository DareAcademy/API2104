using AutoMapper;
using Clinic2104API.data;
using System.ComponentModel.DataAnnotations;

namespace Clinic2104API.Model
{
    [AutoMap(typeof(Country), ReverseMap = true)]
    public class CountryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fillout the country name")]
        public string Name { get; set; }
    }
}
