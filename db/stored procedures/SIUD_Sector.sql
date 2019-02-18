USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_Sector]    Script Date: 20/04/2018 14:24:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SIUD_Sector]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Sec_ID		     	INT = NULL, 
   @Sec_Nombre          VARCHAR(50) = NULL,
   @Sec_EstaActivo      bit = NULL,
   @Mu_ID				INT = NULL
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  0 AS Sec_ID,
						  ' Seleccione' as Sec_Nombre
					UNION 
					SELECT 
						   Sec_ID,
						   Sec_Nombre
					FROM Sector
					WHERE Mu_ID = @Mu_ID Order by Sec_Nombre
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   Sec_ID AS Codigo,
						   Sec_Nombre AS Sector,
						   Mu_Nombre AS Municipio,
						   Pro_Nombre AS Provincia,
						   Sec_EstaActivo
					FROM Sector Se INNER JOIN Municipio Mu
					ON Se.Mu_ID = Mu.Mu_ID INNER JOIN Provincia Pro
					ON Mu.Pro_ID = Pro.Pro_ID

		END
   END
GO


