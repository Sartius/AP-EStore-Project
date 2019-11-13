CREATE TABLE [dbo].[CartItem] (
    [Id]          INT NOT NULL,
    [CartId]      INT NULL,
    [ProductCode] INT NULL,
    [Quantity]    INT NULL,
    CONSTRAINT [PK_CartItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CartItem_Cart] FOREIGN KEY ([CartId]) REFERENCES [dbo].[Cart] ([id])
);

