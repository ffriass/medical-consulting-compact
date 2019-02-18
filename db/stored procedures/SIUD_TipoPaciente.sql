USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_TipoPaciente]    Script Date: 20/04/2018 14:25:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SIUD_TipoPaciente]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Gen_ID		     	INT = NULL, 
   @TP_Descripcion  VARCHAR(15) = NULL 
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
					SELECT  
						  0 AS TP_ID,
						  ' Seleccione' as TP_Descripcion
					UNION 
					SELECT 
						   TP_ID,
						   TP_Descripcion
					FROM Tipo_Paciente Order by TP_Descripcion
						
		END

		ELSE IF (@Sub_Control = 2)
		BEGIN
					SELECT 
						   TP_ID,
						   TP_Descripcion
					FROM Tipo_Paciente

		END
   END
GO


