CREATE TABLE [dbo].[Parrain] (
    [idParrain] INT            IDENTITY (1, 1) NOT NULL,
    [Nom]       NVARCHAR (50)  NOT NULL,
    [Prénom]    NVARCHAR (50)  NOT NULL,
    [Mail]      NVARCHAR (256) NOT NULL,
    [Téléphone] NVARCHAR (16)  NOT NULL,
    CONSTRAINT [PK_Parrain] PRIMARY KEY CLUSTERED ([idParrain] ASC)
);

