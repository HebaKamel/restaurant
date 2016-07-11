USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addClient]    Script Date: 7/10/2016 11:56:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <10-07-2016>
-- Description:	<Description,,>
-- =============================================

CREATE Procedure [dbo].[addSupplier]
(
	@supplierNameEn nvarchar(255),
	@supplierNameAr nvarchar(255),
	@supplierAddressEn nvarchar(255),
	@supplierAddressAr nvarchar(255),
	@supplierTelephoneNo nvarchar(255),
	@supplierMobileNo nvarchar(255),
	@supplierId int out
)
As
Begin

--SET IDENTITY_INSERT dbo.clients ON
INSERT INTO dbo.suppliers
	VALUES (@supplierNameEn, @supplierNameAr, @supplierAddressEn, @supplierAddressAr, @supplierTelephoneNo, @supplierMobileNo);
SET @supplierId = SCOPE_IDENTITY();
END