using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vehicles.API.Data.Entities;
using vehicles.API.Models;
using vehicles.common.Enums;

namespace vehicles.API.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<User> GetUserAsync(Guid email);

        Task<User> AddUserAsync(AddUserViewModel model, Guid guid, UserType userType);


        Task<IdentityResult> DeleteUserAsync(User user);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<IdentityResult> UpdateUserAsync(User user);


        Task CheckRoleAsync(string roleName);

        Task AddUsertoRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
