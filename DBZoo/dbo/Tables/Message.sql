CREATE TABLE [dbo].[Message] (
    [IdMessage]   INT            IDENTITY (1, 1) NOT NULL,
    [Nom]         NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (323) NOT NULL,
    [Sujet]       NVARCHAR (50)  NOT NULL,
    [Information] NVARCHAR (MAX) NOT NULL,
    [DateEnvoie]  DATETIME       NOT NULL ,
    CONSTRAINT [PK__Message__47AAF304980DDA3D] PRIMARY KEY CLUSTERED ([IdMessage] ASC)
);





