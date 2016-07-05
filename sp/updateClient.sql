USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addClient]    Script Date: 07/01/2016 21:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <01-07-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[updateClient]
(
	@clientId INT,
	@clientNameEn nvarchar(255) = NULL,
	@clientNameAr nvarchar(255) = NULL,
	@clientAddressEn nvarchar(255) = NULL,
	@clientAddressAr nvarchar(255) = NULL,
	@clientTelephoneNo nvarchar(255) = NULL,
	@clientMobileNo nvarchar(255) = NULL,
	@clientIsVIP bit = Null
)
As
Begin
UPDATE clients SET client_name_en = @clientNameEn, client_name_ar = @clientNameAr, 
				   client_address_en = @clientAddressEn, client_address_ar = @clientAddressAr,
				   client_telephone_no = @clientTelephoneNo, client_mobile_no = @clientMobileNo , Is_VIP = @clientIsVIP
	WHERE client_id = @clientId
--DECLARE @Returns BIT 
--IF @@ERROR = 0
--	SET @Returns = -1  
--ELSE
--	SET @Returns = 1  

RETURN @@ERROR
END