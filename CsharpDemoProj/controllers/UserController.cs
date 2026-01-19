using Microsoft.AspNetCore.Mvc;
using proj.dtos;
using proj.services;

namespace proj.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userService)
        {
            _userServices = userService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] RegisterUserDTO user)
        {
            try
            {
                var createdUser = await _userServices.CreateUserAsync(user);
                return CreatedAtAction(nameof(GetUserById), 
                    new { id = createdUser.Id }, createdUser);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userServices.GetUserByIdAsync(id);
            
            if (user == null)
                return NotFound();
                
            return Ok(user);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserDTO user)
        {
            var updatedUser = await _userServices.UpdateUserAsync(id, user);
            
            if (updatedUser == null)
                return NotFound();
                
            return Ok(updatedUser);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deleted = await _userServices.DeleteUserAsync(id);
            
            if (!deleted)
                return NotFound();
                
            return Ok();
        }
    }
}