using ContactApp.Data.Repository;
using ContactApp.Domain;
using ContactEFCoreApp.Controllers;
using ContactEFCoreApp.ModelDTO;
using ContactEFCoreApp.Token;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace ContactApp.Test
{
    public class UserControllerTest
    {
        private readonly UserController _userController;
        private readonly Mock<IContactRepository<User>> _userMock = new();
        private readonly Mock<ICustomTokenManager> _tokenManagerMock = new();
        private readonly Mock<IContactRepository<Tenant>> _tenantMock = new();

        public UserControllerTest()
        {
            _userController = new UserController(_tokenManagerMock.Object, _userMock.Object, _tenantMock.Object);
        }

        [Fact]
        public async Task GetUsers_ShouldReturnUserList()
        {

            //Arrange
            var tenantId = Guid.NewGuid();
            var preload = "Contacts";
            var users = new List<User>();
            var tenant = new Tenant();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetAllWithPreloadWhere(y => y.TenantId == tenantId, preload)).ReturnsAsync(users);

            //Act
            var userList = await _userController.GetUsers(tenantId);

            //Assert
            Assert.Equal(users, userList.Value);
        }

        [Fact]
        public async Task PostUser_ShouldReturnNewUser()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userDto = new UserDTO
            {
                Username = "Sumit Gupta",
                Email = "skgskg@gmail.com",
                Password = "123456",
                Role = "Admin"
            };
            var tenant = new Tenant();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.Add(new User { Username = userDto.Username, Email = userDto.Email, Password = userDto.Password, Role = userDto.Role, TenantId = tenantId }));

            //Act
            var user1 = await _userController.PostUser(userDto, tenantId);

            //Assert
            Assert.IsType<CreatedResult>(user1);
        }

        [Fact]
        public async Task PostUser_ShouldReturnBadRequest()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userDto = new UserDTO
            {
                Email = "skg@gmail.com",
                Password = "123456",
                Role = "Admin"
            };
            _userController.ModelState.AddModelError("Username", "User Name Required");

            //Act
            var user1 = await _userController.PostUser(userDto, tenantId);

            //Assert
            Assert.IsType<BadRequestObjectResult>(user1);
        }

        [Fact]
        public async Task GetUser_ShouldReturnOneUser()
        {
            //Arrange
            var tenantId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var user = new User();
            var tenant = new Tenant();
            _tenantMock.Setup(x => x.GetById(tenantId)).ReturnsAsync(tenant);
            _userMock.Setup(x => x.GetById(userId)).ReturnsAsync(user);
            _userMock.Setup(x => x.FirstOrDefault(y => y.Id == userId && y.TenantId == tenantId)).ReturnsAsync(user);

            //Act
            var user1 = await _userController.GetUser(tenantId, userId);

            //Assert
            Assert.Equal(user, user1.Value);
        }
    }
}
