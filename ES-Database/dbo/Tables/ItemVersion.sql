CREATE TABLE [dbo].[ItemVersion] (
    [Id]               INT             NOT NULL,
    [Name]             VARCHAR (200)   NOT NULL,
    [ImgPath]          VARCHAR (200)   NOT NULL,
    [ShortDescription] VARCHAR (500)   NOT NULL,
    [Price]            DECIMAL (18, 2) NOT NULL,
    [ShippingPrice]    DECIMAL (18, 2) NOT NULL,
    [Obsolete]         BIT             NOT NULL,
    CONSTRAINT [PK_ItemVersion] PRIMARY KEY CLUSTERED ([Id] ASC)
);

