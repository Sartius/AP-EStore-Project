CREATE TABLE [dbo].[Cart] (
    [id]              INT      IDENTITY (1, 1) NOT NULL,
    [userId]          INT      NOT NULL,
    [DateLastUpdated] DATETIME NOT NULL,
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Cart_User] FOREIGN KEY ([userId]) REFERENCES [dbo].[User] ([Id])
);

