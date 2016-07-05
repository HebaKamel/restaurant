USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[deleteUnit]    Script Date: 07/02/2016 16:27:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[deleteGoods]
(
	@goodId INT
)
As
Begin
DELETE from goods WHERE goods_id = @goodId
DECLARE @Returns BIT 
IF @@rowcount <> 1
	SET @Returns = -1  
ELSE
	SET @Returns = 1  

RETURN @Returns
END