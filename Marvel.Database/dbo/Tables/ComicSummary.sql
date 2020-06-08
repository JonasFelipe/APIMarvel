CREATE TABLE [dbo].[ComicSummary] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ResourceURI] NVARCHAR (600) NULL,
    [Name]        NVARCHAR (200) NULL,
    [ComicId]     INT            NOT NULL,
    CONSTRAINT [PK_ComicSummary] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ComicSummary_Comic_ComicId] FOREIGN KEY ([ComicId]) REFERENCES [dbo].[Comic] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ComicSummary_ComicId]
    ON [dbo].[ComicSummary]([ComicId] ASC);

