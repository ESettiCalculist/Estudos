using ApiStore.Enums;

namespace ApiStore.Dto;

public class CadastrarUsuarioDTO
{
    public string Nome { get; set; }
    public string NomeUsuario { get; set; }
    public string Senha { get; set; }
    public TipoPermissao Permissao { get; set; }
}
