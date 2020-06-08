CREATE TABLE [dbo].[Url] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Type]        NVARCHAR (200) NULL,
    [Url]         NVARCHAR (200) NULL,
    [CharacterId] INT            NOT NULL,
    CONSTRAINT [PK_Url] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Url_Character_CharacterId] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Url_CharacterId]
    ON [dbo].[Url]([CharacterId] ASC);

