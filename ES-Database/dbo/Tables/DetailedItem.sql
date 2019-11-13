CREATE TABLE [dbo].[DetailedItem] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [CodeId]        INT            NOT NULL,
    [DatePublished] DATETIME       NOT NULL,
    [Condition]     INT            NOT NULL,
    [Gender]        INT            NOT NULL,
    [Colour]        INT            NOT NULL,
    [Model]         NVARCHAR (200) NOT NULL,
    [PublishedBy]   INT            NOT NULL,
    [ShippingFrom]  VARCHAR (200)  NOT NULL,
    CONSTRAINT [PK_DetailedItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DetailedItem_ItemVersion] FOREIGN KEY ([CodeId]) REFERENCES [dbo].[ItemVersion] ([Id])
);



