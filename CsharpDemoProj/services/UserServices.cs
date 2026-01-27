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
            user.Password = HashUtils.HashString(user.Password);
            User createdUser = await _userRepository.AddUserAsync(RegisterUserDTO.ToEntity(user));
            return ResponseUserDTO.FromEntity(createdUser);
        }
        public async Task<ResponseUserDTO?> GetUserByIdAsync(int id)
        {
            User? foundUser = await _userRepository.GetUserByIdAsync(id);
            if (foundUser != null)
                return ResponseUserDTO.FromEntity(foundUser);
            return null;
        }
        public async Task<List<ResponseUserDTO>> GetAllUsersAsync()
        {
            List<User> users =  await _userRepository.GetAllUsersAsync();
            return users.Select(user => ResponseUserDTO.FromEntity(user)).ToList();
        }
        public async Task<ResponseUserDTO?> UpdateUserAsync(int id, UpdateUserDTO user)
        {
            User? updatedUser = await _userRepository.UpdateUserAsync(id, UpdateUserDTO.ToEntity(user, id));
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