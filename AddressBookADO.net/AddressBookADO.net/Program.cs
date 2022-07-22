﻿namespace AddressBookADO.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook ADO.NET!");
            Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)Inserting Details to DataBasen" +
                "\n4)retrieve Details From dataBase\n5)Update Existing Contacts\n6)Delete Contacts from DataBase\n7)Finding Size By State And City");
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

                case 6:
                    addressbook.FirstName = "Sai";
                    addressBookRepo.DeleteContact(addressbook);
                    Console.WriteLine("Record deleted successfully");
                    break;
                case 7:
                    int countCity = addressBookRepo.CountOfEmployeeDetailsByCity();
                    Console.WriteLine("Count of Records for given City :" + countCity);
                    int CountState = addressBookRepo.CountOfEmployeeDetailsByState();
                    Console.WriteLine("Count of Records for given State :" + CountState);
                    break;
            }
        
        }
    }
}

/*
UC-7
Finding Size By State And City

Welcome to AddressBook ADO.NET!
Select option
1)Create AddrssBookServiceDatabase
2)Create AddressBookTable
3)Inserting Details to DataBasen
4)retrieve Details From dataBase
5)Update Existing Contacts
6)Delete Contacts from DataBase
7)Retreive Details By State And City
7
Count of Records for given City :2
Count of Records for given State :2

*/