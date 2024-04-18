using BlazorServerDemo.Models;

namespace BlazorServerDemo.Services
{
    public class ContactService : IContactService
    {
        public List<Contact> contacts = new List<Contact>();


        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public int GetContactCount()
        {
            return contacts.Count;
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}
