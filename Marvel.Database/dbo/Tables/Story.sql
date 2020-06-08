CREATE TABLE [dbo].[Story] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Available]     INT            NULL,
    [Returned]      INT            NULL,
    [CollectionURI] NVARCHAR (200) NULL,
    [CharacterId]   INT            NOT NULL,
    CONSTRAINT [PK_Story] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Story_Character_CharacterId] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Story_CharacterId]
    ON [dbo].[Story]([CharacterId] ASC);

