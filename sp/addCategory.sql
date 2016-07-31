USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addCategory]    Script Date: 7/31/2016 10:43:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <31-07-2016>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[addCategory]
(
	@categoryNameEn nvarchar(255),
	@categoryNameAr nvarchar(255),
	@categoryId int out
)
As
Begin
INSERT INTO category
	VALUES (@categoryNameEn, @categoryNameAr);
SET @categoryId = SCOPE_IDENTITY();
END