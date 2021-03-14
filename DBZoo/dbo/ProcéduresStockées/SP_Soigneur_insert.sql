CREATE PROCEDURE [dbo].[SP_Soigneur_insert]
    
   @nom             VARCHAR (50),  
    @prenom         VARCHAR (50),   
    @specialisation  VARCHAR (50),   
    @email          NVARCHAR (256), 
    @login          NVARCHAR (32),  
    @password       NVARCHAR (MAX), 
    @telephone      NVARCHAR (16),  
    @photo          NVARCHAR (250)
       
AS
DECLARE @idSoigneur INTEGER, @salt CHAR(8)
	SET @salt = [dbo].SF_GenerateSalt()
	INSERT INTO[Soigneur]([Nom], [Prenom], [Specialisation], [Email], [Login], [Password],[Telephone], [Photo],[Salt])
		   VALUES (@nom, @prenom, @specialisation, @email, @login, dbo.SF_EncryptedPassword(@password, @salt),@telephone, @photo,@salt)
	SET @idSoigneur = @@IDENTITY

 --  ou  DECLARE @idSoigneur INT, @salt CHAR(8)


	
