﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi_Identity.Data.Dtos;
using UsuariosApi_Identity.Models;

namespace UsuariosApi_Identity.Services;

    public class UsuarioService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;
    private SignInManager<Usuario> _signInManager;
    private TokenService _tokenSevice;

    public UsuarioService(UserManager<Usuario> userManager, IMapper mapper, SignInManager<Usuario> signInManager, TokenService tokenSevice)
    {
        _userManager = userManager;
        _mapper = mapper;
        _signInManager = signInManager;
        _tokenSevice = tokenSevice;
    }

    public async Task Cadastra(CreateUsuarioDto dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);

        IdentityResult resultado =
            await _userManager.CreateAsync(usuario, dto.Password);

        if (!resultado.Succeeded)
        {
            throw new ApplicationException("Falha ao cadastrar usuario");
        }
    }

    public async Task<string> Login(LoginUsuarioDto dto)
    {
        var resultado = await
            _signInManager.PasswordSignInAsync
            (dto.Username, dto.Password, false, false);

        if (!resultado.Succeeded) 
        {
            throw new ApplicationException("Usuario nao autenticado");
        }

        var usuario = _signInManager
            .UserManager
            .Users
            .FirstOrDefault(user =>
            user.NormalizedUserName == dto.Username.ToUpper());

        var token = _tokenSevice.GenerateToken(usuario);

        return token;
    }
}

