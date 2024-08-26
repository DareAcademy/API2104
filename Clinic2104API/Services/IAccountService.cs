using Clinic2104API.Model;
using Clinic2104API.data;
using Microsoft.AspNetCore.Identity;


namespace Clinic2104API.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateAccount(SignUp signUp);
        Task<SignInResult> SignIn(SignIn signIn);
        Task Logout();

        Task<IdentityResult> AddRole(Role role);

        List<UsersDTO> getUsers();

        Task<List<UserRoles>> getRoles(string UserId);


		Task UpdateUserRoles(List<UserRoles> liUserRoles);

        Task<ApplicationUsers> getUSerInfo(string username);


        List<string> getUserRoles(ApplicationUsers obj);

	}
}
