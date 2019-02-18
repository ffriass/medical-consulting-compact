USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_EstadoCivil]    Script Date: 21/11/2018 11:39:45 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SIUD_EstadoCivil]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Gen_ID		     	INT = NULL, 
   @Est_Descripcion  VARCHAR(15) = NULL 
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  0 AS Est_ID,
						  'Seleccione' as Est_Descripcion
					UNION 
					SELECT 
						   Est_ID,
						   Est_Descripcion
					FROM Estado_Civil
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   Est_ID,
						   Est_Descripcion
					FROM Estado_Civil

		END
   END
GO

