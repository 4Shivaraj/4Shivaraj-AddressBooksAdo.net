use AddressbookForADO

select * from AddressBook

create procedure SpAddressBook
 (
 @FirstName varchar(50),
 @LastName varchar(50),
 @Address varchar(50),
 @City varchar(50),
 @State varchar(50),
 @Zip varchar(50),
 @PhoneNumber varchar(50),
 @Email varchar(50)
 )
 as
 Insert into AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
 values(
@FirstName,
 @LastName,
 @Address,
 @City,
 @State,
 @Zip,
 @PhoneNumber,
 @Email
);
select * from AddressBook;

insert into AddressBook values ('shravanthi','Pabboji','Alwal','Hyderabad','Telangana','520008','9876543210','Shravanthi@gmail.com')
insert into AddressBook values ('Sai','Teja','Poranki','Guntur','Karnataka','520008','4567898768','Sai@gmail.com')

/*Update store procedure*/

create procedure SpAddressBookEditUpdate
	@FirstName varchar(50),
	@LastName varchar(50),
	@Address varchar(50),
	@City varchar(50),
	@State varchar(50),
	@Zip varchar(50),
	@PhoneNumber varchar(50),
	@Email varchar(50)
as
update  AddressBook set FirstName=@FirstName,LastName=@LastName,Address=@Address,City=@City,State=@State,Zip=@Zip,
PhoneNumber=@PhoneNumber,Email=@Email where FirstName=@FirstName;

/*Delete store procedure*/
create procedure SpAddressBook_Delete
	@FirstName varchar(50)
as
delete from AddressBook where FirstName = @FirstName;

insert into AddressBook values ('Cheluvesha','Kumar','Bonkina','Hyderabad','Telangana','520008','9876543210','bcheluvesha@gmail.com')
insert into AddressBook values ('Arun','Ranga','Peenya','Bangalore','Karnataka','520008','856874834','Arun@gmail.com')

--UC-10
update Addressbook set AddressBookType = 'Friend';
update Addressbook set AddressBookType = 'Family' Where FirstName = 'Shivaraj';

update Addressbook set AddressBookName = 'Others';
update Addressbook set AddressBookName = 'Personal' Where FirstName = 'Shivaraj';