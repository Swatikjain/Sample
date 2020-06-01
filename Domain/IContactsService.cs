using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IContactsService
    {
        List<ContactModel> GetContacts();

        ContactModel GetContact(int id);

        void Create(ContactModel model);

        void Update(ContactModel model);

        void Delete(ContactModel model);
    }
}
