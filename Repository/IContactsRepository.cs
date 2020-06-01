using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IContactsRepository : IDisposable
    {
        List<ContactDTO> GetContacts();

        ContactDTO GetContact(int id);

        void Create(ContactDTO model);

        void Update(ContactDTO model);

        void Delete(ContactDTO model);
    }
}
