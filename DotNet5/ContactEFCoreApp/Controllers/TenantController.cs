using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Data.Repository;
using ContactEFCoreApp.ModelDTO;
using ContactApp.Domain;
using ContactEFCoreApp.Token;

namespace ContactEFCoreApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly IContactRepository<Tenant> _repository;
        public TenantController(IContactRepository<Tenant> contactRepository)
        {
            _repository = contactRepository;
        }

        [HttpPost]
        public async Task<ActionResult> PostTenant([FromBody] TenantDTO tenantDTO)
        {
            if (ModelState.IsValid)
            {
                Tenant tenant = new Tenant { TenantName = tenantDTO.TenantName, CompanyStrength = tenantDTO.CompanyStrength };
                await _repository.Add(tenant);
                return Ok(tenant);
            }
            return BadRequest("Tenant not added properly");
        }

        [HttpPut]
        [Route("{tenantID}")]
        public async Task<ActionResult> PutTenant([FromBody] TenantDTO tenantDTO, Guid tenantID)
        {
            if (await _repository.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            if (ModelState.IsValid)
            {
                Tenant tenant = await _repository.GetById(tenantID);
                tenant.TenantName = tenantDTO.TenantName;
                tenant.CompanyStrength = tenantDTO.CompanyStrength;
                await _repository.Update(tenant);
                return Ok("Tenant Updated Successfully..");
            }
            return BadRequest("Tenant not updated properly");
        }

        [HttpDelete]
        [Route("{tenantID}")]
        [JWTAuthorization]
        public async Task<ActionResult> DeleteTenant(Guid tenantID)
        {
            if (await _repository.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            await _repository.Remove(await _repository.GetById(tenantID));
            return Ok("Tenant Deleted Successfully..");
        }

        [HttpGet]
        [JWTAuthorization]
        public async Task<List<Tenant>> GetTenants()
        {
            return await _repository.GetAllWithPreload("Users");
        }

        [HttpGet]
        [Route("tenantName/{tenantName}")]
        public async Task<ActionResult<Tenant>> GetTenant(string tenantName)
        {
            Tenant tenant = await _repository.FirstOrDefault(x => x.TenantName == tenantName);
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
        public async Task<ActionResult<Tenant>> CheckTenantExistance(string tenantName)
        {
            Tenant tenant = await _repository.FirstOrDefault(x => x.TenantName == tenantName);
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
        public async Task<ActionResult<Tenant>> GetTenant(Guid tenantID)
        {
            if (await _repository.GetById(tenantID) == null)
                return BadRequest("Invalid tenant id");

            return await _repository.GetById(tenantID);
        }
    }
}
