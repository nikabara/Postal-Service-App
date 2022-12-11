CREATE PROCEDURE sp_SelectBasicUser
AS
BEGIN
SELECT [FirstName]
      ,[LastName]
      ,[Age]
      ,[Email]
      ,[Password]
	  ,[Balance]
  FROM [PostalServiceApp].[dbo].[User]
END;
