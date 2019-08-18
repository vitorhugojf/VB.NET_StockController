create table product (
 Id int IDENTITY(1,1) PRIMARY KEY,
 Name varchar(100) NOT NULL,
 Description varchar(max),
 Value decimal(18,2) NOT NULL,
 Amount int NOT NULL
);