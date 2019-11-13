CREATE TABLE [dbo].[Cart] (
    [id]              NUMERIC      NOT NULL,
    [userId]          INT      NOT NULL,
    [DateLastUpdated] DATETIME NULL,
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Cart_User] FOREIGN KEY ([userId]) REFERENCES [dbo].[User] ([Id])
);

