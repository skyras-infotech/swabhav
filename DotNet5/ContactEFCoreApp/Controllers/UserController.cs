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
    [Route("api/v1/tenant/{tenantID}/[controller]")]
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
        public async Task<ActionResult> PostUser([FromBody] UserDTO userDTO, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (ModelState.IsValid)
            {
                User user = await _repository.FirstOrDefault(x => x.Email == userDTO.Email);
                if (user == null)
                {
                    userDTO.Password = BC.HashPassword(userDTO.Password);
                    await _repository.Add(new User { Username = userDTO.Username, Password = userDTO.Password, Email = userDTO.Email, TenantID = tenantID, Role = userDTO.Role });
                    return Created("", "New User Added Successfully");
                }
                else
                {
                    return BadRequest("Email id is already exist");
                }
            }
            return BadRequest("User is not added properly");
        }

        [HttpPut]
        [Route("{userID}")]
        [JWTAuthorization]
        public async Task<ActionResult> PutUser([FromBody] UserDTO userDTO, Guid userID, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _repository.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (ModelState.IsValid)
            {
                userDTO.Password = BC.HashPassword(userDTO.Password);
                User user = await _repository.GetById(userID);
                user.Username = userDTO.Username;
                user.Password = userDTO.Password;
                user.Role = userDTO.Role;
                user.Email = userDTO.Email;
                await _repository.Update(user);
                return Ok("User Updated Successfully..");
            }
            return BadRequest("User not updated properly");
        }

        [HttpDelete]
        [Route("{userID}")]
        [JWTAuthorization]
        public async Task<ActionResult> DeleteUser(Guid userID, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _repository.GetById(userID) == null)
                return BadRequest("Invalid user id");

            await _repository.Remove(await _repository.GetById(userID));
            return Ok("User Deleted Successfully..");
        }

        [HttpGet]
        [JWTAuthorization]
        public async Task<ActionResult<List<User>>> GetUsers(Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            return await _repository.GetAllWithPreloadWhere(x => x.TenantID == tenantID,"Contacts");
        }

        [HttpGet]
        [Route("{userID}")]
        [JWTAuthorization]
        public async Task<ActionResult<User>> GetUser(Guid tenantID, Guid userID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _repository.GetById(userID) == null)
                return BadRequest("Invalid user id");

            return await _repository.FirstOrDefault(x => x.ID == userID && x.TenantID == tenantID);
        }

        [HttpPost]
        [Route("loginIsUnique")]
        public async Task<ActionResult<User>> UserLogin([FromBody] LoginDTO loginDTO, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (ModelState.IsValid)
            {
                User user = await _repository.FirstOrDefault(x => x.Email == loginDTO.Email && x.TenantID == tenantID);
                if (user != null)
                {
                    if (BC.Verify(loginDTO.Password, user.Password))
                    {
                        var token = _tokenManager.CreateToken(user); 
                        return Ok(token);
                    }
                }
            }
            return BadRequest("Email or password is invalid");
        }

        [HttpGet]
        [Route("NoOfUsers")]
        [JWTAuthorization]
        public async Task<ActionResult<int>> GetCountOfUsers(Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            return await _repository.CountWhere(x => x.TenantID == tenantID);
        }

        [HttpGet]
        [Route("NoOfUsersContacts")]
        [JWTAuthorization]
        public async Task<ActionResult<int>> GetCountOfUsersContacts(Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            List<User> users = await _repository.GetAllWithPreloadWhere(x => x.TenantID == tenantID, "Contacts");
            int count = 0;
            foreach (var user in users)
            {
                foreach (var contact in user.Contacts)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
