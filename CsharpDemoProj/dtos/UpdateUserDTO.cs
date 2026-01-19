namespace proj.dtos
{
    public class UpdateUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UpdateUserDTO()
        {
            this.Id = 0;
            this.Email = string.Empty;
            this.Name = string.Empty;
            this.Password = string.Empty;
        }
    }
}