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
CREATE Procedure [dbo].[updateTable]
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
UPDATE [dbo].[dinen_tables]
SET	[dineIn_table_name_en] = @tableNameEn
	,[dineIn_table_name_ar] = @tableNameAr
	,[dineIn_table_chair_number] = @tableChairNumber
	,[dineIn_table_isVip] = @tableIsVip
	,[table_status_id] = @tableStatusId
WHERE [dineIn_table_id] = @tableId

RETURN @@ERROR
END