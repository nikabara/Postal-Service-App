CREATE PROCEDURE sp_SelectShippings
AS
BEGIN
SELECT TOP (1000) [ShippingId]
      ,[ShippingType]
  FROM [PostalServiceApp].[dbo].[Shipping]
END;