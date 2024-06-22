using Core.Entities;
using Core.OutputDtos;

namespace Core.Repositories
{
    public interface IRegionalContactsRepository
    {
        List<ContactOutputDto> SearchAllContacts();
        List<ContactOutputDto> SearchContactByRegion(int ddd);
        Contacts SearchContactById(int id);
        Regions SearchRegionByDdd(int ddd);
        Task CreateContact(Contacts contact);
        Task UpdateContact(Contacts contact);
        Task DeleteContact(Contacts contact);
    }
}
