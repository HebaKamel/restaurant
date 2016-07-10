USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[updateUnit]    Script Date: 07/02/2016 16:26:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[updateGoods]
(
	@goodsId INT,
	@goodsNameEn nvarchar(255) = NULL,
	@goodsNameAr nvarchar(255) = NULL,
	@unitId INT
)
As
Begin
UPDATE goods 
SET goods_name_en = @goodsNameEn, goods_name_ar = @goodsNameAr, unit_id = @unitId
	WHERE goods_id = @goodsId

RETURN @@ERROR
END