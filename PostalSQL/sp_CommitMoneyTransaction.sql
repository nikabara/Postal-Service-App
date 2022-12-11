USE PostalServiceApp
GO

CREATE PROCEDURE sp_CommitMoneyTransaction
@Email VARCHAR(50),
@MoneyAmmount float
AS
	UPDATE [User]
		SET Balance = Balance + @MoneyAmmount
	WHERE Email = @Email

SELECT * FROM [User]