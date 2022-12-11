USE PostalServiceApp
GO

CREATE PROCEDURE sp_InsertParcelData
@UserId INT,
@ParcelName VARCHAR(30),
@ParcelDescription VARCHAR(250),
@Delivery BIT,
@ParcelWeight FLOAT,
@ParcelPrice FLOAT,
@SendDate DATETIME,
@SentFrom VARCHAR(20),
@SentTo VARCHAR(20),
@StatusId TINYINT,
@ShippingId TINYINT
AS
BEGIN
	INSERT INTO Parcel
		VALUES (@UserId,@ParcelName,@ParcelDescription,@Delivery,@ParcelWeight,@ParcelPrice,@SendDate,@SentFrom,@SentTo,@StatusId,@ShippingId)
END;
