USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addUnit]    Script Date: 7/11/2016 4:01:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<kajoo>
-- Create date: <11-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[addTable]
(
	@tableNameEn nvarchar(255),
	 @tableNameAr nvarchar(255),
	@tableChairNumber int,
	@tableIsVip bit,
	@tableStatusId int,
	@tableId int out
)
As
Begin
INSERT INTO [dbo].[dineIn_tables]
	VALUES (@tableNameEn, @tableNameAr,@tableChairNumber,@tableIsVip,@tableStatusId);
SET @tableId = SCOPE_IDENTITY();
END