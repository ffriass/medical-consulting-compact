USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_Zona]    Script Date: 20/04/2018 14:25:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SIUD_Zona]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Zo_ID		     	INT = NULL, 
   @Zo_Nombre          VARCHAR(50) = NULL,
   @Zo_EstaActivo      bit = true
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  0 AS Zo_ID,
						  ' Seleccione' as Zo_Nombre
					UNION 
					SELECT 
						   Zo_ID,
						   Zo_Nombre
					FROM Zona
					WHERE Zo_EstaActivo = 1 Order by Zo_Nombre
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   Zo_ID,
						   Zo_Nombre,
						   Zo_EstaActivo
					FROM Zona

		END
   END
GO


