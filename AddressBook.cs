using System.Collections.Generic;
namespace address_book
{
public class AddressBook{
public Dictionary<string, Contact> ContactInfo { get; set; }
public AddressBook()
{
    // ContactInfo = new Dictionary<string, Contact>();
}
public void AddContact(Contact contact)
{
    this.ContactInfo.Add(contact.Email, contact);
}
public Contact GetByEmail(string email)
{
    return this.ContactInfo[email];
}
}
}