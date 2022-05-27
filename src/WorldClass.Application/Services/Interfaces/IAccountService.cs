using WorldClass.Application.Dto;

namespace WorldClass.Application.Services.Interfaces
{
    public interface IAccountService
    {
        Task<string> SignUpAsync(SignUpDto signUpDto);
        Task<string> SignInAsync(SignInDto signInDto);
        Task<string> RefreshTokenAsync(SignUpDto signUpDto);
    }
}
