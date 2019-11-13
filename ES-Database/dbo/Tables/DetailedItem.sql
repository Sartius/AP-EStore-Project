CREATE TABLE [dbo].[DetailedItem] (
    [Id]            INT        NOT NULL,
    [ProductId]     INT        NOT NULL,
    [DatePublished] DATETIME   NULL,
    [Condition]     NCHAR (10) NULL,
    [Gender]        NCHAR (10) NULL,
    [Colour]        NCHAR (10) NULL,
    [Model]         NCHAR (10) NULL,
    [PublishedBy]   NCHAR (10) NULL,
    [ShippingFrom]  NCHAR (10) NULL,
    CONSTRAINT [PK_DetailedItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DetailedItem_Item] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Item] ([Id])
);

