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
CREATE Procedure [dbo].[addStatus]
(
	@statusNameEn nvarchar(255),
	 @statusNameAr nvarchar(255),
	@statusColor nvarchar(255),
	@statusId int out
)
As
Begin
INSERT INTO [dbo].[dineIn_tables_status]
	VALUES (@statusNameEn, @statusNameAr,@statusColor);
SET @statusId = SCOPE_IDENTITY();
END