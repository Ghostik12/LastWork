﻿using Microsoft.AspNetCore.Identity;
using SocialApi.Data.Models.Request.Users;
using SocialApi.Data.Models.Response.Users;

namespace SocialApi.Contracts.Services.IServices
{
    public interface IAccountService
    {
        Task<IdentityResult> Register(RegisterRequest model);
        Task<IdentityResult> EditAccount(UserEditRequest model);
        Task<SignInResult> Login(LoginRequest model);
        Task<UserEditRequest> EditAccount(Guid id);
        Task RemoveAccount(Guid id);
        Task<List<User>> GetAccounts();
    }
}
