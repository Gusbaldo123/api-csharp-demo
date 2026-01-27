namespace proj.dtos
{
    public class ResponseUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public DateOnly CreatedAt { get; set; }
        public bool Active { get; set; }

        public ResponseUserDTO()
        {
            Name = string.Empty;
            Email = string.Empty;
            Document = string.Empty;
            CreatedAt = DateOnly.FromDateTime(DateTime.Now);
            Active = true;
        }

        public static ResponseUserDTO FromEntity(entities.User user) => new ResponseUserDTO
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Document = user.Document,
            CreatedAt = user.CreatedAt,
            Active = user.Active
        };
    }
}