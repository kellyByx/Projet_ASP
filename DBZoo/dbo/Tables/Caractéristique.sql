CREATE TABLE [dbo].[Caractéristique] (
    [idCaractéristique] INT             IDENTITY (1, 1) NOT NULL,
    [DateNaissance]     DATE            NOT NULL,
    [DateDécè]          DATE            NULL,
    [Poid]              DECIMAL (18, 3) NOT NULL,
    [Description]       NVARCHAR (256)  NOT NULL,
    [idAnimal]          INT             NOT NULL,
    CONSTRAINT [PK_Caractéristique] PRIMARY KEY CLUSTERED ([idCaractéristique] ASC),
    CONSTRAINT [FK_Caractéristique_ToAnimal] FOREIGN KEY ([idAnimal]) REFERENCES [dbo].[Animal] ([idAnimal])
);

