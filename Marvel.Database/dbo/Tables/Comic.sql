CREATE TABLE [dbo].[Comic] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Available]     INT            NULL,
    [Returned]      INT            NULL,
    [CollectionURI] NVARCHAR (200) NULL,
    [CharacterId]   INT            NOT NULL,
    CONSTRAINT [PK_Comic] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comic_Character_CharacterId] FOREIGN KEY ([CharacterId]) REFERENCES [dbo].[Character] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Comic_CharacterId]
    ON [dbo].[Comic]([CharacterId] ASC);

