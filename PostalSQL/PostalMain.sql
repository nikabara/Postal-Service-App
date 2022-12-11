CREATE DATABASE PostalServiceApp
GO

USE PostalServiceApp
GO

-- Start Parcel Query --
CREATE TABLE Parcel (
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	UserId INT NOT NULL,
	ParcelName VARCHAR(30) CHECK(LEN(ParcelName) >= 3 AND LEN(ParcelName) <= 30) NOT NULL,
	ParcelDescription VARCHAR(250) CHECK(LEN(ParcelDescription) >= 3 AND LEN(ParcelDescription) <= 250) NOT NULL,
	Delivery BIT DEFAULT(1),
	ParcelWeight FLOAT CHECK(ParcelWeight < 10000),
	ParcelPrice FLOAT CHECK(ParcelPrice >= 0) NOT NULL,
	SendDate DATETIME CHECK(SendDate <= GETDATE()) DEFAULT('0000-00-00 00:00') NOT NULL,
	SentFrom VARCHAR(20) CHECK(LEN(SentFrom) >= 2 AND LEN(SentFrom) <= 15) NOT NULL,
	SentTo VARCHAR(20) CHECK(LEN(SentTo) >= 2 AND LEN(SentTo) <= 15) NOT NULL,
	StatusId TINYINT NOT NULL,
	ShippingId TINYINT NOT NULL,
	FOREIGN KEY (UserId) REFERENCES [User](UserId),
	FOREIGN KEY (StatusId) REFERENCES [Status](StatusId),
	FOREIGN KEY (ShippingId) REFERENCES [Shipping](ShippingId)
)
GO


INSERT INTO Parcel
	VALUES (1,'First Parcel','This is first test parcel',1,1500,5.5,GETDATE(),'Georgia','UK',1,2)
		GO

INSERT INTO Parcel 
	VALUES (1,'Test Parcel','This is test first parcel',0,500,0.5,GETDATE(),'Georgia','America',2,3)
		GO

INSERT INTO Parcel
	VALUES (3,'Test Parcel for marika','This is test first parcel for marika',1,3000,8,GETDATE(),'Georgia','America',2,3)
		GO
-- End Parcel Query --

-- Start User Query --
CREATE TABLE [User] (
	UserId INT PRIMARY KEY IDENTITY NOT NULL,
	FirstName NVARCHAR(30) CHECK(LEN(FirstName) >= 1 AND LEN(FirstName) <= 30) NOT NULL,
	LastName NVARCHAR(35) CHECK(LEN(LastName) >= 1 AND LEN(LastName) <= 35) NOT NULL,
	FullName AS FirstName + ' ' + LastName,
	Age TINYINT CHECK(Age > 0) NOT NULL,
	Email VARCHAR(50) CHECK(LEN(Email) >= 9 AND LEN(Email) <= 50 AND Email LIKE '%.%' AND Email LIKE '%@%') NOT NULL,
	[Password] VARCHAR(10) CHECK(LEN([Password]) < 10 AND [Password] LIKE '%[a-z]%' AND [Password] LIKE '%[0-9]%'),
	Balance FLOAT
)
GO

INSERT INTO [User] (FirstName,LastName,Age,Email,[Password],Balance)
	VALUES (N'ნიკა',N'ბარათაშვილი',15,'baratashvilinick@gmail.com','Step2019',150000)
		GO
-- End User Query --


-- Start Status Query --
CREATE TABLE [Status] (
	StatusId TINYINT PRIMARY KEY NOT NULL,
	ParcelStatus VARCHAR(9) CHECK(ParcelStatus LIKE 'Packing' OR ParcelStatus LIKE 'Sent' OR ParcelStatus LIKE 'Delivered' OR ParcelStatus LIKE 'Ready')
)
GO

INSERT INTO [Status]
	VALUES (1,'Packing'),(2,'Sent'),(3,'Delivered'),(4,'Ready')
	 GO
-- End Status Query --


-- Start Shipping Query --
CREATE TABLE Shipping (
	ShippingId TINYINT PRIMARY KEY NOT NULL,
	ShippingType VARCHAR(6) CHECK(LEN(ShippingType) <= 6 AND ShippingType LIKE 'Air' OR ShippingType LIKE 'Ground' OR ShippingType LIKE 'Marine')
)
GO

INSERT INTO [Shipping]
	VALUES (1,'Air'),(2,'Ground'),(3,'Marine')
		GO
-- End Shipping Query --


-- All Joined Query --
SELECT [Id]
      ,U.FullName
      ,[ParcelName]
      ,[ParcelDescription]
      ,[ParcelPrice]
      ,[SendDate]
      ,[SentFrom]
      ,[SentTo]
      ,S.ParcelStatus
      ,SH.ShippingType
  FROM [PostalServiceApp].[dbo].[Parcel] P
  INNER JOIN [User] U ON P.UserId = U.UserId
  INNER JOIN [Status] S ON P.StatusId = S.StatusId
  INNER JOIN [Shipping] SH ON P.ShippingId = SH.ShippingId

-- All Selects Query
  SELECT * FROM Parcel

  SELECT * FROM [User]

  SELECT * FROM [Status]

  SELECT * FROM [Shipping]

