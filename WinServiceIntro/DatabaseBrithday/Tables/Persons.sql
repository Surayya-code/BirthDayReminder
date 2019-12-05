CREATE TABLE [dbo].[Persons]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
	[Birthday] date null,
	[Message] nvarchar(200),
    [StatusId] TINYINT NULL default 1, 
    [SendDate] DATETIME  null 
)
