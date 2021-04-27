using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Domain;
using ContactApp.Data;
using ContactApp.Data.Repository;
using ContactEFCoreApp.ModelDTO;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/v1/tenant/{tenantID}/user/{userID}/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository<Contact> _repository;
        private readonly IContactRepository<User> _userRepo;
        private readonly IContactRepository<Tenant> _tenantRepo;
        public ContactController(IContactRepository<Contact> contactRepository, IContactRepository<User> userRepository, IContactRepository<Tenant> tenantRepository)
        {
            _repository = contactRepository;
            _userRepo = userRepository;
            _tenantRepo = tenantRepository;
        }

        [HttpPost]
        public async Task<ActionResult> PostContact([FromBody] ContactDTO contactDTO, Guid userID, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (ModelState.IsValid)
            {
                Contact contact = await _repository.FirstOrDefault(x => x.MobileNumber == contactDTO.MobileNumber);
                if (contact == null)
                {
                    await _repository.Add(new Contact { Name = contactDTO.Name, MobileNumber = contactDTO.MobileNumber, UserID = userID });
                    return Created("", "New Contact Added Successfully");
                }
                else 
                {
                    return BadRequest("Mobile number is already exist");
                }
            }
            return BadRequest("Contact not inserted properly");
        }

        [HttpPut]
        [Route("{contactID}")]
        public async Task<ActionResult> PutContact([FromBody] ContactDTO contactDTO, Guid contactID, Guid userID, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(contactID) == null)
                return BadRequest("Invalid contact id");

            if (ModelState.IsValid)
            {
                await _repository.Update(new Contact { ID = contactID, Name = contactDTO.Name, MobileNumber = contactDTO.MobileNumber });
                return Ok("Contact Updated Successfully..");
            }
            return BadRequest("Contact not updated properly");
        }

        [HttpDelete]
        [Route("{contactID}")]
        public async Task<ActionResult> DeleteContact(Guid contactID, Guid userID, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(contactID) == null)
                return BadRequest("Invalid contact id");

            await _repository.Remove(await _repository.GetById(contactID));
            return Ok("Contact Deleted Successfully..");
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContacts(Guid tenantID, Guid userID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            return await _repository.GetWhere(x => x.User.TenantID == tenantID && x.UserID == userID);
        }

        [HttpGet]
        [Route("{contactID}")]
        public async Task<ActionResult<Contact>> GetContact(Guid contactID, Guid userID, Guid tenantID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(contactID) == null)
                return BadRequest("Invalid contact id");

            return await _repository.FirstOrDefault(x => x.User.TenantID == tenantID && x.UserID == userID && x.ID == contactID);
        }


       /* private BadRequestObjectResult DoesUserAndTenantExist(Guid tenantID, Guid userID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            return null;
        }*/
    }
}
