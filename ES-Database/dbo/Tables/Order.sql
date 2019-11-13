CREATE TABLE [dbo].[Order] (
    [Id]         INT             NOT NULL,
    [UserId]     INT             NOT NULL,
    [Date]       DATETIME        NOT NULL,
    [TotalPrice] DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Order_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

