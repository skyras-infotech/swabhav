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
            if (ModelState.IsValid)
            {

                Tenant tenant = new Tenant { TenantName = tenantDTO.TenantName, CompanyStrength = tenantDTO.CompanyStrength };
                _repository.AddTenent(tenant);
                return Ok(tenant);

            }
            return BadRequest("Tenant not added properly");
        }

        [HttpPut]
        [Route("{tenantID}")]
        public ActionResult PutTenant([FromBody] TenantDTO tenantDTO, Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            if (ModelState.IsValid)
            {
                _repository.UpdateTenant(new Tenant { TenantName = tenantDTO.TenantName, CompanyStrength = tenantDTO.CompanyStrength }, tenantID);
                return Ok("Tenant Updated Successfully..");
            }
            return BadRequest("Tenant not updated properly");
        }

        [HttpDelete]
        [Route("{tenantID}")]
        public ActionResult DeleteTenant(Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            _repository.DeleteTenant(tenantID);
            return Ok("Tenant Deleted Successfully..");
        }

        [HttpGet]
        public ActionResult<List<Tenant>> GetTenants()
        {
            return _repository.GetTenants().ToList();
        }

        [HttpGet]
        [Route("tenantName/{tenantName}")]
        public ActionResult<Tenant> GetTenant(string tenantName)
        {
            Tenant tenant = _repository.GetTenantByName(tenantName);
            if (tenant != null)
            {
                return Ok(tenant);
            }
            else
            {
                return BadRequest("Company not exist");
            }
        }

        [HttpGet]
        [Route("CheckTenantExistance/{tenantName}")]
        public ActionResult<Tenant> CheckTenantExistance(string tenantName)
        {
            Tenant tenant = _repository.GetTenantByName(tenantName);
            if (tenant != null)
            {
                return BadRequest("Company already exist");
            }
            else
            {
                return Ok();
            }
        }

        [HttpGet]
        [Route("{tenantID}")]
        public ActionResult<Tenant> GetTenant(Guid tenantID)
        {
            if (!_repository.DoesTenantExist(tenantID))
                return BadRequest("Invalid tenant id");

            return _repository.GetTenant(tenantID);
        }
    }
}
