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
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private IContactRepository _repository;
        public TenantController(IContactRepository contactRepository) 
        {
            _repository = contactRepository;
        }

        [HttpPost]
        public IActionResult PostTenant([FromBody] TenantDTO tenantDTO) 
        {
            _repository.AddTenent(new Tenant { TenantName = tenantDTO.TenantName});
            return Ok("New Tenant Added Successfully");
        }

        [HttpGet]
        public List<Tenant> GetTenants()
        {
            return _repository.GetTenants().ToList();
        }

        [HttpGet]
        [Route("api/v1/[controller]/tenant/{tenantID:Guid}")]
        public Tenant GetTenant(Guid tenantID)
        {
            return _repository.GetTenant(tenantID);
        }
    }
}
