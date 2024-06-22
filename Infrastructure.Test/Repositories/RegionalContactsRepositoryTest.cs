using Core.Entities;
using Core.Errors;
using Core.OutputDtos;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Infrastructure.Test.Helper;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Infrastructure.Test.Repositories
{
    public class RegionalContactsRepositoryTest
    {
        private readonly Mock<IApplicationDbContext> _context = new();
        private readonly Mock<DbSet<Contacts>> _dbSetContactsMock = new();
        private readonly Mock<DbSet<Contacts>> _dbSetContactsMockEmpty = new();
        private readonly Mock<DbSet<Regions>> _dbSetRegionsMock = new();
        private readonly Mock<DbSet<Regions>> _dbSetRegionsMockEmpty = new();
        private readonly RegionalContactsRepository _repository;
        private readonly Contacts _contacts;
        private readonly Regions _regions;

        public RegionalContactsRepositoryTest()
        {
            _repository = new(_context.Object);

            _regions = new() {
                Ddd = 11, 
                RegionName = "São Paulo",
                Contacts = new List<Contacts>() 
            };

            _contacts = new()
            {
                Id = 2,
                Name = "Joao",
                Email = "joao@teste.com",
                Region = _regions,
                PhoneNumber = "99999-9999"
            };

            _regions.Contacts.Add(_contacts);

            _dbSetContactsMock = MockDbSetHelper<Contacts>.CreateMockDbSet(new List<Contacts> { _contacts });

            _dbSetContactsMockEmpty = MockDbSetHelper<Contacts>.CreateMockDbSet(new List<Contacts>());

            _dbSetRegionsMock = MockDbSetHelper<Regions>.CreateMockDbSet(new List<Regions> { _regions });

            _dbSetRegionsMockEmpty = MockDbSetHelper<Regions>.CreateMockDbSet(new List<Regions>());
        }

        [Fact]
        public void SearchAllContacts_ShouldBeReturnSuccess()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Returns(_dbSetContactsMock.Object);

            //Act
            var result = _repository.SearchAllContacts();

            //Assert
            Assert.IsType<List<ContactOutputDto>>(result);
        }

        [Fact]
        public void SearchAllContacts_ShouldBeFail()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Throws(new Exception());

            //Act & Assert
            Assert.Throws<Exception>(() => _repository.SearchAllContacts());
        }

        [Fact]
        public void SearchContactByRegion_ShouldBeReturnSuccess()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Returns(_dbSetContactsMock.Object);

            //Act
            var result = _repository.SearchContactByRegion(16);

            //Assert
            Assert.IsType<List<ContactOutputDto>>(result);
        }

        [Fact]
        public void SearchContactByRegion_ShouldBeFail()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Throws(new Exception());

            //Act & Assert
            Assert.Throws<Exception>(() => _repository.SearchAllContacts());
        }

        [Fact]
        public void SearchContactById_ShouldBeReturnSuccess()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Returns(_dbSetContactsMock.Object);

            //Act
            var result = _repository.SearchContactById(2);

            //Assert
            Assert.IsType<Contacts>(result);
        }

        [Fact]
        public void SearchContactById_ShouldBeFailAndReturnsBadRequestException()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Returns(_dbSetContactsMockEmpty.Object);

            //Act & Assert
            var result = Assert.Throws<BadRequestException>(() => _repository.SearchContactById(1));
            Assert.Equal("O Contato Informado não existe", result.Message);
        }

        [Fact]
        public void SearchContactById_ShouldBeFail()
        {
            //Arrange
            _context.Setup(x => x.Contacts).Throws(new Exception());

            //Act & Assert
            Assert.Throws<Exception>(() => _repository.SearchContactById(1));
        }

        [Fact]
        public void SearchRegionByDdd_ShouldBeReturnSuccess()
        {
            //Arrange
            _context.Setup(x => x.Regions).Returns(_dbSetRegionsMock.Object);

            //Act
            var result = _repository.SearchRegionByDdd(11);

            //Assert
            Assert.IsType<Regions>(result);
        }

        [Fact]
        public void SearchRegionByDdd_ShouldBeFailAndReturnsBadRequestException()
        {
            //Arrange
            _context.Setup(x => x.Regions).Returns(_dbSetRegionsMockEmpty.Object);

            //Act & Assert
            var result = Assert.Throws<BadRequestException>(() => _repository.SearchRegionByDdd(11));
            Assert.Equal("O DDD informado não existe!", result.Message);
        }

        [Fact]
        public void SearchRegionByDdd_ShouldBeFail()
        {
            //Arrange
            _context.Setup(x => x.Regions).Throws(new Exception());

            //Act & Assert
            Assert.Throws<Exception>(() => _repository.SearchRegionByDdd(11));
        }
    }
}
