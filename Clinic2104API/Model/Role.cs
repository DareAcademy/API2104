using System.ComponentModel.DataAnnotations;

namespace Clinic2104API.Model
{
    public class Role
    {
        [Required]
        public string Name { get; set; }
    }
}
