USE [Consultorio_DB]
GO
/****** Object:  StoredProcedure [dbo].[SIUD_GENERO]    Script Date: 12/12/2018 7:00:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Dashboard]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Busqueda		    VARCHAR = NULL

   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)					
					SELECT 
						   Count(*)
					FROM Usuario	

			ELSE IF (@Sub_Control = 2)
					SELECT 
						   Count(*)
					FROM Usuario	
		END
						
END		

