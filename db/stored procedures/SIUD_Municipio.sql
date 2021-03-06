USE [Consultorio_DB]
GO
/****** Object:  StoredProcedure [dbo].[SIUD_Municipio]    Script Date: 20/04/2018 14:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SIUD_Municipio]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Mu_ID		     	INT = NULL, 
   @Mu_Nombre          VARCHAR(30) = NULL,
   @Mu_EstaActivo      bit = NULL,
   @Pro_ID				INT = NULL
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  0 AS Mu_ID,
						  ' Seleccione' as Mu_Nombre
					UNION 
					SELECT 
						   Mu_ID,
						   Mu_Nombre
					FROM Municipio
					WHERE Pro_ID = @Pro_ID order by Mu_Nombre
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   Mu_ID AS Codigo,
						   Mu_Nombre AS Municipio,
						   Pro_Nombre AS Provincia,
						   Mu_EstaActivo AS Estado
					FROM Municipio Mu INNER JOIN Provincia Pro
					ON Mu.Pro_ID = Pro.Pro_ID order by Mu_Nombre ASC

		END
   END
