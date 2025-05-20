using backend.src.models;
using backend.src.repositories;
using backend.src.views;
using Microsoft.AspNetCore.Mvc;

namespace backend.src.controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpPost]
        public IActionResult Add(UserViewModel userViewModel)
        {
            User user = new User(userViewModel.username, userViewModel.password);
            _userRepository.Add(user);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userRepository.Get());
        }
    }
}