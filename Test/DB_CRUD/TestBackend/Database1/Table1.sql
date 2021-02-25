CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[FirstName] VARCHAR(max) NOT NULL,
	[LastName] VARCHAR(max) NOT NULL,
	[City] VARCHAR(max) NOT NULL,
	[YearlySalary] BIGINT
)
