UPDATE [RequestTypes] 
SET [RequestTypes].[RequestName] = @RequestName, 
[RequestTypes].[Description] = @Description
WHERE [RequestTypes].[ID] = @ID;