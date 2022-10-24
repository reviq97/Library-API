using Library_API.Database;
using Library_API.Entities;
using Library_API.Models;
using Library_API.Services.Interfaces;

namespace Library_API.Services
{
    public class AccountServices : IAccountServices
    {
        private readonly ApplicationDbContext _dbContext;

        public AccountServices(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public void RegisterUser(RegisterUserDto dto)
        {
            //logic todo
        }
    }
}
