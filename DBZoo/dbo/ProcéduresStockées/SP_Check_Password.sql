CREATE PROCEDURE [dbo].[SP_Check_Password]
	@login NVARCHAR (16),
	@password NVARCHAR(32)
AS
	DECLARE @hPassword VARBINARY(32)
	DECLARE @salt CHAR(8)
	DECLARE @newPassword VARBINARY(32)
	SELECT @salt = salt, @hPassword = Password FROM Soigneur WHERE login=@login
	SELECT @newPassword = dbo.SF_EncryptedPassword (@password, @salt)

	IF (@newPassword = @hPassword)
	BEGIN 
		SELECT [Login], Nom, Prenom, Specialisation, Email, Telephone, Photo  
		FROM Soigneur 
		WHERE login=@login

	END 