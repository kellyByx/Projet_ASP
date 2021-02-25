CREATE TABLE [dbo].[Caractéristique] (
    [idCaractéristique] INT             IDENTITY (1, 1) NOT NULL,
    [DateNaissance]     DATE            NOT NULL,
    [DateDécè]          DATE            NULL,
    [Poid]              DECIMAL (18, 2) NOT NULL,
    [Taille]            FLOAT (53)      NOT NULL,
    [Description]       NVARCHAR (MAX)  NOT NULL,
    [idAnimal]          INT             NOT NULL,
    [photo]             NVARCHAR (250)  NOT NULL,
    CONSTRAINT [PK_Caractéristique] PRIMARY KEY CLUSTERED ([idCaractéristique] ASC),
    CONSTRAINT [FK_Caractéristique_ToAnimal] FOREIGN KEY ([idAnimal]) REFERENCES [dbo].[Animal] ([idAnimal])
);



