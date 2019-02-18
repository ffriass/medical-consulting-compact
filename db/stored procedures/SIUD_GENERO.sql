USE [Consultorio_DB]
GO
/****** Object:  StoredProcedure [dbo].[SIUD_GENERO]    Script Date: 20/04/2018 14:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SIUD_GENERO]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Gen_ID		     	INT = NULL, 
   @Descripcion_Genero  VARCHAR(15) = NULL 
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  '0' AS Gen_ID,
						  'Seleccione' as Gen_Descripcion
					UNION 
					SELECT 
						   Gen_ID,
						   Gen_Descripcion
					FROM Genero
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   Gen_ID,
						   Gen_Descripcion
					FROM Genero

		END
   END
