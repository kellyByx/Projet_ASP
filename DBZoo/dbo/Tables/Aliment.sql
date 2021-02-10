CREATE TABLE [dbo].[Aliment] (
    [idAliment] INT             IDENTITY (1, 1) NOT NULL,
    [Nom]       NVARCHAR (50)   NOT NULL,
    [Quantité]  DECIMAL (19, 2) NOT NULL,
    [Photo]     NVARCHAR (250)  NOT NULL,
    CONSTRAINT [PK_Aliment] PRIMARY KEY CLUSTERED ([idAliment] ASC)
);

