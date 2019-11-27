CREATE TABLE [dbo].[User] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (100) NOT NULL,
    [Password] VARCHAR (100) NOT NULL,
    [Role]     INT           NOT NULL,
	[Pepper]   VARCHAR (100) NULL,
    CONSTRAINT [PK_UserList] PRIMARY KEY CLUSTERED ([Id] ASC)
);



