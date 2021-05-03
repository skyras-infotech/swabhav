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
using ContactEFCoreApp.Token;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/v1/tenant/{tenantId:guid}/user/{userId:guid}/[controller]")]
    [ApiController]
    [JWTAuthorization]
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
        public async Task<ActionResult> PostContact([FromBody] ContactDTO contactDto, Guid userId, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (!ModelState.IsValid) return BadRequest("Contact not inserted properly");
            Contact contact = await _repository.FirstOrDefault(x => x.MobileNumber == contactDto.MobileNumber);
            if (contact != null) return BadRequest("Mobile number is already exist");
            await _repository.Add(new Contact { Name = contactDto.Name, MobileNumber = contactDto.MobileNumber, UserId = userId, IsFavorite = contactDto.IsFavorite });
            return Created("", "New Contact Added Successfully");

        }

        [HttpPut]
        [Route("{contactId:guid}")]
        public async Task<ActionResult> PutContact([FromBody] ContactDTO contactDto, Guid contactId, Guid userId, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(contactId) == null)
                return BadRequest("Invalid contact id");

            if (!ModelState.IsValid) return BadRequest("Contact not updated properly");
            Contact contact = await _repository.GetById(contactId);
            contact.Name = contactDto.Name;
            contact.MobileNumber = contactDto.MobileNumber;
            contact.IsFavorite = contactDto.IsFavorite;
            await _repository.Update(contact);
            return Ok("Contact Updated Successfully..");
        }

        [HttpDelete]
        [Route("{contactId:guid}")]
        public async Task<ActionResult> DeleteContact(Guid contactId, Guid userId, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(contactId) == null)
                return BadRequest("Invalid contact id");

            await _repository.Remove(await _repository.GetById(contactId));
            return Ok("Contact Deleted Successfully..");
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContacts(Guid tenantId, Guid userId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            return await _repository.GetWhere(x => x.User.TenantId == tenantId && x.UserId == userId);
        }

        [HttpGet]
        [Route("favorite-list")]
        public async Task<ActionResult<List<Contact>>> GetFavoriteContacts(Guid tenantId, Guid userId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            return await _repository.GetWhere(x => x.User.TenantId == tenantId && x.UserId == userId && x.IsFavorite == true);
        }

        [HttpGet]
        [Route("{contactId:guid}")]
        public async Task<ActionResult<Contact>> GetContact(Guid contactId, Guid userId, Guid tenantId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(contactId) == null)
                return BadRequest("Invalid contact id");

            return await _repository.FirstOrDefault(x => x.User.TenantId == tenantId && x.UserId == userId && x.Id == contactId);
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
