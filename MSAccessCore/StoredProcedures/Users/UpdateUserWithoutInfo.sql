UPDATE [User] 
SET [User].[Login] = @Login, 
[User].[Password] = @Password, 
[User].[UserInfoID] = null, 
[User].[PositionID] = @PositionID 
WHERE [User].[ID] = @ID;