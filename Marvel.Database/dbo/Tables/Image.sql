CREATE TABLE [dbo].[Image] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [Path]               NVARCHAR (400) NULL,
    [Extension]          NVARCHAR (400) NULL,
    [CurrentCharacterId] INT            NOT NULL,
    CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Image_Character_CurrentCharacterId] FOREIGN KEY ([CurrentCharacterId]) REFERENCES [dbo].[Character] ([Id]) ON DELETE CASCADE
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Image_CurrentCharacterId]
    ON [dbo].[Image]([CurrentCharacterId] ASC);

