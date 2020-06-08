CREATE TABLE [dbo].[StorySummary] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ResourceURI] NVARCHAR (600) NULL,
    [Name]        NVARCHAR (200) NULL,
    [Type]        NVARCHAR (600) NULL,
    [StoryId]     INT            NOT NULL,
    CONSTRAINT [PK_StorySummary] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StorySummary_Story_StoryId] FOREIGN KEY ([StoryId]) REFERENCES [dbo].[Story] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_StorySummary_StoryId]
    ON [dbo].[StorySummary]([StoryId] ASC);

