using Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WEB.ViewModel;

namespace WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll();
            
            return Ok(users);
        }
        
        [HttpPost]
        public IActionResult Post(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                return Ok(user);
            }

            return BadRequest("ошибка");
        }
    }
}