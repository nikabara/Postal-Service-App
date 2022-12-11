USE PostalServiceApp
GO

CREATE PROCEDURE sp_SelectUsers
AS
BEGIN
SELECT [UserId]
      ,[FirstName]
      ,[LastName]
      ,[FullName]
      ,[Age]
      ,[Email]
      ,[Password]
	  ,[Balance]
  FROM [PostalServiceApp].[dbo].[User]
END;



