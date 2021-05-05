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
    public class ContactControllerTest
    {
        private readonly ContactController _contactController;
        private readonly Mock<IContactRepository<Contact>> _contactMock = new();
        private readonly Mock<IContactRepository<User>> _userMock = new();
        private readonly Mock<IContactRepository<Tenant>> _tenantMock = new();

        public ContactControllerTest()
        {
            _contactController = new ContactController(_contactMock.Object, _userMock.Object, _tenantMock.Object);
        }

        [Fact]
        public async Task GetContacts_ShouldReturnContactList()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contacts = new List<Contact>();
            var tenant = new Tenant();
            var user = new User();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.GetWhere(y => y.User.TenantId == tenantId && y.UserId == userId)).ReturnsAsync(contacts);

            //Act
            var contactList = await _contactController.GetContacts(tenantId, userId);

            //Assert
            Assert.Equal(contacts, contactList.Value);
        }

        [Fact]
        public async Task PostUser_ShouldReturnNewUser()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactDto = new ContactDTO()
            {
                Name = "Ravi Singh",
                MobileNumber = 9646959155
            };
            var tenant = new Tenant();
            var user = new User();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.Add(new Contact { MobileNumber = contactDto.MobileNumber, Name = contactDto.Name, UserId = userId }));

            //Act
            var contact = await _contactController.PostContact(contactDto, userId, tenantId);

            //Assert
            Assert.IsType<CreatedResult>(contact);
        }

        [Fact]
        public async Task PostContact_ShouldReturnBadRequest()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactDto = new ContactDTO()
            {
                Name = "Ravi Singh",
                MobileNumber = 9646959155
            };
            var tenant = new Tenant();
            var user = new User();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.Add(new Contact { Name = contactDto.Name, UserId = userId }));
            _contactController.ModelState.AddModelError("MobileNumber", "Mobile Number is Required");

            //Act
            var contact = await _contactController.PostContact(contactDto, userId, tenantId);

            //Assert
            Assert.IsType<BadRequestObjectResult>(contact);
        }

        [Fact]
        public async Task GetContact_ShouldReturnOneContact()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var contactId = Guid.NewGuid();
            var contact = new Contact();
            var tenant = new Tenant();
            var user = new User();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _contactMock.Setup(x => x.GetById(contactId)).ReturnsAsync(contact);
            _contactMock.Setup(x => x.FirstOrDefault(x => x.User.TenantId == tenantId && x.UserId == userId && x.Id == contactId)).ReturnsAsync(contact);

            //Act
            var contact1 = await _contactController.GetContact(contactId, userId, tenantId);

            //Assert
            Assert.Equal(contact, contact1.Value);
        }
    }
}
