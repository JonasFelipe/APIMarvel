CREATE TABLE [dbo].[SerieSummary] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ResourceURI] NVARCHAR (600) NULL,
    [Name]        NVARCHAR (200) NULL,
    [SerieId]     INT            NOT NULL,
    CONSTRAINT [PK_SerieSummary] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SerieSummary_Serie_SerieId] FOREIGN KEY ([SerieId]) REFERENCES [dbo].[Serie] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_SerieSummary_SerieId]
    ON [dbo].[SerieSummary]([SerieId] ASC);

