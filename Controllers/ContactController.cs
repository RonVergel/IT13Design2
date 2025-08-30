using System.Collections.Generic;
using WindowsFormsApp4.Models;

namespace WindowsFormsApp4.Controllers
{
    public class ContactController
    {
        private List<Contact> contacts = new List<Contact>();

        public IEnumerable<Contact> GetAllContacts()
        {
            return contacts;
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        // Add more methods as needed (Edit, Delete, etc.)
    }
}