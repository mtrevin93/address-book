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
    catch (System.ArgumentException)
    {
        Console.WriteLine($"\nTried to add duplicate contact\n");
    }
}
public Contact GetByEmail(string email)
//Creating empty contact probably not the best implementation here, but wanted to experiment with TryGet
{
    if (this.ContactInfo.TryGetValue( email, out Contact contact))
    {
        return this.ContactInfo[email];
    }
    else 
    {
        Console.WriteLine($"\nItem {email} not found in dictionary");
        Contact notFound = new Contact();
        return notFound;
    }
}

}
}