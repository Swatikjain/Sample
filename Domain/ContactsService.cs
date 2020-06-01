using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class ContactsService : IContactsService
    {
        private readonly IContactsRepository _contactsRepository;

        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        private ContactDTO MappingModelToDto(ContactModel model)
        {
            return new ContactDTO()
            {
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                FirstName = model.FirstName,
                Id = model.Id,
                IsActive = model.IsActive,
                LastName = model.LastName,
                CreatedBy = model.CreatedBy,
                CreatedOn = model.CreatedOn,
                ModifiedBy = model.ModifiedBy,
                ModifiedOn = model.ModifiedOn
            };
        }

        private ContactModel MappingDtoToModel(ContactDTO model)
        {
            return new ContactModel()
            {
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                FirstName = model.FirstName,
                Id = model.Id,
                IsActive = model.IsActive,
                LastName = model.LastName,
                CreatedBy = model.CreatedBy,
                CreatedOn = model.CreatedOn,
                ModifiedBy = model.ModifiedBy,
                ModifiedOn = model.ModifiedOn
            };
        }

        public void Create(ContactModel model)
        {
            var dto = MappingModelToDto(model);
            dto.CreatedBy = "system";
            dto.CreatedOn = DateTime.Now;
            _contactsRepository.Create(dto);
        }

        public void Delete(ContactModel model)
        {
            var dto = MappingModelToDto(model);
            dto.IsActive = false;
            _contactsRepository.Delete(dto);
        }

        public ContactModel GetContact(int id)
        {
            var dto = _contactsRepository.GetContact(id);
            return MappingDtoToModel(dto);
        }

        public List<ContactModel> GetContacts()
        {
            var dtoList = _contactsRepository.GetContacts();
            var modelList = dtoList
                    .Select(x => new ContactModel() {
                        PhoneNumber = x.PhoneNumber,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        Id = x.Id,
                        IsActive = x.IsActive,
                        LastName = x.LastName,
                        CreatedBy = x.CreatedBy,
                        CreatedOn = x.CreatedOn,
                        ModifiedBy = x.ModifiedBy,
                        ModifiedOn = x.ModifiedOn
                    })
                    .ToList();
            
            return modelList;
        }

        public void Update(ContactModel model)
        {
            var dto = MappingModelToDto(model);
            dto.ModifiedBy = "system";
            dto.ModifiedOn = DateTime.Now;
            _contactsRepository.Update(dto);
        }
    }
}
