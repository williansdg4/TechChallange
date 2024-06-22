using Core.InputDtos;
using System.ComponentModel.DataAnnotations;

namespace Core.Test.InputDtos
{
    public class CreateContactInputDtoTest
    {
        [Fact]
        public void PhoneNumber_RequiredValidation_ShouldFailWhenPhoneNumberIsNull()
        {
            // Arrange
            var contact = new CreateContactInputDto() {
                Name = "teste",
                PhoneNumber = null,
                Email = "teste@teste.com",
                Ddd = 16
            };
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "É obrigatório informar o telefone do contato!");
        }

        [Fact]
        public void PhoneNumber_RegexValidation_ShouldFailWhenPhoneNumberIsInvalid()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "78998888",
                Email = "teste@teste.com",
                Ddd = 16
            }; // Invalid format
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "O telefone deve estar no formato 9XXXX-XXXX");
        }

        [Fact]
        public void CreateContactInputDto_PropertsValidation_ShouldPassWhenPhoneNumberIsValid()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "99999-9999",
                Email = "teste@teste.com",
                Ddd = 16
            }; // Valid format
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(validationResults);
        }

        [Fact]
        public void Email_RequiredValidation_ShouldFailWhenEmailIsNull()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "99999-9999",
                Email = null,
                Ddd = 16
            };
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "É obrigatório informar o endereço de e-mail do contato!");
        }

        [Fact]
        public void Email_RegexValidation_ShouldFailWhenEmailIsInvalid()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "99999-9999",
                Email = "testeteste.com",
                Ddd = 16
            }; // Invalid format
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "E-mail incorreto");
        }

        [Fact]
        public void Ddd_RegexValidation_ShouldFailWhenDddIsInvalid()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "99999-9999",
                Email = "teste@teste.com",
                Ddd = 6
            }; // Invalid format
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "O DDD deve estar no formato XX");
        }

        [Fact]
        public void Ddd_RegexValidation_ShouldPassWhenDddIsValid()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "99999-9999",
                Email = "teste@teste.com",
                Ddd = 16
            }; // Valid format
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(validationResults);
        }

        [Fact]
        public void Name_StringLengthValidation_ShouldFailWhenNameIsTooShort()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "te",
                PhoneNumber = "99999-9999",
                Email = "teste@teste.com",
                Ddd = 16
            }; ;
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(validationResults, v => v.ErrorMessage == "O nome deve ter entre 3 e 200 caracteres");
        }

        [Fact]
        public void Name_StringLengthValidation_ShouldPassWhenNameIsValid()
        {
            // Arrange
            var contact = new CreateContactInputDto()
            {
                Name = "teste",
                PhoneNumber = "99999-9999",
                Email = "teste@teste.com",
                Ddd = 16
            };
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(contact);

            // Act
            var isValid = Validator.TryValidateObject(contact, validationContext, validationResults, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(validationResults);
        }
    }
}
