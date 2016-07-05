USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchClient]    Script Date: 06/30/2016 23:36:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <30-06-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[SearchClient]
(
	@clientId INT = NULL,
	@clientNameEn nvarchar(255) = NULL,
	@clientNameAr nvarchar(255) = NULL,
	@clientAddressEn nvarchar(255) = NULL,
	@clientAddressAr nvarchar(255) = NULL,
	@clientTelephoneNo nvarchar(255) = NULL,
	@clientMobileNo nvarchar(255) = NULL,
	@clientIsVIP bit = Null
)
As
BEGIN

SELECT * FROM clients
	WHERE 1=1 
	AND (@clientId IS NULL OR client_id = @clientId)
	AND (@clientNameEn IS NULL OR client_name_en LIKE '%'+@clientNameEn+'%')
	AND (@clientNameAr IS NULL OR client_name_ar LIKE '%'+@clientNameAr+'%')
	AND (@clientAddressEn IS NULL OR client_address_en LIKE '%'+@clientAddressEn+'%')
	AND (@clientAddressAr IS NULL OR client_address_ar LIKE '%'+@clientAddressAr+'%')
	AND (@clientTelephoneNo IS NULL OR client_telephone_no LIKE @clientTelephoneNo)
	AND (@clientMobileNo IS NULL OR client_mobile_no LIKE @clientMobileNo)
	AND (@clientIsVIP IS Null or Is_VIP LIKE @clientIsVIP)
	ORDER BY client_id DESC
END