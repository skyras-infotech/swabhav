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
        private readonly IContactRepository _repository;
        public ContactController(IContactRepository _contactRepository)
        {
            this._repository = _contactRepository;
        }

        [HttpPost]
        public ActionResult PostContact([FromBody] ContactDTO contactDTO, Guid userID, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID)) 
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (ModelState.IsValid)
            {
                _repository.AddContact(new Contact { Name = contactDTO.Name, MobileNumber = contactDTO.MobileNumber, UserID = userID });
                return Created("","New Contact Added Successfully");
            }
            return BadRequest("Contact not inserted properly");
        }

        [HttpPut]
        [Route("{contactID}")]
        public ActionResult PutContact([FromBody] ContactDTO contactDTO, Guid contactID, Guid userID, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");


            if (ModelState.IsValid)
            {
                _repository.UpdateContact(new Contact { Name = contactDTO.Name, MobileNumber = contactDTO.MobileNumber }, contactID);
                return Ok("Contact Updated Successfully..");
            }
            return BadRequest("Contact not updated properly");
        }

        [HttpDelete]
        [Route("{contactID}")]
        public ActionResult DeleteContact(Guid contactID, Guid userID, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            _repository.DeleteContact(contactID);
            return Ok("Contact Deleted Successfully..");
        }

        [HttpGet]
        public ActionResult<List<Contact>> GetContacts(Guid tenantID, Guid userID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            return _repository.GetContacts(tenantID, userID).ToList();
        }

        [HttpGet]
        [Route("{contactID}")]
        public ActionResult<Contact> GetContact(Guid contactID, Guid userID, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (!_repository.DoesUserExist(userID))
                return BadRequest("Invalid user id");

            if (!_repository.DoesContactExist(contactID))
                return BadRequest("Invalid contact id");

            return _repository.GetContact(contactID, tenantID, userID);
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
