using proj.entities;
using proj.dtos;
using proj.data;
using Microsoft.EntityFrameworkCore;

namespace proj.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<User> AddUserAsync(User user)
        {
            try
            {
                await _context.users.AddAsync(user);
                await _context.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding user", ex);
            }
        }
        public async Task<User?> GetUserByIdAsync(int id)
        {
            try
            {
                User? user = await _context.users.FirstOrDefaultAsync(u => u.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding user {id}", ex);
            }
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            try
            {
                return await _context.users.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error user list", ex);
            }
        }
        public async Task<User?> UpdateUserAsync(int id, User user)
        {
            try
            {
                User? foundUser = await _context.users.FirstOrDefaultAsync(u => u.Id == id);
                if (foundUser == null)
                    return null;

                foundUser.Email = user.Email;
                foundUser.Document = user.Document;
                foundUser.Name = user.Name;
                foundUser.Password = user.Password;
                foundUser.Active = user.Active;

                await _context.SaveChangesAsync();
                return foundUser;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating user {id}", ex);
            }
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            try
            {
                User? foundUser = await _context.users.FirstOrDefaultAsync(u => u.Id == id);
                if (foundUser == null)
                    return false;

                _context.users.Remove(foundUser);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting user {id}", ex);
            }
        }
    }
}