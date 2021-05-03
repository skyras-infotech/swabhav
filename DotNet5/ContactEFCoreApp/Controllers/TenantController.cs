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
        public async Task<ActionResult> PostTenant([FromBody] TenantDTO tenantDto)
        {
            if (!ModelState.IsValid) return BadRequest("Tenant not added properly");
            Tenant tenant = new Tenant { TenantName = tenantDto.TenantName, CompanyStrength = tenantDto.CompanyStrength };
            await _repository.Add(tenant);
            return Ok(tenant);
        }

        [HttpPut]
        [Route("{tenantId:guid}")]
        public async Task<ActionResult> PutTenant([FromBody] TenantDTO tenantDto, Guid tenantId)
        {
            if (await _repository.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            if (!ModelState.IsValid) return BadRequest("Tenant not updated properly");
            Tenant tenant = await _repository.GetById(tenantId);
            tenant.TenantName = tenantDto.TenantName;
            tenant.CompanyStrength = tenantDto.CompanyStrength;
            await _repository.Update(tenant);
            return Ok("Tenant Updated Successfully..");
        }

        [HttpDelete]
        [Route("{tenantId:guid}")]
        [JWTAuthorization(Role = "Super Admin")]
        public async Task<ActionResult> DeleteTenant(Guid tenantId)
        {
            if (await _repository.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            await _repository.Remove(await _repository.GetById(tenantId));
            return Ok("Tenant Deleted Successfully..");
        }

        [HttpGet]
        [JWTAuthorization(Role = "Super Admin")]
        public async Task<List<Tenant>> GetTenants()
        {
            return await _repository.GetAllWithPreload("Users");
        }

        [HttpGet]
        [Route("tenantName/{tenantName}")]
        public async Task<ActionResult<Tenant>> GetTenant(string tenantName)
        {
            Tenant tenant = await _repository.FirstOrDefault(x => x.TenantName == tenantName);
            return tenant != null ? Ok(tenant) : BadRequest("Company not exist");
        }

        [HttpGet]
        [Route("CheckTenantExistence/{tenantName}")]
        public async Task<ActionResult<Tenant>> CheckTenantExistence(string tenantName)
        {
            Tenant tenant = await _repository.FirstOrDefault(x => x.TenantName == tenantName);
            return tenant != null ? (ActionResult<Tenant>) BadRequest("Company already exist") : Ok();
        }

        [HttpGet]
        [Route("{tenantId:guid}")]
        public async Task<ActionResult<Tenant>> GetTenant(Guid tenantId)
        {
            if (await _repository.GetById(tenantId) == null)
                return BadRequest("Invalid tenant id");

            return await _repository.GetById(tenantId);
        }
    }
}
