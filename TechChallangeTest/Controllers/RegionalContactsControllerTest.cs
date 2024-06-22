using Core.Entities;
using Core.Errors;
using Core.InputDtos;
using Core.OutputDtos;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TechChallange.Controllers;

namespace TechChallangeTest.Controllers
{
    public class RegionalContactsControllerTest
    {
        private readonly Mock<IRegionalContactsRepository> _regionalContactsRepositoryMock = new();
        private readonly RegionalContactsController _controller;
        private readonly CreateContactInputDto _createContactList;
        private readonly UpdateContactInputDto _updateContactList;
        private readonly List<ContactOutputDto> _objectReturn;
        private readonly Regions _regions;
        private readonly Contacts _contacts;

        public RegionalContactsControllerTest()
        {
            _controller = new(_regionalContactsRepositoryMock.Object);
            _createContactList = new()
            {
                Name = "Joao",
                Email = "joao@teste.com",
                Ddd = 11,
                PhoneNumber = "99999-9999"
            };
            _updateContactList = new()
            {
                Id = 1,
                Ddd = 16,
                Email = "joao@teste.com",
                Name = "Joao",
                PhoneNumber = "99999-9999"
            };
            _objectReturn = new()
            {
                new() {
                    Id = 2,
                    Name =  "Joao",
                    Email =  "joao@teste.com",
                    Ddd =  11,
                    PhoneNumber = "99999-9999" 
                }
            };
            _regions = new() { Ddd = 11, RegionName = "São Paulo", Contacts = new List<Contacts>() };
            _contacts = new()
            {
                Id = 2,
                Name = "Joao",
                Email = "joao@teste.com",
                Region = _regions,
                PhoneNumber = "99999-9999"
            };

            _regions.Contacts.Add(_contacts);
        }

        [Fact]
        public void SearchAllContacts_ShouldBeReturnStatusCode200()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchAllContacts()).Returns(_objectReturn);

            //Act
            var result = _controller.SearchAllContacts();

