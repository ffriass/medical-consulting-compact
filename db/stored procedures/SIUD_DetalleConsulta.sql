USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_DetalleConsulta]    Script Date: 21/11/2018 11:38:53 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SIUD_DetalleConsulta]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   
   @Dia_ID				INT = NULL,
   @Dia_Descripcion		VARCHAR(500) = NULL,

   @Exa_ID				INT = NULL,
   @Exa_Descripcion		VARCHAR(500) = NULL,

   @Trat_ID				INT = NULL,
   @Trat_Descripcion	VARCHAR(500) = NULL,
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

----------------------------------------------------EXAMEN FISICO
			INSERT INTO [dbo].Diagnostico
			   (
			   Dia_Descripcion, 
			   [Con_ID]
			   )
			VALUES
			  (
			   @Dia_Descripcion,
			   @Con_ID
			   )
----------------------------------------------------Tratamiento
			INSERT INTO [dbo].Tratamiento
			   (
			   Trat_Descripcion, 
			   [Con_ID]
			   )
			VALUES
			  (
			   @Trat_Descripcion,
			   @Con_ID
			   )
----------------------------------------------------EXAMEN FISICO
			
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



				  UPDATE [dbo].Tratamiento
				  SET
					Trat_Descripcion       =@Trat_Descripcion
     
				  WHERE Con_ID =@Con_ID

				    UPDATE [dbo].Diagnostico
				  SET
					@Exa_Descripcion       =@Exa_Descripcion
     
				  WHERE Con_ID =@Con_ID
		END

END
GO

