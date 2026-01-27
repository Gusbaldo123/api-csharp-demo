using proj.entities;

namespace proj.dtos
{
    public class RegisterUserDTO
    {
        public string Email { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public RegisterUserDTO()
        {
            this.Email = string.Empty;
            this.Document = string.Empty;
            this.Name = string.Empty;
            this.Password = string.Empty;
        }
        public static User ToEntity(RegisterUserDTO dto) => new User
        {
            Id = 0,
            Email = dto.Email,
            Name = dto.Name,
            Password = dto.Password
        };
    }
}