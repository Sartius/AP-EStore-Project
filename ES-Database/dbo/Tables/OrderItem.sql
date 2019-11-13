CREATE TABLE [dbo].[OrderItem] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [OrderId]   INT NOT NULL,
    [ProductId] INT NOT NULL,
    [Quantity]  INT NOT NULL,
    CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderItem_ItemVersion] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[ItemVersion] ([Id]),
    CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id])
);



