using ApiStore.Entity;

namespace ApiStore.Services;

public interface ITokenService
{
    string GerarToken(Usuario usuario);
}
