using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Data.Repository;
using ContactEFCoreApp.ModelDTO;
using ContactApp.Domain;
using BC = BCrypt.Net.BCrypt;
using ContactEFCoreApp.Token;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/v1/tenant/{tenantId:guid}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IContactRepository<User> _repository;
        private readonly IContactRepository<Tenant> _tenantRepo;
        private readonly ICustomTokenManager _tokenManager;
        public UserController(ICustomTokenManager tokenManager,IContactRepository<User> contactRepository, IContactRepository<Tenant> tenantRepo)
        {
            _repository = contactRepository;
            _tenantRepo = tenantRepo;
            _tokenManager = tokenManager;
        }

        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] UserDTO userDto, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (!ModelState.IsValid) return BadRequest("User is not added properly");
            User user = await _repository.FirstOrDefault(x => x.Email == userDto.Email);
            if (user != null) return BadRequest("Email id is already exist");
            userDto.Password = BC.HashPassword(userDto.Password);
            await _repository.Add(new User { Username = userDto.Username, Password = userDto.Password, Email = userDto.Email, TenantId = tenantId, Role = userDto.Role });
            return Created("", "New User Added Successfully");
        }

        [HttpPut]
        [Route("{userId:guid}")]
        [JWTAuthorization]
        public async Task<ActionResult> PutUser([FromBody] UserDTO userDto, Guid userId, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _repository.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (!ModelState.IsValid) return BadRequest("User not updated properly");
            userDto.Password = BC.HashPassword(userDto.Password);
            User user = await _repository.GetById(userId);
            user.Username = userDto.Username;
            user.Password = userDto.Password;
            user.Role = userDto.Role;
            user.Email = userDto.Email;
            await _repository.Update(user);
            return Ok("User Updated Successfully..");
        }

        [HttpDelete]
        [Route("{userId:guid}")]
        [JWTAuthorization(Role = "Admin")]
        public async Task<ActionResult> DeleteUser(Guid userId, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _repository.GetById(userId) == null)
                return BadRequest("Invalid user id");

            await _repository.Remove(await _repository.GetById(userId));
            return Ok("User Deleted Successfully..");
        }

        [HttpGet]
        [JWTAuthorization(Role = "Admin")]
        public async Task<ActionResult<List<User>>> GetUsers(Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            return await _repository.GetAllWithPreloadWhere(x => x.TenantId == tenantId,"Contacts");
        }

        [HttpGet]
        [Route("{userId:guid}")]
        [JWTAuthorization(Role = "Admin")]
        public async Task<ActionResult<User>> GetUser(Guid tenantId, Guid userId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _repository.GetById(userId) == null)
                return BadRequest("Invalid user id");

            return await _repository.FirstOrDefault(x => x.Id == userId && x.TenantId == tenantId);
        }

        [HttpPost]
        [Route("loginIsUnique")]
        public async Task<ActionResult<User>> UserLogin([FromBody] LoginDTO loginDto, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (!ModelState.IsValid) return BadRequest("Email or password is invalid");
            User user = await _repository.FirstOrDefault(x => x.Email == loginDto.Email && x.TenantId == tenantId);
            if (user == null) return BadRequest("Email or password is invalid");
            if (!BC.Verify(loginDto.Password, user.Password)) return BadRequest("Email or password is invalid");
            var token = _tokenManager.CreateToken(user); 
            return Ok(token);
        }

        [HttpGet]
        [Route("NoOfUsers")]
        [JWTAuthorization(Role = "Admin")]
        public async Task<ActionResult<int>> GetCountOfUsers(Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            return await _repository.CountWhere(x => x.TenantId == tenantId);
        }

        [HttpGet]
        [Route("NoOfUsersContacts")]
        [JWTAuthorization(Role = "Admin")]
        public async Task<ActionResult<int>> GetCountOfUsersContacts(Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            List<User> users = await _repository.GetAllWithPreloadWhere(x => x.TenantId == tenantId, "Contacts");
            return users.SelectMany(user => user.Contacts).Count();
        }
    }
}
