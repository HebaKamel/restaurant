USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[deleteUnit]    Script Date: 7/31/2016 10:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <31-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[deleteCategory]
(
	@categoryId INT
)
As
Begin
DELETE from category WHERE category_id = @categoryId
DECLARE @Returns BIT 
IF @@rowcount <> 1
	SET @Returns = -1  
ELSE
	SET @Returns = 1  

RETURN @Returns
END