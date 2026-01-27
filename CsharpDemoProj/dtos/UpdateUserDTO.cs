using proj.entities;

namespace proj.dtos
{
    public class UpdateUserDTO
    {
        public string Email { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }

        public UpdateUserDTO()
        {
            this.Email = string.Empty;
            this.Document = string.Empty;
            this.Name = string.Empty;
            this.Password = string.Empty;
            this.Active = true;
        }
        public static User ToEntity(UpdateUserDTO dto, int id) => new User
        {
            Id = id,
            Email = dto.Email,
            Document = dto.Document,
            Name = dto.Name,
            Password = dto.Password,
            Active = dto.Active
        };
    }
}