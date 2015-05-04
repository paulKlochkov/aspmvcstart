CREATE TABLE [dbo].[UserExpenses]
(
	[UserExpensesId] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [ExpensId] INT NOT NULL, 
    CONSTRAINT [FK_UserExpenses_Users] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]), 
    CONSTRAINT [FK_UserExpenses_Expenses] FOREIGN KEY ([ExpensId]) REFERENCES [Expenses]([ExpensId])
)
