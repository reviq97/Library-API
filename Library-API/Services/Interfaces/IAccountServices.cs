using Library_API.Models;

namespace Library_API.Services.Interfaces
{
    public interface IAccountServices
    {
        void RegisterUser(RegisterUserDto dto);
    }
}