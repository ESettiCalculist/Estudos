using ApiStore.Dto;
using ApiStore.Entity;
using ApiStore.Enums;
using ApiStore.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiStore.Controllers;

[ApiController]
[Route("Usuario")]
public class UsuarioController : ControllerBase
{
    private IUsuarioRepository _usuarioRepository;
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(
        IUsuarioRepository usuarioRepository, ILogger<UsuarioController> logger)
    {
        _usuarioRepository = usuarioRepository;
        _logger = logger;
    }

    [Authorize]
    [Authorize(Roles = Permissoes.Administrador)]
    [HttpGet("obter-todos-usuarios")]
    public IActionResult ObterUsuario()
    {
        try
        {
            return Ok(_usuarioRepository.ObterTodos());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"{DateTime.Now}Exception forçada: {ex.Message}");
            return BadRequest();
        }

    }

    /// <summary>
    /// ObTem todos os usuarios com pedido
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <remarks>
    /// Exemplo:
    /// Enviar Id para requisição
    /// </remarks>
    /// <response code="200"> Retorna Sucesso </response>
    /// <response code="401"> Não Autenticado </response>
    /// <response code="403"> Não Autorizado </response>
    [Authorize]
    [HttpGet("obter-todos-com-pedidos/{id}")]
    public IActionResult ObterTodosComPedidos(int id)
    {
        return Ok(_usuarioRepository.ObterComPedidos(id));
    }
    [Authorize]
    [Authorize(Roles = Permissoes.Funcionario)]
    [HttpGet("obter-usuarios-por-id/{id}")]
    public IActionResult ObterUsuarioPorId(int id)
    {
        _logger.LogInformation("Executando metodo ObterPorUsuarioId");
        return Ok(_usuarioRepository.ObterPorId(id));
    }
    [Authorize]
    [Authorize(Roles = $"{Permissoes.Administrador}, {Permissoes.Funcionario}")]
    [HttpPost]
    public IActionResult CadastrarUsuario(CadastrarUsuarioDTO usuarioDto)
    {
        _usuarioRepository.Cadastrar(new Usuario(usuarioDto));
        var mensagem = $"Usuario criado com sucesso! | Nome: {usuarioDto.Nome}";
        _logger.LogWarning(mensagem);
        return Ok(mensagem);
    }
    [HttpPut("alterar-usuario")]
    public IActionResult AlterarUsuario(AlterarUsuarioDTO usuarioDto)
    {
        _usuarioRepository.Alterar(new Usuario(usuarioDto));
        return Ok("Usuario alterado com sucesso");
    }
    [HttpDelete("{id}")]
    public IActionResult DeletarUsuario(int id)
    {
        _usuarioRepository.Deletar(id);
        return Ok("Usuario deletado com sucesso");
    }
}
