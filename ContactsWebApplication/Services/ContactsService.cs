using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApplication.Models;
using Microsoft.Extensions.Configuration;

namespace ContactsWebApplication.Services
{
    public class ContactsService : IContactsService
    {
        private readonly IConfiguration _config;
        private readonly string apiEndpoint;
        public ContactsService(IConfiguration config)
        {
            _config = config;
            apiEndpoint = _config.GetSection("Endpoints").GetValue<string>("Api");
        }

        public void Create(ContactModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactModel model)
        {
            throw new NotImplementedException();
        }

        public ContactModel GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactModel> GetContacts()
        {
            throw new NotImplementedException();
        }

        public void Update(ContactModel model)
        {
            throw new NotImplementedException();
        }
    }
}
