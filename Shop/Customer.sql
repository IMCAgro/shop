﻿CREATE TABLE [dbo].[Customer]
(
	[Id] UNIQUEIDENTIFIER NOT NULL , 
    [Number] NVARCHAR(MAX) NOT NULL, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Balance] MONEY NOT NULL, 
    [Pin] NVARCHAR(100) NULL, 
    CONSTRAINT [PK_Customer] PRIMARY KEY ([Id])
)
