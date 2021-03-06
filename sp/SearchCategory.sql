USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchCategory]    Script Date: 7/31/2016 11:06:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <31-07-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[SearchCategory]
(
	@categoryId INT = NULL,
	@categoryNameEn nvarchar(255) = NULL,
	@categoryNameAr nvarchar(255) = NULL
)
As
BEGIN

SELECT * FROM category
	WHERE 1=1 
	AND (@categoryId IS NULL OR category_id = @categoryId)
	AND (@categoryNameEn IS NULL OR category_name_en LIKE '%'+@categoryNameEn+'%')
	AND (@categoryNameAr IS NULL OR category_name_ar LIKE '%'+@categoryNameAr+'%')
	ORDER BY category_id DESC
END