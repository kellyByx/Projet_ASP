CREATE TABLE [dbo].[Enclos] (
    [idEnclos]           INT             IDENTITY (1, 1) NOT NULL,
    [Superficie]         DECIMAL (18, 2) NOT NULL,
    [CapacitéOccupation] INT             NOT NULL,
    CONSTRAINT [PK_Enclos] PRIMARY KEY CLUSTERED ([idEnclos] ASC)
);

