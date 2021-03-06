USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchGoods]    Script Date: 7/10/2016 11:09:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[SearchGoods]
(
	@goodsId INT = NULL,
	@goodsNameEn nvarchar(255) = NULL,
	@goodsNameAr nvarchar(255) = NULL,
	@unitId INT = NULL
)
As
BEGIN

SELECT goods_id, goods_name_en, goods_name_ar, unit_name_en, unit_name_ar, goods.unit_id FROM goods inner JOIN units on goods.unit_id = units.unit_id
	WHERE 1=1 
	AND (@goodsId IS NULL OR goods.goods_id = @goodsId)
	AND (@goodsNameEn IS NULL OR goods.goods_name_en LIKE '%'+@goodsNameEn+'%')
	AND (@goodsNameAr IS NULL OR goods.goods_name_ar LIKE '%'+@goodsNameAr+'%')
	AND (@unitId IS NULL OR goods.unit_id = @unitId)
	ORDER BY goods.goods_id DESC
END