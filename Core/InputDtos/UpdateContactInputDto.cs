using System.ComponentModel.DataAnnotations;

namespace Core.InputDtos
{
    public class UpdateContactInputDto
    {
        public required int Id { get; set; }

        [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 200 caracteres")]
        public string? Name { get; set; }

        [RegularExpression(@"^9\d{4}-\d{4}$", ErrorMessage = "O telefone deve estar no formato 9XXXX-XXXX")]
        public string? PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "E-mail incorreto")]
        public string? Email { get; set; }

        [RegularExpression(@"^\d{2}$", ErrorMessage = "O DDD deve estar no formato XX")]
        public int? Ddd { get; set; }
    }
}
