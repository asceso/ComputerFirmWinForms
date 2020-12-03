UPDATE [User] 
SET [User].[Login] = @Login, 
[User].[Password] = @Password, 
[User].[UserInfoID] = @UserInfoID, 
[User].[PositionID] = @PositionID 
WHERE [User].[ID] = @ID;