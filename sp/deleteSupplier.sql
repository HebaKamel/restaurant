USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[deleteClient]    Script Date: 7/10/2016 11:59:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <10-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[deleteSupplier]
(
	@supplierId INT
)
As
Begin
DELETE from suppliers WHERE supplier_id = @supplierId
DECLARE @Returns BIT 
IF @@rowcount <> 1
	SET @Returns = -1  
ELSE
	SET @Returns = 1  

RETURN @Returns
END