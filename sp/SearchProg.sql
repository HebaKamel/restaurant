USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[SearchClient]    Script Date: 7/12/2016 8:38:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <12-07-2016>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[SearchProg]

As
BEGIN

SELECT * FROM prog_setting
	WHERE 1=1 and id = 1;
END