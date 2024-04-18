using BlazorServerDemo.Models;

namespace BlazorServerDemo.Services
{
    public interface IContactService
    {
        public void AddContact(Contact contact);
        public int GetContactCount();
        public List<Contact> GetContacts();
    }
}

