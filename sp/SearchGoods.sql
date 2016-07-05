USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchUnit]    Script Date: 07/02/2016 16:24:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[SearchGoods]
(
	@goodsId INT = NULL,
	@goodsNameEn nvarchar(255) = NULL,
	@goodsNameAr nvarchar(255) = NULL,
	@unitId INT = NULL
)
As
BEGIN

SELECT * FROM goods
	WHERE 1=1 
	AND (@goodsId IS NULL OR goods_id = @goodsId)
	AND (@goodsNameEn IS NULL OR goods_name_en LIKE '%'+@goodsNameEn+'%')
	AND (@goodsNameAr IS NULL OR goods_name_ar LIKE '%'+@goodsNameAr+'%')
	AND (@unitId IS NULL OR unit_id = @unitId)
	ORDER BY unit_id DESC
END