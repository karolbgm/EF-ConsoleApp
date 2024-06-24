using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial;
public class User
{
    public int Id { get; set; } //it defaults to 0
    public string Username { get; set; } = string.Empty; //it is not allowed to be null
    public string Password { get; set; } = string.Empty;
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string? Phone { get; set; } //it defaults to null if you add '?'
    public string? Email { get; set; }
    public bool isReviewer { get; set; }
    public bool isAdmin { get; set; }

}
