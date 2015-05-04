CREATE TABLE [dbo].[UserGroup]
(
	[UserGroupId] INT NOT NULL PRIMARY KEY, 
    [GroupCreaterId] INT NOT NULL, 
    [GroupName] NVARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_UserGroup_ToTable] FOREIGN KEY ([GroupCreaterId]) REFERENCES [Users]([UserId])
)
