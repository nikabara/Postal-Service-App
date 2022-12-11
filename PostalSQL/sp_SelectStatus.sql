CREATE PROCEDURE sp_SelectStatus
AS
BEGIN
SELECT TOP (1000) [StatusId]
      ,[ParcelStatus]
  FROM [PostalServiceApp].[dbo].[Status]
END;