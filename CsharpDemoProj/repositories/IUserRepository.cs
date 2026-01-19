using proj.entities;
using proj.dtos;

namespace proj.repositories
{
    public interface IUserRepository
    {
        public Task<User> AddUserAsync(User user);
        public Task<User?> GetUserByIdAsync(int id);
        public Task<List<User>> GetAllUsersAsync();
        public Task<User?> UpdateUserAsync(int id, User user);
        public Task<bool> DeleteUserAsync(int id);
    }
}