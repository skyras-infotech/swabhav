using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Data.Repository;
using ContactEFCoreApp.ModelDTO;
using ContactApp.Domain;

namespace AddressEFCoreApp.Controllers
{
    [Route("api/v1/tenant/{tenantID}/user/{userID}/contact/{contactID}/[controller]")]
    [ApiController]
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
        public async Task<IActionResult> PostAddress([FromBody] AddressDTO contactDTO, Guid tenantID, Guid userID, Guid contactID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactID) == null)
                return BadRequest("Invalid user id");

            if (ModelState.IsValid)
            {
                await _repository.Add(new Address { City = contactDTO.City, ContactID = contactID });
                return Created("", "New Address Added Successfully");
            }
            return BadRequest("Address not added properly");

        }

        [HttpPut]
        [Route("{addressID}")]
        public async Task<ActionResult> PutAddress([FromBody] AddressDTO addressDTO, Guid tenantID, Guid userID, Guid contactID, Guid addressID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactID) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(addressID) == null)
                return BadRequest("Invalid address id");

            if (ModelState.IsValid)
            {
                Address address = await _repository.GetById(addressID);
                address.City = addressDTO.City;
                await _repository.Update(address);
                return Ok("Address Updated Successfully..");
            }
            return BadRequest("Address not updated properly");
        }

        [HttpDelete]
        [Route("{addressID}")]
        public async Task<ActionResult> DeleteContact(Guid tenantID, Guid userID, Guid contactID, Guid addressID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactID) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(addressID) == null)
                return BadRequest("Invalid address id");

            await _repository.Remove(await _repository.GetById(addressID));
            return Ok("Address Deleted Successfully..");
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAddresses(Guid tenantID, Guid userID, Guid contactID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactID) == null)
                return BadRequest("Invalid user id");

            return await _repository.GetWhere(x => x.ContactID == contactID && x.Contacts.UserID == userID && x.Contacts.User.TenantID == tenantID);
        }

        [HttpGet]
        [Route("{addressID}")]
        public async Task<ActionResult<Address>> GetAddress(Guid contactID, Guid userID, Guid tenantID, Guid addressID)
        {
            if (await _tenantRepo.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (await _userRepo.GetById(userID) == null)
                return BadRequest("Invalid user id");

            if (await _contactRepo.GetById(contactID) == null)
                return BadRequest("Invalid user id");

            if (await _repository.GetById(addressID) == null)
                return BadRequest("Invalid address id");

            return await _repository.FirstOrDefault(x => x.ID == addressID && x.ContactID == contactID && x.Contacts.UserID == userID && x.Contacts.User.TenantID == tenantID);
        }
    }
}
