using System.ComponentModel.DataAnnotations.Schema;
using proj.dtos;

namespace proj.entities
{
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("document")]
        public string Document { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("created_at")]
        public DateOnly CreatedAt { get; set; }
        [Column("active")]
        public bool Active { get; set; }
        
        public User()
        {
            this.Email = string.Empty;
            this.Name = string.Empty;
            this.Document = string.Empty;
            this.Password = string.Empty;
            this.CreatedAt = DateOnly.FromDateTime(DateTime.Now);
            this.Active = true;
        }
        public User(int id, string email, string document, string name, string password, DateOnly createdAt,  bool active)
        {
            Id = id;
            Email = email;
            Document = document;
            Name = name;
            Password = password;
            this.CreatedAt = DateOnly.FromDateTime(DateTime.Now);
            Active = active;
        }
    }
}