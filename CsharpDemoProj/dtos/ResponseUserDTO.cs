namespace proj.dtos
{
    public class ResponseUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ResponseUserDTO()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
        }

        public static ResponseUserDTO FromEntity(entities.User user) => new ResponseUserDTO
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        };
    }
}