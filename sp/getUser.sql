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
create Procedure [dbo].[getUser]
(
	@userName nvarchar(255),
	@userPass nvarchar(255)
)
As
Begin
     select * from users where users_name = @userName and users_pass = @userPass and is_active = 1
End
