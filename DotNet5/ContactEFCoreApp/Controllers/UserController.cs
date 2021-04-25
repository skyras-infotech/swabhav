using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Data.Repository;
using ContactEFCoreApp.ModelDTO;
using ContactApp.Domain;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/v1/tenant/{tenantID}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IContactRepository _repository;
        public UserController(IContactRepository contactRepository)
        {
            _repository = contactRepository;
        }

        [HttpPost]
        public ActionResult PostUser([FromBody] UserDTO userDTO, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (ModelState.IsValid)
            {
                _repository.AddUser(new User { Username = userDTO.Username, Password = userDTO.Password, Email = userDTO.Email, TenantID = tenantID, Role = userDTO.Role ?? "Admin" });
                return Created("", "New User Added Successfully");
            }
            return BadRequest("User is not added properly");
        }

        [HttpPut]
        [Route("{userID}")]
        public ActionResult PutUser([FromBody] UserDTO userDTO, Guid userID, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (ModelState.IsValid)
            {
                _repository.UpdateUser(new User { Username = userDTO.Username, Password = userDTO.Password }, userID);
                return Ok("User Updated Successfully..");
            }
            return BadRequest("User not updated properly");
        }

        [HttpDelete]
        [Route("{userID}")]
        public ActionResult DeleteUser(Guid userID, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            _repository.DeleteUser(userID);
            return Ok("User Deleted Successfully..");
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers(Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            return _repository.GetUsers(tenantID).ToList();
        }

        [HttpGet]
        [Route("{userID}")]
        public ActionResult<User> GetUser(Guid tenantID, Guid userID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            return _repository.GetUser(tenantID, userID);
        }

        [HttpPost]
        [Route("loginIsUnique")]
        public ActionResult<User> UserLogin([FromBody] LoginDTO loginDTO, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (ModelState.IsValid)
            {
                User user = _repository.LoginUser(loginDTO.Email, loginDTO.Password, tenantID);
                if (user != null)
                {
                    return Ok(user);
                }
            }
            return BadRequest("Email or password is invalid");
        }

        [HttpGet]
        [Route("NoOfUsers")]
        public ActionResult<int> GetCountOfUsers(Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            return _repository.GetNoOfUsers(tenantID);
        }

        [HttpGet]
        [Route("NoOfUsersContacts")]
        public ActionResult<int> GetCountOfUsersContacts(Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            List<User> users = _repository.GetUsers(tenantID).ToList();
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
