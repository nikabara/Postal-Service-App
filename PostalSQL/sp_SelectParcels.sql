CREATE PROCEDURE sp_SelectParcels
AS
BEGIN
SELECT TOP (1000) [Id]
      ,[UserId]
      ,[ParcelName]
      ,[ParcelDescription]
      ,[ParcelPrice]
      ,[SendDate]
      ,[SentFrom]
      ,[SentTo]
      ,[StatusId]
      ,[ShippingId]
  FROM [PostalServiceApp].[dbo].[Parcel]
END;