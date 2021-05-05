using ContactApp.Data.Repository;
using ContactApp.Domain;
using ContactEFCoreApp.ModelDTO;
using ContactEFCoreApp.Token;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/v1/tenant/{tenantId:guid}/user/{userId:guid}/contact/{contactId:guid}/[controller]")]
    [ApiController]
    [JWTAuthorization]
    public class AddressController : ControllerBase
    {
        private readonly IContactRepository<Address> _repository;
        private readonly IContactRepository<Contact> _contactRepo;
        private readonly IContactRepository<User> _userRepo;
        private readonly IContactRepository<Tenant> _tenantRepo;

        public AddressController(IContactRepository<Address> repository, IContactRepository<Contact> contactRepo, IContactRepository<User> userRepository, IContactRepository<Tenant> tenantRepository)
        {
            _repository = repository;
            _contactRepo = contactRepo;
            _userRepo = userRepository;
            _tenantRepo = tenantRepository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAddress([FromBody] AddressDTO contactDto, Guid tenantId, Guid userId, Guid contactId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactId) == null)
                return BadRequest("Invalid user id");

            if (!ModelState.IsValid) return BadRequest("Address not added properly");
            await _repository.Add(new Address { City = contactDto.City, ContactId = contactId });
            return Created("", "New Address Added Successfully");

        }

        [HttpPut]
        [Route("{addressId:guid}")]
        public async Task<ActionResult> PutAddress([FromBody] AddressDTO addressDto, Guid tenantId, Guid userId, Guid contactId, Guid addressId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactId) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(addressId) == null)
                return BadRequest("Invalid address id");

            if (!ModelState.IsValid) return BadRequest("Address not updated properly");
            Address address = await _repository.GetById(addressId);
            address.City = addressDto.City;
            await _repository.Update(address);
            return Ok("Address Updated Successfully..");
        }

        [HttpDelete]
        [Route("{addressId:guid}")]
        public async Task<ActionResult> DeleteContact(Guid tenantId, Guid userId, Guid contactId, Guid addressId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactId) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(addressId) == null)
                return BadRequest("Invalid address id");

            await _repository.Remove(await _repository.GetById(addressId));
            return Ok("Address Deleted Successfully..");
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAddresses(Guid tenantId, Guid userId, Guid contactId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactId) == null)
                return BadRequest("Invalid user id");

            return await _repository.GetWhere(x => x.ContactId == contactId && x.Contacts.UserId == userId && x.Contacts.User.TenantId == tenantId);
        }

        [HttpGet]
        [Route("{addressId:guid}")]
        public async Task<ActionResult<Address>> GetAddress(Guid contactId, Guid userId, Guid tenantId, Guid addressId)
        {
            if (await _tenantRepo.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userId) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactId) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(addressId) == null)
                return BadRequest("Invalid address id");

            return await _repository.FirstOrDefault(x => x.Id == addressId && x.ContactId == contactId && x.Contacts.UserId == userId && x.Contacts.User.TenantId == tenantId);
        }
    }
}
