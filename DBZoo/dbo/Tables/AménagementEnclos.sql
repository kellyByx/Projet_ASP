CREATE TABLE [dbo].[AménagementEnclos] (
    [idAménagementEnclos] INT NOT NULL,
    [idAménagement]       INT IDENTITY (1, 1) NOT NULL,
    [idEnclos]            INT NOT NULL,
    CONSTRAINT [PK_AménagementEnclos] PRIMARY KEY CLUSTERED ([idAménagementEnclos] ASC),
    CONSTRAINT [FK_AménagementEnclos_ToAménagement] FOREIGN KEY ([idAménagement]) REFERENCES [dbo].[Aménagement] ([idAménagement]),
    CONSTRAINT [FK_AménagementEnclos_ToEnclos] FOREIGN KEY ([idEnclos]) REFERENCES [dbo].[Enclos] ([idEnclos])
);

