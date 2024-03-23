﻿using Core.Entities.Concretes;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Abstracts;

public interface IAuthService
{
    IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
    IDataResult<User> Login(UserForLoginDto userForLoginDto);

    IResult userExists(string email);
    IDataResult<AccessToken> CreateAccessToken(User user);
}
