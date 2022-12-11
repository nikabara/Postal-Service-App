CREATE PROCEDURE sp_InsertUser
@FirstName NVARCHAR(30),
@LastName NVARCHAR(35),
@Age TINYINT,
@Email VARCHAR(50),
@Password VARCHAR(10),
@Balance FLOAT
AS
BEGIN
	INSERT INTO [User]
		VALUES (@FirstName,@LastName,@Age,@Email,@Password,@Balance);
END;

