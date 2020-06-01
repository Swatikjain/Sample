using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ContactsWebApi.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsService _contactsService;

        public ContactsController(IContactsService contactsService)
        {
            _contactsService = contactsService;
        }

        // GET api/contacts
        [HttpGet]
        public IEnumerable<ContactModel> Get()
        {
            try
            {
                var list = _contactsService.GetContacts();
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET api/contacts/5
        [HttpGet("{id}")]
        public ActionResult<ContactModel> Get(int id)
        {
            try
            { 
                return _contactsService.GetContact(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/contacts
        [HttpPost]
        public void Post([FromBody] ContactModel model)
        {
            try
            {
                _contactsService.Create(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/contacts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ContactModel model)
        {
            try
            {
                var contact = _contactsService.GetContact(id);
                contact.Id = id;
                contact.FirstName = model.FirstName;
                contact.LastName = model.LastName;
                contact.Email = model.Email;
                contact.PhoneNumber = model.PhoneNumber;

                _contactsService.Update(contact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/contacts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                var model = _contactsService.GetContact(id);
                _contactsService.Delete(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
