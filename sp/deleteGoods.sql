USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[deleteGoods]    Script Date: 7/10/2016 10:36:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[deleteGoods]
(
	@goodsId INT
)
As
Begin
DELETE from goods WHERE goods_id = @goodsId
DECLARE @Returns BIT 
IF @@rowcount <> 1
	SET @Returns = -1  
ELSE
	SET @Returns = 1  

RETURN @Returns
END