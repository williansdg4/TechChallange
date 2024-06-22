using Core.Entities;
using Core.Errors;
using Core.InputDtos;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace TechChallange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionalContactsController : ControllerBase
    {
        private readonly IRegionalContactsRepository _regionalContactsRepository;

        public RegionalContactsController(IRegionalContactsRepository regionalContactsRepository)
        {
            _regionalContactsRepository = regionalContactsRepository;
        }

        /// <summary>
        /// Busca todos os contatos
        /// </summary>
        /// <returns>Retorna uma lista de contatos</returns>
        /// <response code="200">Sucesso na execução ao buscar todos os contatos</response>
        /// <response code="500">Falha na execução</response>
        [HttpGet("SearchAllContacts")]
        public IActionResult SearchAllContacts()
        {
            try{
                var contactsList = _regionalContactsRepository.SearchAllContacts();
                return StatusCode(200, contactsList);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro interno no servidor.");
            }
        }

        /// <summary>
        /// Busca contatos por região (ddd)
        /// </summary>
        /// <param name="ddd">Deve ser informado o DDD da região desejada</param>
        /// <returns>Retorna uma lista de contatos quando existir contatos cadastrados
        /// para a região informada</returns>
        /// <response code="200">Sucesso na execução ao buscar os contatos da regição
        /// informada</response>
        /// <response code="500">Falha na execução</response>
        [HttpGet("SearchContactsByRegion/{ddd:int}")]
        public IActionResult SearchContactsByRegion([FromRoute] int ddd)
        {
            try
            {
                var contactsList = _regionalContactsRepository.SearchContactByRegion(ddd);
                return StatusCode(200, contactsList);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro interno no servidor.");
            }
        }

        /// <summary>
        /// Adiciona um novo contato
        /// </summary>
        /// <param name="contact">Objeto contact. É necessário informar nome, telefone,
        /// e-mail e DDD do contato para cadastro</param>
        /// <response code="201">Sucesso no cadastro do novo contato</response>
        /// <response code="400">Falha na execução. Verifique os dados informados e tente
        /// novamente</response>
        /// <response code="500">Falha na execução</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost("CreateContact")]
        public async Task<IActionResult> CreateContact([FromBody] CreateContactInputDto contact)
        {
            try
            {
                var region = _regionalContactsRepository.SearchRegionByDdd(contact.Ddd);
                var newContact = new Contacts()
                {
                    Name = contact.Name,
                    PhoneNumber = contact.PhoneNumber,
                    Email = contact.Email,
                    Region = region,
                };

                await _regionalContactsRepository.CreateContact(newContact);
                return StatusCode(201);
            }
            catch (BadRequestException ex)
            {
                return StatusCode(400, ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro interno no servidor.");
            }
        }

        /// <summary>
        /// Atualiza os dados do contato
        /// </summary>
        /// <param name="contact">Objeto contact. É necessário informar o id para identificar o
        /// usuário a ser atualizado, todos os outros parametros são opcionais</param>
        /// <response code="204">Dados do contato atualizados com sucessso</response>
        /// <response code="400">Falha na execução. Verifique os dados enviados e tente
        /// novamente</response>
        /// <response code="500">Falha na execução</response>
        /// [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPut("UpdateContact")]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactInputDto contact)
        {
            try
            {
                var updatedContact = _regionalContactsRepository.SearchContactById(contact.Id);

                if (contact.Ddd is not null)
                {
                    var region = _regionalContactsRepository.SearchRegionByDdd((int)contact.Ddd);
                    updatedContact.Region = region;
                }

                if (!string.IsNullOrEmpty(contact.Name))
                {
                    updatedContact.Name = contact.Name;
                }

                if (!string.IsNullOrEmpty(contact.Email))
                {
                    updatedContact.Email = contact.Email;
                }

                if (!string.IsNullOrEmpty(contact.PhoneNumber))
                {
                    updatedContact.PhoneNumber = contact.PhoneNumber;
                }

                await _regionalContactsRepository.UpdateContact(updatedContact);
                return StatusCode(204);
            }
            catch (BadRequestException ex)
            {
                return StatusCode(400, ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro interno no servidor.");
            }
        }

        /// <summary>
        /// Exclui contato existente
        /// </summary>
        /// <param name="id">Deve ser informado o id do contato que deseja excluir</param>
        /// <response code="204">Contato excluido com sucesso</response>
        /// <response code="400">O Contato Informado não existe</response>
        /// <response code="500">Falha na execução</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("DeleteContact/{id:int}")]
        public async Task<IActionResult> DeleteContact([FromRoute] int id)
        {
            try
            {
                var contact = _regionalContactsRepository.SearchContactById(id);
                await _regionalContactsRepository.DeleteContact(contact);
                return StatusCode(204);
            }
            catch (BadRequestException ex)
            {
                return StatusCode(400, ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocorreu um erro interno no servidor.");
            }
        }
    }
}
