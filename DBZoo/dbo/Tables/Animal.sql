CREATE TABLE [dbo].[Animal] (
    [idAnimal]        INT           IDENTITY (1, 1) NOT NULL,
    [Nom]             NVARCHAR (50) NOT NULL,
    [NomScientifique] NVARCHAR (64) NULL,
    [Sexe]            NVARCHAR (50) NOT NULL,
    [Race]            NVARCHAR (64) NOT NULL,
    [TypeAlimentaire] VARCHAR (50)  NOT NULL,
    [idEnclos]        INT           NOT NULL,
    CONSTRAINT [PK_Animal] PRIMARY KEY CLUSTERED ([idAnimal] ASC),
    CONSTRAINT [FK_Animal_ToEnclos] FOREIGN KEY ([idEnclos]) REFERENCES [dbo].[Enclos] ([idEnclos])
);

