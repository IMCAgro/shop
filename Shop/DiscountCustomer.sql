﻿CREATE TABLE [dbo].[DiscountCustomer]
(
	[Id] UNIQUEIDENTIFIER NOT NULL , 
    [DiscountId] UNIQUEIDENTIFIER NOT NULL, 
    [CustomerId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [PK_DiscountCustomer] PRIMARY KEY ([Id])
)
