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
    /*[Route("api/v1/tenant/{tenantID}/user/{userID}/contact/{contactID}/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IContactRepository _repository;
        public AddressController(IContactRepository _contactRepository)
        {
            this._repository = _contactRepository;
        }

        [HttpPost]
        public IActionResult PostAddress([FromBody] AddressDTO contactDTO, Guid tenantID, Guid userID, Guid contactID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            if (ModelState.IsValid)
            {
                _repository.AddAddress(new Address { City = contactDTO.City, ContactID = contactID });
                return Created("", "New Address Added Successfully");
            }
            return BadRequest("Address not added properly");

        }

        [HttpPut]
        [Route("{addressID}")]
        public ActionResult PutAddress([FromBody] AddressDTO addressDTO, Guid tenantID, Guid userID, Guid contactID, Guid addressID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            if (!_repository.DoesAddressExist(addressID))
                return BadRequest("Invalid address id");

            if (ModelState.IsValid)
            {
                _repository.UpdateAddress(new Address { City = addressDTO.City }, addressID);
                return Ok("Address Updated Successfully..");
            }
            return BadRequest("Address not updated properly");
        }

        [HttpDelete]
        [Route("{addressID}")]
        public ActionResult DeleteContact(Guid tenantID, Guid userID, Guid contactID, Guid addressID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            if (!_repository.DoesAddressExist(addressID))
                return BadRequest("Invalid address id");

            _repository.DeleteAddress(addressID);
            return Ok("Address Deleted Successfully..");
        }

        [HttpGet]
        public ActionResult<List<Address>> GetAddresses(Guid tenantID, Guid userID, Guid contactID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            return _repository.GetAddresses(tenantID, userID, contactID).ToList();
        }

        [HttpGet]
        [Route("{addressID}")]
        public ActionResult<Address> GetAddress(Guid contactID, Guid userID, Guid tenantID, Guid addressID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            if (!_repository.DoesAddressExist(addressID))
                return BadRequest("Invalid address id");

            return _repository.GetAddress(addressID, tenantID, userID, contactID);
        }
    }*/
}
