using System;
using Xunit;
using ContactApp.Data.Repository;
using ContactEFCoreApp.Controllers;
using Moq;
using ContactApp.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;
using ContactEFCoreApp.ModelDTO;
using Microsoft.AspNetCore.Mvc;

namespace ContactApp.Test
{
    public class TenantControllerTest
    {
        private readonly TenantController _tenantController;
        private readonly Mock<IContactRepository<Tenant>> _tenantMock = new();

        public TenantControllerTest()
        {
            _tenantController = new TenantController(_tenantMock.Object);
        }

        [Fact]
        public async Task GetTenants_ShouldReturnTenantList()
        {
            //Arrange
            var preload = "Users";
            var tenants = new List<Tenant>();
            _tenantMock.Setup(x => x.GetAllWithPreload(preload)).ReturnsAsync(tenants);

            //Act
            var tenantList =  await _tenantController.GetTenants();

            //Assert
            Assert.Equal(tenantList.Count, tenants.Count);
        }

        [Fact]
        public async Task PostTenant_ShouldReturnNewTenant()
        {
            //Arrange
            var tenantDto = new TenantDTO 
            { 
                TenantName = "Swabhav",
                CompanyStrength = 65
            };
            _tenantMock.Setup(x => x.Add(new Tenant
                {TenantName = tenantDto.TenantName, CompanyStrength = tenantDto.CompanyStrength}));

            //Act
            var tenant = await _tenantController.PostTenant(tenantDto);
            
            //Assert
            Assert.IsType<OkObjectResult>(tenant);
        }

        [Fact]
        public async Task PostTenant_ShouldReturnBadRequest()
        {
            //Arrange
            var tenantDto = new TenantDTO
            {
                CompanyStrength = 65
            };
            _tenantController.ModelState.AddModelError("TenantName", "Company Name Required");

            //Act
            var tenant1 = await _tenantController.PostTenant(tenantDto);

            //Assert
            Assert.IsType<BadRequestObjectResult>(tenant1);
        }

        [Fact]
        public async Task GetTenant_ShouldReturnOneTenant()
        {
            //Arrange
            var tenant = new Tenant();
            var tenantId = Guid.NewGuid();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _tenantMock.Setup(x => x.FirstOrDefault(y => y.Id == tenantId)).ReturnsAsync(tenant);

            //Act
            var tenant1 = await _tenantController.GetTenant(tenantId);

            //Assert
            Assert.Equal(tenant,tenant1.Value);
        }
    }
}
