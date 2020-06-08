CREATE TABLE [dbo].[Character] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100)  NULL,
    [Description] NVARCHAR (2000) NULL,
    [Modified]    DATETIME2 (7)   NOT NULL,
    [ResourceURI] NVARCHAR (100)  NULL,
    CONSTRAINT [PK_Character] PRIMARY KEY CLUSTERED ([Id] ASC)
);

