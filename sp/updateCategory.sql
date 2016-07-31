USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[updateUnit]    Script Date: 7/31/2016 10:44:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <31-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[updateCategory]
(
	@categoryId INT,
	@categoryNameEn nvarchar(255) = NULL,
	@categoryNameAr nvarchar(255) = NULL
)
As
Begin
UPDATE category SET category_name_en = @categoryNameEn, category_name_ar = @categoryNameAr
	WHERE category_id = @categoryId

RETURN @@ERROR
END