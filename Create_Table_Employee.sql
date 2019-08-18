create table employee (
 Id int IDENTITY(1,1) PRIMARY KEY,
 Name varchar(100) NOT NULL,
 Username varchar(max) NOT NULL,
 Password varchar(max) NOT NULL,
 JobRole varchar(max) NOT NULL,
 LastActive datetime
);