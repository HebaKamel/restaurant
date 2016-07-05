-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
use restaurantPOS;

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create Procedure addUsersRole 
(
	@roleNameEn nvarchar(255),
	@roleId int OUT
)
As
Begin
     insert into users_role values (@roleNameEn, @roleNameEn);
     SET @roleId = SCOPE_IDENTITY();
End
GO
