using ContactApp.Data.Repository;
using ContactApp.Domain;
using ContactEFCoreApp.ModelDTO;
using ContactEFCoreApp.Token;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperUserController : ControllerBase
    {
        private readonly IContactRepository<SuperUser> _repository;
        private readonly ICustomTokenManager _tokenManager;
        public SuperUserController(IContactRepository<SuperUser> repository, ICustomTokenManager tokenManager)
        {
            _repository = repository;
            _tokenManager = tokenManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> LoginSuperUser([FromBody] SuperLoginDTO superLogin)
        {
            if (ModelState.IsValid)
            {
                SuperUser user = await _repository.FirstOrDefault(x => x.Username == superLogin.Username);
                if (user != null)
                {
                    if (BC.Verify(superLogin.Password, user.Password))
                    {
                        var token = _tokenManager.CreateTokenForSuperUser(user);
                        return Ok(token);
                    }
                }
            }
            return BadRequest("Email or password is invalid");
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> RegisterSuperUser([FromBody] SuperLoginDTO superLogin)
        {
            if (ModelState.IsValid)
            {
                superLogin.Password = BC.HashPassword(superLogin.Password);
                await _repository.Add(new SuperUser { Username = superLogin.Username, Password = superLogin.Password, Role = "Super Admin", Email = superLogin.Email });
                return Created("", "New Super User Created Sucessfully");
            }
            return BadRequest("Super user not added properly");
        }
    }
}
