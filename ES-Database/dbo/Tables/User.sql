CREATE TABLE [dbo].[User] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Role]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_UserList] PRIMARY KEY CLUSTERED ([Id] ASC)
);

