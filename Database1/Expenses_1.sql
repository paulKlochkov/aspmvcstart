CREATE TABLE [dbo].[Expenses]
(
	[ExpensId] INT NOT NULL PRIMARY KEY, 
    [Amount] DECIMAL NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [ExpensCategoryId] INT NULL, 
    CONSTRAINT [FK_Expenses_ToTable] FOREIGN KEY ([ExpensCategoryId]) REFERENCES [ExpensesCategory]([ExpensesCategoryId])
)

