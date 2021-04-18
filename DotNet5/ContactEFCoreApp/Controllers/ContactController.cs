using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Domain;
using ContactApp.Data;
using ContactApp.Data.Repository;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository _contactRepository) 
        {
            this._contactRepository = _contactRepository;
        }

        [HttpGet]
        public List<Contact> GetStudents()
        {
            return _contactRepository.GetContactsWithAddress();
        }
    }
}
