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
    
    [ApiController]
    public class UserController : ControllerBase
    {
        private IContactRepository _repository;
        public UserController(IContactRepository contactRepository)
        {
            _repository = contactRepository;
        }

        [Route("api/v1/tenant/{tenantID}/[controller]")]
        [HttpPost]
        public IActionResult PostUser([FromBody] UserDTO userDTO,Guid tenantID)
        {
            _repository.AddUser(new User { UserName = userDTO.Username, Password = userDTO.Password, TenantID = tenantID });
            return Ok("New User Added Successfully");
        }

        [Route("api/v1/tenant/{tenantID}/[controller]")]
        [HttpGet]
        public List<User> GetUsers(Guid tenantID)
        {
            return _repository.GetUsers(tenantID).ToList();
        }

        [HttpGet]
        [Route("api/v1/tenant/{tenantID}/[controller]/{userID}")]
        public User GetUser(Guid tenantID, Guid userID)
        {
            return _repository.GetUser(tenantID,userID);
        }
    }
}
