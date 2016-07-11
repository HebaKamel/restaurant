USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[updateClient]    Script Date: 7/11/2016 9:34:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <11-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[updateSupplier]
(
	@supplierId INT,
	@supplierNameEn nvarchar(255) = NULL,
	@supplierNameAr nvarchar(255) = NULL,
	@supplierAddressEn nvarchar(255) = NULL,
	@supplierAddressAr nvarchar(255) = NULL,
	@supplierTelephoneNo nvarchar(255) = NULL,
	@supplierMobileNo nvarchar(255) = NULL
)
As
Begin
UPDATE suppliers SET supplier_name_en = @supplierNameEn, supplier_name_ar = @supplierNameAr, 
				   supplier_address_en = @supplierAddressEn, supplier_address_ar = @supplierAddressAr,
				   supplier_telephone_no = @supplierTelephoneNo, supplier_mobile_no = @supplierMobileNo
	WHERE supplier_id = @supplierId
--DECLARE @Returns BIT 
--IF @@ERROR = 0
--	SET @Returns = -1  
--ELSE
--	SET @Returns = 1  

RETURN @@ERROR
END