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
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _repository;
        public ContactController(IContactRepository _contactRepository)
        {
            this._repository = _contactRepository;
        }

        [Route("api/v1/tenant/{tenantID}/user/{userID}/[controller]")]
        [HttpPost]
        public IActionResult PostContact([FromBody] ContactDTO contactDTO, Guid userID)
        {
            _repository.AddContact(new Contact { Name = contactDTO.Name, MobileNumber = contactDTO.MobileNumber, UserID = userID });
            return Ok("New Contact Added Successfully");
        }

        [Route("api/v1/tenant/{tenantID}/user/{userID}/[controller]")]
        [HttpGet]
        public List<Contact> GetContacts(Guid tenantID,Guid userID)
        {
            return _repository.GetContacts(tenantID,userID).ToList();
        }

        [HttpGet]
        [Route("api/v1/tenant/{tenantID}/user/{userID}/[controller]/{contactID}")]
        public Contact GetContact(Guid contactID, Guid userID,Guid tenantID)
        {
            return _repository.GetContact(contactID, tenantID, userID);
        }
    }
}
