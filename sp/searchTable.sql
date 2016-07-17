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
CREATE Procedure [dbo].[SearchTable]
(
	@tableNameEn nvarchar(255) = Null,
	@tableNameAr nvarchar(255) = Null,
	@tableChairNumber int  = Null,
	@tableIsVip bit = Null,
	@tableStatusId int  = Null,
	@tableId int  = Null
)
As
BEGIN

SELECT
	*
FROM [dbo].[dineIn_tables]
WHERE 1 = 1
AND (@tableId IS NULL
OR [dineIn_table_id] = @tableId)
AND (@tableNameEn IS NULL
OR [dineIn_table_name_en] LIKE '%' + @tableNameEn + '%')
AND (@tableNameAr IS NULL
OR [dineIn_table_name_ar] LIKE '%' + @tableNameAr + '%')
AND (@tableChairNumber IS NULL
OR [dineIn_table_chair_number] = @tableChairNumber)
AND (@tableIsVip IS NULL
OR [dineIn_table_isVip] = @tableIsVip)
AND (@tableStatusId IS NULL
OR [table_status_id] = @tableStatusId)
ORDER BY [dineIn_table_id] DESC
END