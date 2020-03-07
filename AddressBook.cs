using System;
using System.Collections.Generic;
using System.Linq;

namespace try_catch
{

    public class AddressBook
    {
        public List<Contact> _contacts = new List<Contact> ();

        public void AddContact (Contact contact)
        {
            _contacts.Add (contact);
        }

        public Contact GetByEmail (string email)
        {

            return _contacts.First (contact =>
            {
                return contact.Email == email;
            });
        }
    }

}