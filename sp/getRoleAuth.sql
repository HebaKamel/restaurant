USE [restaurantPOS]
GO
/****** Object:  StoredProcedure [dbo].[addRoleAuth]    Script Date: 06/25/2016 20:15:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Heba Kamel>
-- Create date: <25-06-2016,>
-- Description:	<Description,,>
-- =============================================
CREATE Procedure [dbo].[getRoleAuth]
(
	@roleId int,
	@authId int
)
As
Begin
     select * from role_auth where role_id = @roleId and auth_id = @authId
     
End
