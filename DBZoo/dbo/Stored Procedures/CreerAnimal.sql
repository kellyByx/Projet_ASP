
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE CreerAnimal 
	-- Add the parameters for the stored procedure here
	@Nom nvarchar(50)
           ,@Sexe nvarchar(50)
           ,@TypeAlimentaire varchar(50)
           ,@Famille nvarchar(64)
           ,@class nvarchar(64)
           ,@Espèce nvarchar(64)
           ,@idEnclos int
		   ,@DateNaissance date
           ,@DateDécè date
           ,@Poid decimal(18,2)
           ,@Taille float
           ,@Description nvarchar(max)
         
           ,@photo nvarchar(250)
AS
BEGIN
  declare @idAnimal int

	INSERT INTO [dbo].[Animal]
           ([Nom]
           ,[Sexe]
           ,[TypeAlimentaire]
           ,[Famille]
           ,[class]
           ,[Espèce]
           ,[idEnclos])
     VALUES
           (@Nom 
           ,@Sexe 
           ,@TypeAlimentaire 
           ,@Famille 
           ,@class 
           ,@Espèce
           ,@idEnclos )

	SET   @idAnimal = @@IDENTITY
    INSERT INTO [dbo].[Caractéristique]
           ([DateNaissance]
           ,[DateDécè]
           ,[Poid]
           ,[Taille]
           ,[Description]
           ,[idAnimal]
           ,[photo])
     VALUES
           (@DateNaissance 
           ,@DateDécè
           ,@Poid 
           ,@Taille 
           ,@Description 
           ,@idAnimal 
           ,@photo )
END