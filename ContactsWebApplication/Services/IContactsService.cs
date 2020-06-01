using ContactsWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWebApplication.Services
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
