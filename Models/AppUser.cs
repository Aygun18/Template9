using Microsoft.AspNetCore.Identity;

namespace Template9.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
