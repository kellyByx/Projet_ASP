CREATE TABLE [dbo].[Traitement] (
    [idTraitement] INT           IDENTITY (1, 1) NOT NULL,
    [Nom]          NVARCHAR (50) NOT NULL,
    [Fréquence]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Traitement] PRIMARY KEY CLUSTERED ([idTraitement] ASC)
);

