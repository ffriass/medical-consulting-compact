USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_ExamenFisico]    Script Date: 21/11/2018 11:43:45 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SIUD_ExamenFisico]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Exa_ID				INT = NULL,
   @Exa_Descripcion		VARCHAR(500) = NULL,
   @Con_ID				INT = NULL
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
				BEGIN
					SELECT 
						   *
					FROM ExamenFisico
				END

	END

	IF (@Control =  'I')
		BEGIN
			INSERT INTO [dbo].[ExamenFisico]
			   (
			   [Exa_Descripcion], 
			   [Con_ID]
			   )
			VALUES
			  (
			   @Exa_Descripcion,
			   @Con_ID
			   )
			
			SELECT Exa_ID
			FROM [dbo].[ExamenFisico]
			WHERE Exa_ID = @@IDENTITY

		END

	IF (@Control =  'U')
		BEGIN
		
			UPDATE [dbo].[ExamenFisico]
				  SET
					Exa_Descripcion       =@Exa_Descripcion
     
				  WHERE Con_ID =@Con_ID
		END

END
GO

