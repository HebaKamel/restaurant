USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[updateClient]    Script Date: 07/02/2016 04:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <01-07-2016>
-- Description:	<Description,,>
-- =============================================
Create Procedure [dbo].[updateUnit]
(
	@unitId INT,
	@unitNameEn nvarchar(255) = NULL,
	@unitNameAr nvarchar(255) = NULL
)
As
Begin
UPDATE units SET unit_name_en = @unitNameEn, unit_name_ar = @unitNameAr
	WHERE unit_id = @unitId

RETURN @@ERROR
END