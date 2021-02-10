CREATE TABLE [dbo].[Aménagement] (
    [idAménagement] INT           IDENTITY (1, 1) NOT NULL,
    [Libelle]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Aménagement] PRIMARY KEY CLUSTERED ([idAménagement] ASC)
);

