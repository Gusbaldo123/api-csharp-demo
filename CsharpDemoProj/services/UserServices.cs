using proj.dtos;
using proj.entities;

namespace proj.services
{
    public class UserServices : IUserServices
    {
        private readonly repositories.IUserRepository _userRepository;
        public UserServices(repositories.IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<ResponseUserDTO> CreateUserAsync(RegisterUserDTO user)
        {
            User createdUser = await _userRepository.AddUserAsync(User.ToEntity(user));
            return ResponseUserDTO.FromEntity(createdUser);
        }
        public async Task<ResponseUserDTO?> GetUserByIdAsync(int id)
        {
            User? foundUser = await _userRepository.GetUserByIdAsync(id);
            if (foundUser != null)
                return ResponseUserDTO.FromEntity(foundUser);
            return null;
        }
        public async Task<ResponseUserDTO?> UpdateUserAsync(int id, UpdateUserDTO user)
        {
            User? updatedUser = await _userRepository.UpdateUserAsync(id, User.ToEntity(user, id));
            if (updatedUser != null)
                return ResponseUserDTO.FromEntity(updatedUser);
            return null;
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            bool result = await _userRepository.DeleteUserAsync(id);
            return result;
        }
    }
}