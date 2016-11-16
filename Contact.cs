using System;
using System.Collections.Generic;

public class Contact
{
  public string Name;
  public string Phone;
  public string Address;
}
class Program
{
  public static void Main()
{
Contact Irene = new Contact();
Irene.Name = "Irene Grom";
Irene.Phone = "619-316-3789";
Irene.Address = "Portland";

Contact Kostya = new Contact();
Kostya.Name = "Kostya Yaremtso";
Kostya.Phone = "619-955-4755";
Kostya.Address = "San Diego";

Contact Anya = new Contact();
Anya.Name = "Anya Yaremtso";
Anya.Phone = "858-111-2222";
Anya.Address = "Los Angeles";

Contact marie = new Contact();
marie.Name = "Marie Curie";
marie.Phone = "432-154-3523";
marie.Address = "1911 West 1st Ave. Fictional, OR 44556";

Contact janis = new Contact();
janis.Name = "Janis Joplin";
janis.Phone = "415-124-2445";
janis.Address = "Haight Ashbury, San Francisco, CA 94117";



List<Contact> AddressBook = new List<Contact>() {Irene,Kostya,Anya};
AddressBook.Add(marie);
AddressBook.Add(janis);
foreach (Contact person in AddressBook)
{
      Console.WriteLine("Name: " + person.Name);
      Console.WriteLine("Phone number: " + person.Phone);
      Console.WriteLine("Address: " + person.Address);
  }
 }
}
