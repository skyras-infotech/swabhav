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
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IContactRepository _repository;
        public AddressController(IContactRepository _contactRepository)
        {
            this._repository = _contactRepository;
        }

        [Route("api/v1/tenant/{tenantID}/user/{userID}/contact/{contactID}/[controller]")]
        [HttpPost]
        public IActionResult PostAddress([FromBody] AddressDTO contactDTO, Guid contactID)
        {
            _repository.AddAddress(new Address { City = contactDTO.City,ContactID = contactID});
            return Ok("New Address Added Successfully");
        }

        [Route("api/v1/tenant/{tenantID}/user/{userID}/contact/{contactID}/[controller]")]
        [HttpGet]
        public List<Address> GetAddresses(Guid tenantID, Guid userID,Guid contactID)
        {
            return _repository.GetAddresses(tenantID, userID, contactID).ToList();
        }

        [HttpGet]
        [Route("api/v1/tenant/{tenantID}/user/{userID}/contact/{contactID}/[controller]/{addressID}")]
        public Address GetAddress(Guid contactID, Guid userID, Guid tenantID,Guid addressID)
        {
            return _repository.GetAddress(addressID, tenantID, userID,contactID);
        }
    }
}
