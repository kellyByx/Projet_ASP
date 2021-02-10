CREATE TABLE [dbo].[Parrainage] (
    [idParrainage]      INT  IDENTITY (1, 1) NOT NULL,
    [DateDebut]         DATE NOT NULL,
    [DateFin]           DATE NULL,
    [idParrain]         INT  NOT NULL,
    [idCaractéristique] INT  NOT NULL,
    CONSTRAINT [PK_Parrainage] PRIMARY KEY CLUSTERED ([idParrainage] ASC),
    CONSTRAINT [FK_Parrainage_ToCaractéristique] FOREIGN KEY ([idCaractéristique]) REFERENCES [dbo].[Caractéristique] ([idCaractéristique]),
    CONSTRAINT [FK_Parrainage_ToParrain] FOREIGN KEY ([idParrain]) REFERENCES [dbo].[Parrain] ([idParrain])
);

