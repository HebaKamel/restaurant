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
ALTER Procedure [dbo].[SearchStatus]
(
	@statusId INT = NULL,
	@statusNameEn nvarchar(255) = NULL,
	@statusNameAr nvarchar(255) = NULL,
	@statusColor nvarchar (255) = Null
)
As
BEGIN

SELECT * FROM dineIn_tables_status
	WHERE 1=1 
	AND (@statusId IS NULL OR table_status_id = @statusId)
	AND (@statusNameEn IS NULL OR [table_status_en] LIKE '%'+@statusNameEn+'%')
	AND (@statusNameAr IS NULL OR [table_status_ar] LIKE '%'+@statusNameAr+'%')
	AND (@statusColor IS NULL OR [table_color] LIKE '%'+@statusColor+'%')
	ORDER BY [table_status_id] DESC
END