USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_Cita]    Script Date: 21/11/2018 11:36:48 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SIUD_Cita]
   
   @Control				VARCHAR(1) = NULL,
   @Sub_Control         INT = NULL,
   @Busqueda			VARCHAR(6) = NULL,

   @Ci_ID				INT = NULL,
   @Ci_Motivo			VARCHAR(60) = NULL,
   @Ci_Fecha			DATE = NULL,
   @Ci_Hora				TIME = NULL,
   @Ci_Nota				VARCHAR(100) = NULL,
   @Pa_ID				INT = NULL,

   @Desde				DATE = NULL,
   @Hasta				DATE = NULL
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
				BEGIN
					SELECT 
						  Ci_Fecha,
						  Ci_Hora,
						  Ci_Motivo, 
						  Ci_Nota,
						  Pa_ID
					  
					FROM Cita
					WHERE Pa_ID LIKE @Busqueda ORDER BY Ci_Fecha DESC		
				END
		IF(@Sub_Control =  2)
				BEGIN
					SELECT 
						  Ci_Fecha,
						  Ci_Hora,
						  Ci_Motivo, 
						  Ci_Nota,
						  Pa_ID
					  
					FROM Cita
				    ORDER BY Ci_Fecha DESC											
				END			
			IF(@Sub_Control =  3)
				BEGIN
					SELECT 
						  Ci_Fecha,
						  Ci_Hora,
						  Ci_Motivo, 
						  Ci_Nota,
						  Pa_ID
					  
					FROM Cita
				    WHERE Ci_Fecha BETWEEN @Desde AND @Hasta ORDER BY Ci_Fecha DESC											
				END					
		END

 IF (@Control =  'I')
		BEGIN

		INSERT INTO [dbo].Cita
           (
			   [Ci_Motivo]
			   ,[Ci_Fecha]
			   ,[Ci_Hora]
			   ,[Ci_Nota]
			   ,[Pa_ID]
			)
     VALUES
			 (
		   @Ci_Motivo,
		   @Ci_Fecha,
		   @Ci_Hora,
		   @Ci_Nota,
		   @Pa_ID	
			)	
		SELECT 
			Ci_ID 
		FROM Cita
		WHERE Ci_ID = @@IDENTITY

		END

	IF (@Control =  'U')
		BEGIN
		UPDATE Cita
		SET
		Ci_Motivo  = @Ci_Motivo,
		Ci_Fecha = @Ci_Fecha,
		Ci_Hora = @Ci_Hora,
		Ci_Nota = @Ci_Nota,
		Pa_ID = @Pa_ID

		WHERE Ci_ID = @Ci_ID


		END

		IF(@Control = 'D')
	BEGIN
			IF(@Sub_Control =1)
				BEGIN
					UPDATE [dbo].[Cita]
						  SET
							[Ci_EstaEliminado]     = 1
			   
						  WHERE Ci_ID = @Ci_ID
				END
			IF(@Sub_Control = 2)
				BEGIN
					UPDATE [dbo].[Cita]
						  SET
							[Ci_EstaEliminado]     = 0
			   
						  WHERE Ci_ID =@Ci_ID
				END

   END

END
GO

