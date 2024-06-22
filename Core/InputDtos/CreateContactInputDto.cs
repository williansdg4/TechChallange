using System.ComponentModel.DataAnnotations;

namespace Core.InputDtos
{
    public class CreateContactInputDto
    {
        [Required (ErrorMessage = "É obrigatório informar o nome do contato!")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 200 caracteres")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o telefone do contato!")]
        [RegularExpression(@"^9\d{4}-\d{4}$", ErrorMessage = "O telefone deve estar no formato 9XXXX-XXXX")]
        public required string PhoneNumber { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o endereço de e-mail do contato!")]
        [EmailAddress (ErrorMessage = "E-mail incorreto")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar um DDD válido!")]
        [RegularExpression(@"^\d{2}$", ErrorMessage = "O DDD deve estar no formato XX")]
        public int Ddd { get; set; }
    }
}
