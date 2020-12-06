UPDATE [Clients] 
SET [Clients].[FirstName] = @FirstName, 
[Clients].[SecondName] = @SecondName, 
[Clients].[LastName] = @LastName, 
[Clients].[ContactNumber] = @ContactNumber, 
[Clients].[IsLead] = @IsLead, 
[Clients].[IsDeleted] = @IsDeleted 
WHERE [Clients].[ID] = @ID;