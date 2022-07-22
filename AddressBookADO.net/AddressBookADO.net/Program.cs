namespace AddressBookADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.NET!");
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)Inserting Details to DataBasen" +
                "\n4)retrieve Details From dataBase\n5)Update Existing Contacts");
            int op = Convert.ToInt16(Console.ReadLine());
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel addressbook = new AddressBookModel();

            switch (op)
            {
                case 1:
                    addressBookRepo.Create_Database();
                    break;
                case 2:
                    addressBookRepo.CreateTables();
                    break;
                case 3:
                    addressbook.FirstName = "Shivaraj";
                    addressbook.LastName = "Gowda";
                    addressbook.Address = "Basaveshwar Nagar";
                    addressbook.City = "Bangalore";
                    addressbook.State = "Karnataka";
                    addressbook.Zip = "560079";
                    addressbook.PhoneNumber = "8618199776";
                    addressbook.Email = "4shivaraj@gmail.com";
                    addressBookRepo.AddContact(addressbook);
                    Console.WriteLine("Record Inserted successfully");
                    break;
                case 4:
                    addressBookRepo.GetAllContact();
                    break;
                case 5:
                    string UpdatedAddress = addressBookRepo.updateEmployeeDetails();
                    Console.WriteLine(UpdatedAddress);
                    Console.WriteLine("Record Updated successfully");
                    break;
            }
        }
    }
}

/*
UC-5
Welcome to AddressBook ADO.NET!
Select option
1)Create AddrssBookServiceDatabase
2)Create AddressBookTable
3)Inserting Details to DataBasen
4)retrieve Details From dataBase
5)Update Existing Contacts
5
XYZ Colony
Record Updated successfully
*/