CREATE PROCEDURE sp_SelectExactUser
@FirstName NVARCHAR(30),
@LastName NVARCHAR(35),
@Age TINYINT,
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
  WHERE FirstName = @FirstName AND
	LastName = @LastName AND
		Age = @Age AND
			Email = @Email AND
				[Password] = @Password
END;

