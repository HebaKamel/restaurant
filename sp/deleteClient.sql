USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addClient]    Script Date: 07/01/2016 21:34:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <01-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[deleteClient]
(
	@clientId INT
)
As
Begin
DELETE from clients WHERE client_id = @clientId
DECLARE @Returns BIT 
IF @@rowcount <> 1
	SET @Returns = -1  
ELSE
	SET @Returns = 1  

RETURN @Returns
END