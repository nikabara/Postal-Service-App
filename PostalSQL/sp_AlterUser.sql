USE PostalServiceApp
GO

CREATE PROCEDURE sp_AlterUser
@Email VARCHAR(50),
@Password VARCHAR(10),
@FirstName NVARCHAR(30),
@LastName NVARCHAR(35)
AS
UPDATE [User]
	SET FirstName = @FirstName,
		LastName = @LastName
	WHERE Email = @Email AND [Password] = @Password;