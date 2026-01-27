namespace proj.dtos
{
    public class LoginUserDTO
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public LoginUserDTO(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}