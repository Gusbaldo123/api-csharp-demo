using proj.dtos;

namespace proj.services
{
    public interface IUserServices
    {
        public Task<ResponseUserDTO> CreateUserAsync(RegisterUserDTO dto);

        public Task<ResponseUserDTO?> GetUserByIdAsync(int id);
        
        public Task<List<ResponseUserDTO>> GetAllUsersAsync();

        public Task<ResponseUserDTO?> UpdateUserAsync(int id, UpdateUserDTO dto);

        public Task<bool> DeleteUserAsync(int id);
    }
}