CREATE TABLE [dbo].[EventSummary] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ResourceURI] NVARCHAR (600) NULL,
    [Name]        NVARCHAR (200) NULL,
    [EventId]     INT            NOT NULL,
    CONSTRAINT [PK_EventSummary] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventSummary_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_EventSummary_EventId]
    ON [dbo].[EventSummary]([EventId] ASC);

