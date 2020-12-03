UPDATE [UserInfo] 
SET [UserInfo].[FirstName] = @FirstName, 
[UserInfo].[SecondName] = @SecondName, 
[UserInfo].[LastName] = @LastName, 
[UserInfo].[ContactNumber] = @ContactNumber 
WHERE [UserInfo].[ID] = @ID;