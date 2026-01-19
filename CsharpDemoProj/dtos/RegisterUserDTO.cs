namespace proj.dtos
{
    public class RegisterUserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisterUserDTO()
        {
            this.Email = string.Empty;
            this.Name = string.Empty;
            this.Password = string.Empty;
        }
    }
}