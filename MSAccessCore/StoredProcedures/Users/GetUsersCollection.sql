SELECT [User].[ID], [User].[Login], [User].[Password], [UserInfo].*, [Position].* 
FROM [Position] INNER JOIN (UserInfo INNER JOIN [User]
ON [UserInfo].[ID] = [User].[UserInfoID])
ON [Position].[ID] = [User].[PositionID];