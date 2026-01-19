using proj.dtos;

namespace proj.entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User()
        {
            this.Email = string.Empty;
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
        public static User ToEntity(UpdateUserDTO dto, int id) => new User
        {
            Id = id,
            Email = dto.Email,
            Name = dto.Name,
            Password = dto.Password
        };
    }
}