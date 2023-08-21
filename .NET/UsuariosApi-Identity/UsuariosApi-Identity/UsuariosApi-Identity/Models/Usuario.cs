using Microsoft.AspNetCore.Identity;

namespace UsuariosApi_Identity.Models;

public class Usuario : IdentityUser
{
    public DateTime DataNascimento { get; set; }
    public Usuario() : base() { }
}
