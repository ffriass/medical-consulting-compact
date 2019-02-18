USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_Consulta]    Script Date: 21/11/2018 11:37:41 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SIUD_Consulta]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
  
   @Con_ID              INT = NULL,
   @Con_Fecha           Date = NULL,
   @Con_Hora			TIME = NULL,
   @Con_Motivo			VARCHAR(60) = NULL,
   @Con_Historial		VARCHAR(500) = NULL,
   @Con_Seguimiento		BIT = NULL,
   @Pa_ID		     	INT = NULL, 
   @Doc_ID		     	INT = NULL
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
		
					SELECT 
						   
						  *
						   
					FROM Consulta
											
		END

 IF (@Control =  'I')
		BEGIN
		--SELECT @Pa_FechaAlta =  CONVERT(DATETIME, SYSDATETIME())
		INSERT INTO [dbo].[Consulta]
           (
		    [Con_Fecha], 
			[Con_Hora], 
			[Con_Motivo], 
			[Con_Historial], 
			[Con_Seguimiento], 
			[Pa_ID], 
			[Doc_ID]
			)
     VALUES
   (
		   @Con_Fecha,
		   @Con_Hora,
		   @Con_Motivo,
		   @Con_Historial,
		   @Con_Seguimiento,
		   @Pa_ID,
		   @Doc_ID	
		  )	

		 SELECT 
			   Con_ID 
		FROM Consulta
		WHERE Con_ID = @@IDENTITY	
			  
	END


END
GO

