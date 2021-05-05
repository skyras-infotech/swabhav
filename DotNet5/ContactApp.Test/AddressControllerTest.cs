using ContactApp.Data.Repository;
using ContactApp.Domain;
using ContactEFCoreApp.Controllers;
using ContactEFCoreApp.ModelDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace ContactApp.Test
{
    public class AddressControllerTest
    {
        private readonly AddressController _addressController;
        private readonly Mock<IContactRepository<Address>> _addressMock = new();
        private readonly Mock<IContactRepository<Contact>> _contactMock = new();
        private readonly Mock<IContactRepository<User>> _userMock = new();
        private readonly Mock<IContactRepository<Tenant>> _tenantMock = new();

        public AddressControllerTest()
        {
            _addressController = new AddressController(_addressMock.Object, _contactMock.Object, _userMock.Object,
                _tenantMock.Object);
        }

        [Fact]
        public async Task GetAddresses_ShouldReturnAddressList()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactId = Guid.NewGuid();
            var addresses = new List<Address>();
            var tenant = new Tenant();
            var user = new User();
            var contact = new Contact();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.GetById(contactId)).ReturnsAsync(contact);
            _addressMock.Setup(x => x.GetWhere(y =>
                    y.ContactId == contactId && y.Contacts.UserId == userId && y.Contacts.User.TenantId == tenantId))
                .ReturnsAsync(addresses);

            //Act
            var addressesList = await _addressController.GetAddresses(tenantId, userId, contactId);

            //Assert
            Assert.Equal(addresses, addressesList.Value);
        }

        [Fact]
        public async Task PostUser_ShouldReturnNewUser()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactId = Guid.NewGuid();
            var addressDto = new AddressDTO()
            {
                City = "Navsari"
            };
            var tenant = new Tenant();
            var user = new User();
            var contact = new Contact();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.GetById(contactId)).ReturnsAsync(contact);
            _addressMock.Setup(x => x.Add(new Address { City = addressDto.City, ContactId = contactId }));

            //Act
            var address = await _addressController.PostAddress(addressDto, tenantId, userId, contactId);

            //Assert
            Assert.IsType<CreatedResult>(address);
        }

        [Fact]
        public async Task PostAddress_ShouldReturnBadRequest()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactId = Guid.NewGuid();
            var addressDto = new AddressDTO();
            var tenant = new Tenant();
            var user = new User();
            var contact = new Contact();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.GetById(contactId)).ReturnsAsync(contact);
            _addressMock.Setup(x => x.Add(new Address { City = addressDto.City, ContactId = contactId }));
            _addressController.ModelState.AddModelError("City", "City is Required");

            //Act
            var address = await _addressController.PostAddress(addressDto, tenantId, userId, contactId);

            //Assert
            Assert.IsType<BadRequestObjectResult>(address);
        }

        [Fact]
        public async Task GetAddress_ShouldReturnOneAddress()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactId = Guid.NewGuid();
            var addressId = Guid.NewGuid();
            var address = new Address();
            var tenant = new Tenant();
            var user = new User();
            var contact = new Contact();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.GetById(contactId)).ReturnsAsync(contact);
            _addressMock.Setup(x => x.GetById(addressId)).ReturnsAsync(address);
            _addressMock.Setup(x => x.FirstOrDefault(y =>
                y.Id == addressId && y.ContactId == contactId && y.Contacts.UserId == userId &&
                y.Contacts.User.TenantId == tenantId)).ReturnsAsync(address);

            //Act
            var address1 = await _addressController.GetAddress(contactId, userId, tenantId, addressId);

            //Assert
            Assert.Equal(address, address1.Value);
        }
    }
}
