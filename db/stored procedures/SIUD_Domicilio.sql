USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_Domicilio]    Script Date: 21/11/2018 11:39:16 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SIUD_Domicilio]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Domi_ID			    INT = NULL, 
   @Domi_Sector         VARCHAR(60) = NULL,
   @Domi_Calle			VARCHAR(60) = NULL,
   @Domi_Numero			VARCHAR(7) = NULL,
   @Mu_ID			    INT = NULL,
   @Pa_ID				INT = NULL
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
				BEGIN
					SELECT 
						   Dom.Domi_ID,
						   Pa.Pa_Nombre,
						   Domi_Sector,
						   Domi_Calle,
						   Domi_Numero,
						   Mu_Nombre,
						   Pro_Nombre
					FROM Domicilio Dom INNER JOIN Municipio Mu
					ON Dom.Mu_ID = Mu.Mu_ID INNER JOIN Provincia Pro
					ON Mu.Pro_ID = Pro.Pro_ID INNER JOIN Paciente Pa
					ON Dom.Domi_ID = Pa.Domi_ID
					WHERE Pa.Pa_ID = @Pa_ID	
				END

	END

	IF (@Control =  'I')
		BEGIN
			INSERT INTO [dbo].[Domicilio]
			   (
			  [Domi_Sector],
			  [Domi_Calle],
			  [Domi_Numero],
			  [Mu_ID]

			   )
			VALUES
			  (
			   @Domi_Sector,
			   @Domi_Calle,
			   @Domi_Numero, 
			   @Mu_ID
			   )
			
			SELECT Domi_ID
			FROM Domicilio
			WHERE Domi_ID = @@IDENTITY

		END

	IF (@Control =  'U')
		BEGIN
		
			UPDATE [dbo].[Domicilio]
				  SET
					[Domi_Sector]       =@Domi_Sector,
					[Domi_Calle]		=@Domi_Calle,
					[Domi_Numero]	    =@Domi_Numero,
					[Mu_ID]				=@Mu_ID
     
				  WHERE Domi_ID =@Domi_ID
		END

END
GO

