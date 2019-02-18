USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_Provincia]    Script Date: 20/04/2018 14:24:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SIUD_Provincia]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Pro_ID		     	INT = NULL, 
   @Pro_Nombre          VARCHAR(30) = NULL,
   @Pro_EstaActivo      bit = true
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  0 AS Pro_ID,
						  ' Seleccione' as Pro_Nombre
					UNION 
					SELECT 
						   Pro_ID,
						   Pro_Nombre
					FROM Provincia Order by Pro_Nombre Asc
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   Pro_ID,
						   Pro_Nombre,
						   Pro_EstaActivo
					FROM Provincia Order by Pro_Nombre Asc

		END
   END
GO


