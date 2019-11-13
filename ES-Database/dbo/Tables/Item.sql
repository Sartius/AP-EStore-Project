CREATE TABLE [dbo].[Item] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [Code]     INT NOT NULL,
    [IsActive] BIT NOT NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Item_ItemVersion] FOREIGN KEY ([Code]) REFERENCES [dbo].[ItemVersion] ([Id])
);



