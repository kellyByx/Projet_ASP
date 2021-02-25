CREATE TABLE [dbo].[Soigneur] (
    [idSoigneur]     INT            IDENTITY (1, 1) NOT NULL,
    [Nom]            VARCHAR (50)   NOT NULL,
    [Prenom]         VARCHAR (50)   NOT NULL,
    [Specialisation] VARCHAR (50)   NOT NULL,
    [Email]          NVARCHAR (256) NOT NULL,
    [Login]          NVARCHAR (32)  NOT NULL,
    [Password]       VARBINARY (50) NULL,
    [Telephone]      NVARCHAR (16)  NOT NULL,
    [Photo]          NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Soigneur] PRIMARY KEY CLUSTERED ([idSoigneur] ASC)
);