            //Assert
            var resultContent = Assert.IsType<ObjectResult>(result);
            Assert.Equal(200, resultContent.StatusCode);
        }

        [Fact]
        public void SearchAllContacts_SearchAllContacts_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchAllContacts()).Throws(new Exception());

            //Act
            var result = _controller.SearchAllContacts();

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public void SearchContactsByRegion_ShouldBeReturnStatusCode200()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactByRegion(It.IsAny<int>())).Returns(_objectReturn);

            //Act
            var result = _controller.SearchContactsByRegion(16);

            //Assert
            var resultContent = Assert.IsType<ObjectResult>(result);
            Assert.Equal(200, resultContent.StatusCode);
        }

        [Fact]
        public void SearchContactsByRegion_SearchContactByRegion_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactByRegion(It.IsAny<int>())).Throws(new Exception());

            //Act
            var result = _controller.SearchContactsByRegion(50);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void CreateContact_ShouldBeReturnStatusCode201()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>())).Returns(_regions);
            _regionalContactsRepositoryMock.Setup(x =>
                x.CreateContact(It.IsAny<Contacts>()));

            //Act
            var result =await _controller.CreateContact(_createContactList);

            //Assert
            var resultContent = Assert.IsType<StatusCodeResult>(result);
            Assert.Equal(201, resultContent.StatusCode);
        }

        [Fact]
        public async void CreateContact_SearchRegionByDdd_ShouldBeFailWhenDddDoesNotExist()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>()))
                .Throws(new BadRequestException("O DDD informado não existe!"));

            //Act
            var result = await _controller.CreateContact(_createContactList);

            //Assert
            var resultContent = Assert.IsType<ObjectResult>(result);
            Assert.Equal(400, resultContent.StatusCode);
            Assert.Equal("O DDD informado não existe!", resultContent.Value);
        }

        [Fact]
        public async void CreateContact_SearchRegionByDdd_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>()))
                .Throws(new Exception());

            //Act
            var result = await _controller.CreateContact(_createContactList);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void CreateContact_CreateContact_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>())).Returns(_regions);
            _regionalContactsRepositoryMock.Setup(x =>
                x.CreateContact(It.IsAny<Contacts>())).Throws(new Exception());

            //Act
            var result = await _controller.CreateContact(_createContactList);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void UpdatedContact_ShouldBeReturnStatusCode204()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Returns(_contacts);
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>())).Returns(_regions);
            _regionalContactsRepositoryMock.Setup(x =>
                x.UpdateContact(It.IsAny<Contacts>()));

            //Act
            var result = await _controller.UpdateContact(_updateContactList);

            //Assert
            var resultContent = Assert.IsType<StatusCodeResult>(result);
            Assert.Equal(204, resultContent.StatusCode);
        }


        [Fact]
        public async void UpdatedContact_SearchContactById_ShouldBeFailWhenTheContactDoesNotExist()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>()))
                .Throws(new BadRequestException("O Contato Informado não existe"));
           
            //Act
            var result = await _controller.UpdateContact(_updateContactList);

            //Assert
            var resultContent = Assert.IsType<ObjectResult>(result);
            Assert.Equal(400, resultContent.StatusCode);
            Assert.Equal("O Contato Informado não existe", resultContent.Value);
        }

        [Fact]
        public async void UpdatedContact_SearchRegionByDdd_ShouldBeFailWhenTheContactDoesNotExist()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Returns(_contacts);
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>()))
                .Throws(new BadRequestException("O DDD informado não existe!"));

            //Act
            var result = await _controller.UpdateContact(_updateContactList);

            //Assert
            var resultContent = Assert.IsType<ObjectResult>(result);
            Assert.Equal(400, resultContent.StatusCode);
            Assert.Equal("O DDD informado não existe!", resultContent.Value);
        }

        [Fact]
        public async void UpdatedContact_UpdateContact_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Returns(_contacts);
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>())).Returns(_regions);
            _regionalContactsRepositoryMock.Setup(x =>
                x.UpdateContact(It.IsAny<Contacts>())).Throws(new Exception());

            //Act
            var result = await _controller.UpdateContact(_updateContactList);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void UpdatedContact_SearchRegionByDdd_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Returns(_contacts);
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchRegionByDdd(It.IsAny<int>())).Throws(new Exception());

            //Act
            var result = await _controller.UpdateContact(_updateContactList);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void UpdatedContact_SearchContactById_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Throws(new Exception());

            //Act
            var result = await _controller.UpdateContact(_updateContactList);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void DeleteContact_ShouldBeReturnStatusCode204()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Returns(_contacts);
            _regionalContactsRepositoryMock.Setup(x =>
                x.DeleteContact(It.IsAny<Contacts>()));

            //Act
            var result = await _controller.DeleteContact(1);

            //Assert
            var resultContent = Assert.IsType<StatusCodeResult>(result);
            Assert.Equal(204, resultContent.StatusCode);
        }

        [Fact]
        public async void DeleteContact_SearchContactById_ShouldBeFailWhenTheContactDoesNotExist()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>()))
                .Throws(new BadRequestException("O Contato Informado não existe"));

            //Act
            var result = await _controller.DeleteContact(1);

            //Assert
            var resultContent = Assert.IsType<ObjectResult>(result);
            Assert.Equal(400, resultContent.StatusCode);
            Assert.Equal("O Contato Informado não existe", resultContent.Value);
        }

        [Fact]
        public async void DeleteContact_SearchContactById_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Throws(new Exception());

            //Act
            var result = await _controller.DeleteContact(1);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async void DeleteContact_DeleteContact_ShouldBeFailWhenThereIsASystemicFailure()
        {
            //Arrange
            _regionalContactsRepositoryMock.Setup(x =>
                x.SearchContactById(It.IsAny<int>())).Returns(_contacts);
            _regionalContactsRepositoryMock.Setup(x =>
                x.DeleteContact(It.IsAny<Contacts>())).Throws(new Exception());

            //Act
            var result = await _controller.DeleteContact(1);

            //Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }
    }
}
