CREATE TABLE [dbo].[ExpensesCategory]
(
	[ExpensesCategoryId] INT NOT NULL PRIMARY KEY, 
    [ExpensesCategoryName] NVARCHAR(50) NOT NULL, 
    [UserCreatedId] INT NOT NULL, 
    [GroupId] INT NOT NULL, 
    CONSTRAINT [FK_ExpensesCategory_User] FOREIGN KEY ([UserCreatedId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_ExpensesCategory_Group] FOREIGN KEY ([GroupId]) REFERENCES [UserGroup]([UserGroupId]), 
    
)
