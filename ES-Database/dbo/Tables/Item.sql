CREATE TABLE [dbo].[Item] (
    [Id]               INT             NOT NULL,
    [Code]             INT             NOT NULL,
    [IsActive]         BIT             NULL,
    [Name]             NCHAR (10)      NULL,
    [ImgPath]          NCHAR (10)      NULL,
    [ShortDescription] NCHAR (100)     NULL,
    [Price]            DECIMAL (18, 2) NULL,
    [ShippingPrice]    DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Id] ASC)
);

