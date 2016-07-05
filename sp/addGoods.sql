USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addUnit]    Script Date: 07/02/2016 16:22:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[addGoods]
(
	@goodsNameEn nvarchar(255),
	@goodsNameAr nvarchar(255),
	@unitId INT,
	@goodsId INT OUT
)
As
Begin
INSERT INTO goods
	VALUES (@goodsNameEn, @goodsNameAr,@unitId );
SET @goodsId = SCOPE_IDENTITY();
END