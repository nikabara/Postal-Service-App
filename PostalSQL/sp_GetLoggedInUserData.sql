CREATE PROCEDURE sp_GetLoggedInUserData
@Email VARCHAR(50),
@Password VARCHAR(10)
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
  WHERE Email = @Email AND [Password] = @Password
END;
GO

