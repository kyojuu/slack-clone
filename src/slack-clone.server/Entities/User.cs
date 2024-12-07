using Microsoft.AspNetCore.Identity;

namespace slack_clone.server;

public class User : IdentityUser
{
    public string? Initials { get; set; }
}
 

