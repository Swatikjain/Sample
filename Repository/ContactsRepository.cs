using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly ContactsContext _dbContext;

        public ContactsRepository(ContactsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(ContactDTO model)
        {
            _dbContext.Contacts.Add(model);
            _dbContext.SaveChanges();
        }

        public void Delete(ContactDTO model)
        {
            _dbContext.Contacts.Update(model);
            _dbContext.SaveChanges();
        }
        
        public ContactDTO GetContact(int id)
        {
            var contact = _dbContext.Contacts.Where(c => c.Id == id).Select(c => new ContactDTO()
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                PhoneNumber = c.PhoneNumber,
                Email = c.Email,
                IsActive = c.IsActive,
                CreatedBy = c.CreatedBy,
                CreatedOn = c.CreatedOn,
                ModifiedBy = c.ModifiedBy,
                ModifiedOn = c.ModifiedOn
            });
            return contact.SingleOrDefault();
        }

        public List<ContactDTO> GetContacts()
        {
            var contacts = _dbContext.Contacts.Select(c => new ContactDTO()
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                PhoneNumber = c.PhoneNumber,
                Email = c.Email,
                IsActive = c.IsActive,
                CreatedBy = c.CreatedBy,
                CreatedOn = c.CreatedOn,
                ModifiedBy = c.ModifiedBy,
                ModifiedOn = c.ModifiedOn
            }).Where(x=>x.IsActive);
            return contacts.ToList<ContactDTO>();
        }

        public void Update(ContactDTO model)
        {
            _dbContext.Contacts.Update(model);
            _dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
