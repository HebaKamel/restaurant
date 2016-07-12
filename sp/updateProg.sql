USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[updateClient]    Script Date: 7/12/2016 8:40:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba>
-- Create date: <12-07-2016>
-- Description:	<Description,,>

-- =============================================
CREATE Procedure [dbo].[updateProg]
(
	@nameEn nvarchar(255) = NULL,
	@nameAr nvarchar(255) = NULL,
	@addressEn nvarchar(255) = NULL,
	@addressAr nvarchar(255) = NULL,
	@telephoneNo nvarchar(255) = NULL,
	@mobileNo nvarchar(255) = NULL,
	@website nvarchar(255) = NULL,
	@resetFooter nvarchar(255) = Null,
	@logoPath nvarchar(255) = Null
)
As
Begin
UPDATE prog_setting SET name_en = @nameEn, name_ar = @nameAr, 
				   address_en = @addressEn, address_ar = @addressAr,
				   telephone_no = @telephoneNo, mobile_no = @mobileNo , website = @website, reset_footer = @resetFooter, logo = @logoPath
	WHERE id = 1
--DECLARE @Returns BIT 
--IF @@ERROR = 0
--	SET @Returns = -1  
--ELSE
--	SET @Returns = 1  

RETURN @@ERROR
END