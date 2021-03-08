using System;
using Contacts;
using System.Collections.Generic;

namespace AddressesBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; } = new Dictionary<string, Contact>();

        

        public void AddContact( Contact person )
        {
            Contacts.Add(person.Email, person);
        }
        public Contact GetByEmail(string email)
        {
              return  Contacts[email]; 
        }
    }
}