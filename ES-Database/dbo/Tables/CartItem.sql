CREATE TABLE [dbo].[CartItem] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [CartId]      INT NOT NULL,
    [ProductCode] INT NOT NULL,
    [Quantity]    INT NOT NULL,
    CONSTRAINT [PK_CartItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CartItem_Cart] FOREIGN KEY ([CartId]) REFERENCES [dbo].[Cart] ([id]),
    CONSTRAINT [FK_CartItem_ItemVersion] FOREIGN KEY ([ProductCode]) REFERENCES [dbo].[ItemVersion] ([Id])
);



