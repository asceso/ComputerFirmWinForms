UPDATE [Position] 
SET [Position].[Name] = @Name, 
[Position].[Description] = @Description
WHERE [Position].[ID] = @ID;