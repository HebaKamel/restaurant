USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addClient]    Script Date: 07/02/2016 04:09:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[addUnit]
(
	@unitNameEn nvarchar(255),
	@unitNameAr nvarchar(255),
	@unitId int out
)
As
Begin
INSERT INTO units
	VALUES (@unitNameEn, @unitNameAr);
SET @unitId = SCOPE_IDENTITY();
END