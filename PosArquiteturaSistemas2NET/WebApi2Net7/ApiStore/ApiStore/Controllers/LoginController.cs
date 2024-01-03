using ApiStore.Dto;
using ApiStore.Entity;
using ApiStore.Interface;
using ApiStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiStore.Controllers;

[ApiController]
[Route("login")]
public class LoginController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly ITokenService _tokenService;

    public LoginController(
        IUsuarioRepository usuarioRepository, 
        ITokenService tokenService)
    {
        _usuarioRepository = usuarioRepository;
        _tokenService = tokenService;
    }

    [HttpPost]
    public IActionResult Autenticar([FromBody] LoginDTO usuarioDto)
    {
        var usuario = _usuarioRepository.ObterPorNomeUsuarioESenha(
            usuarioDto.NomeUsuario, usuarioDto.Senha);
        if (usuario == null)
            return NotFound(new
            {
                mensagem = "Usuario ou senha invalidos"
            });
            var token = _tokenService.GerarToken(usuario);
            usuario.Senha = null;

            return Ok(new
            {
                Usuario = usuario,
                Token = token
            });
    } 
}
