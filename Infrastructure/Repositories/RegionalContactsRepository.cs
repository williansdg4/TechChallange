using Core.Entities;
using Core.Errors;
using Core.OutputDtos;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class RegionalContactsRepository : IRegionalContactsRepository
    {
        private readonly IApplicationDbContext _context;
        public RegionalContactsRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public List<ContactOutputDto> SearchAllContacts()
        {
            var contacts = _context.Contacts
                .Select(c => new ContactOutputDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    Ddd = c.Region.Ddd
                })
                .ToList();
            return contacts;
        }

        public List<ContactOutputDto> SearchContactByRegion(int ddd)
        {
            var contacts = _context.Contacts
                .Where(c => c.Region.Ddd == ddd)
                .Select(c => new ContactOutputDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    Ddd = c.Region.Ddd
                })
                .ToList();
            return contacts;
        }

        public Contacts SearchContactById(int id)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.Id == id);

            if (contact == null)
            {
                throw new BadRequestException("O Contato Informado não existe");
            }

            return contact;
        }

        public Regions SearchRegionByDdd(int ddd)
        {
            var region = _context.Regions.FirstOrDefault(r => r.Ddd == ddd);

            if (region == null)
            {
                throw new BadRequestException("O DDD informado não existe!");
            }

            return region;
        }

        public async Task CreateContact(Contacts contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateContact(Contacts contact)
        {
            _context.Contacts.Update(contact);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteContact(Contacts contact)
        {
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
        }
    }
}
