SELECT [Permission].*
FROM [Position] INNER JOIN ([Permission] INNER JOIN [PositionPermission] 
ON [Permission].[ID] = [PositionPermission].[PermissionID]) 
ON [Position].[ID] = [PositionPermission].[PositionID] 
WHERE [Position].[ID]=@ID;
