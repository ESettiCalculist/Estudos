using AutoMapper;
using UsuariosApi_Identity.Data.Dtos;
using UsuariosApi_Identity.Models;

namespace UsuariosApi_Identity.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile() 
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
