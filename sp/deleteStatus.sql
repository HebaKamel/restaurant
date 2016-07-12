USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[deleteClient]    Script Date: 07/02/2016 04:43:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <02-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[deleteStatus]
(
	@statusId INT
)
As
Begin
DELETE from dineIn_tables_status WHERE [table_status_id] = @statusId
DECLARE @Returns BIT 
IF @@rowcount <> 1
	SET @Returns = -1  
ELSE
	SET @Returns = 1  

RETURN @Returns
END