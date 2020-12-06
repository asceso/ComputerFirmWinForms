UPDATE [Clients] 
SET [Clients].[IsDeleted] = @IsDeleted 
WHERE [Clients].[ID] = @ID;