CREATE PROCEDURE sp_allSpecificUserParcels
@UserId INT
AS
BEGIN
SELECT UserId
      ,[ParcelName]
      ,[ParcelDescription]
      ,[Delivery]
      ,[ParcelWeight]
      ,[ParcelPrice]
      ,[SendDate]
      ,[SentFrom]
      ,[SentTo]
      ,[StatusId]
      ,[ShippingId]
  FROM [PostalServiceApp].[dbo].[Parcel] P
  WHERE UserId = @UserId
END;
GO





