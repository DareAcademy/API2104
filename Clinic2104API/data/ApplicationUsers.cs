using Microsoft.AspNetCore.Identity;

namespace Clinic2104API.data
{
    public class ApplicationUsers : IdentityUser
    {
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
