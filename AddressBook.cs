using System.Collections.Generic;
using System;
namespace address_book
{
public class AddressBook{
public Dictionary<string, Contact> ContactInfo { get; set; }
public AddressBook()
{
    ContactInfo = new Dictionary<string, Contact>();
}
public void AddContact(Contact contact)
{
    try
    {
    this.ContactInfo.Add(contact.Email, contact);
    }
    catch (System.ArgumentException ex)
    {
        Console.WriteLine($"Error trying to add contact: {ex}\n");
    }
}
public Contact GetByEmail(string email)
{
    return this.ContactInfo[email];
}
}
}