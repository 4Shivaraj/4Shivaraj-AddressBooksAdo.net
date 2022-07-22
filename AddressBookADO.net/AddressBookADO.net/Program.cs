namespace AddressBookADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.NET!");
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase");
            int op = Convert.ToInt16(Console.ReadLine());
            AddressBookRepo addressBookRepo = new AddressBookRepo();

            switch (op)
            {
                case 1:
                    addressBookRepo.Create_Database();
                    break;

            }
        }
    }
}

/*
UC-1
Create AddrssBookServiceDatabase
Welcome to AddressBook ADO.NET!
Select option
1)Create AddrssBookServiceDatabase
1
AddressbookService Database created successfully!
*/