USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchClient]    Script Date: 07/02/2016 04:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <30-06-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[SearchUnit]
(
	@unitId INT = NULL,
	@unitNameEn nvarchar(255) = NULL,
	@unitNameAr nvarchar(255) = NULL
)
As
BEGIN

SELECT * FROM units
	WHERE 1=1 
	AND (@unitId IS NULL OR unit_id = @unitId)
	AND (@unitNameEn IS NULL OR unit_name_en LIKE '%'+@unitNameEn+'%')
	AND (@unitNameAr IS NULL OR unit_name_ar LIKE '%'+@unitNameAr+'%')
	ORDER BY unit_id DESC
END