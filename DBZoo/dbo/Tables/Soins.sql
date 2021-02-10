CREATE TABLE [dbo].[Soins] (
    [idSoins]           INT  IDENTITY (1, 1) NOT NULL,
    [DateDebut]         DATE NOT NULL,
    [DateFin]           DATE NOT NULL,
    [idTraitement]      INT  NOT NULL,
    [idSoigneur]        INT  NOT NULL,
    [idCaractéristique] INT  NOT NULL,
    CONSTRAINT [PK_Soins] PRIMARY KEY CLUSTERED ([idSoins] ASC),
    CONSTRAINT [FK_Soins_ToCaractéristique] FOREIGN KEY ([idCaractéristique]) REFERENCES [dbo].[Caractéristique] ([idCaractéristique]),
    CONSTRAINT [FK_Soins_ToSoigneur] FOREIGN KEY ([idSoigneur]) REFERENCES [dbo].[Soigneur] ([idSoigneur]),
    CONSTRAINT [FK_Soins_ToTraitement] FOREIGN KEY ([idTraitement]) REFERENCES [dbo].[Traitement] ([idTraitement])
);

