CREATE TABLE [dbo].[Alimentation] (
    [idAlimentation] INT IDENTITY (1, 1) NOT NULL,
    [idAnimal]       INT NOT NULL,
    [idAliment]      INT NOT NULL,
    CONSTRAINT [PK_Alimentation] PRIMARY KEY CLUSTERED ([idAlimentation] ASC),
    CONSTRAINT [FK_Alimentation_ToAliment] FOREIGN KEY ([idAliment]) REFERENCES [dbo].[Aliment] ([idAliment]),
    CONSTRAINT [FK_Alimentation_ToAnimal] FOREIGN KEY ([idAnimal]) REFERENCES [dbo].[Animal] ([idAnimal])
);

