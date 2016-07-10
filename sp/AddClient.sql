USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addClient]    Script Date: 6/29/2016 10:55:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <28-06-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[addClient]
(
	@clientNameEn nvarchar(255),
	@clientNameAr nvarchar(255),
	@clientAddressEn nvarchar(255),
	@clientAddressAr nvarchar(255),
	@clientTelephoneNo nvarchar(255),
	@clientMobileNo nvarchar(255),
	@clientId int out,
	@clientIsVIP bit
)
As
Begin
INSERT INTO clients
	VALUES (@clientNameEn, @clientNameAr, @clientAddressAr, @clientAddressEn, @clientTelephoneNo, @clientMobileNo,NULL,@clientIsVIP);
SET @clientId = SCOPE_IDENTITY();
END