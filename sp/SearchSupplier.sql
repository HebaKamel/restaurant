USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchClient]    Script Date: 7/11/2016 9:30:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <30-06-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[SearchSupplier]
(
	@supplierId INT = NULL,
	@supplierNameEn nvarchar(255) = NULL,
	@supplierNameAr nvarchar(255) = NULL,
	@supplierAddressEn nvarchar(255) = NULL,
	@supplierAddressAr nvarchar(255) = NULL,
	@supplierTelephoneNo nvarchar(255) = NULL,
	@supplierMobileNo nvarchar(255) = NULL
)
As
BEGIN

SELECT * FROM suppliers
	WHERE 1=1 
	AND (@supplierId IS NULL OR supplier_id = @supplierId)
	AND (@supplierNameEn IS NULL OR supplier_name_en LIKE '%'+@supplierNameEn+'%')
	AND (@supplierNameAr IS NULL OR supplier_name_ar LIKE '%'+@supplierNameAr+'%')
	AND (@supplierAddressEn IS NULL OR supplier_address_en LIKE '%'+@supplierAddressEn+'%')
	AND (@supplierAddressAr IS NULL OR supplier_address_ar LIKE '%'+@supplierAddressAr+'%')
	AND (@supplierTelephoneNo IS NULL OR supplier_telephone_no LIKE @supplierTelephoneNo)
	AND (@supplierMobileNo IS NULL OR supplier_mobile_no LIKE @supplierMobileNo)
	ORDER BY supplier_id DESC
END