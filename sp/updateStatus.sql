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
CREATE Procedure [dbo].[updateStatus]
(
	@statusNameEn nvarchar(255),
	 @statusNameAr nvarchar(255),
	@statusColor nvarchar(255),
	@statusId int out
)
As
Begin
UPDATE dineIn_tables_status SET [table_status_en] = @statusNameEn, [table_status_ar] = @statusNameAr , [table_color]= @statusColor
	WHERE [table_status_id] = @statusId

RETURN @@ERROR
END