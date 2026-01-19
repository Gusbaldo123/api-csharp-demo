using proj.entities;
using proj.dtos;

namespace proj.repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> AddUserAsync(User user)
        {
            return new User();
        }
        public async Task<User?> GetUserByIdAsync(int id)
        {
            return new User();
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            return null;
        }
        public async Task<User?> UpdateUserAsync(int id, User user)
        {
            return new User();
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            return new bool();
        }
    }
}