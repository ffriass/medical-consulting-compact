USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_ConsultaCompleta]    Script Date: 21/11/2018 11:38:31 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SIUD_ConsultaCompleta]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
  
   @Con_ID              INT = NULL,
   @Con_Fecha           Date = NULL,
   @Con_Hora			TIME = NULL,
   @Con_Motivo			VARCHAR(60) = NULL,
   @Con_Historial		VARCHAR(500) = NULL,
   @Con_Seguimiento		BIT = NULL,
   @Pa_ID		     	INT = NULL, 
   @Doc_ID		     	INT = NULL,


   @Dia_ID				INT = NULL,
   @Dia_Descripcion		VARCHAR(500) = NULL,

   @Exa_ID				INT = NULL,
   @Exa_Descripcion		VARCHAR(500) = NULL,

   @Trat_ID				INT = NULL,
   @Trat_Descripcion	VARCHAR(500) = NULL,


   @CondF_ID			INT = NULL,
   @CondF_Peso			INT = NULL,
   @Cond_Talla			INT = NULL,
   @CondF_IndiceMC		INT = NULL,
   @CondF_Temp			INT = NULL,
   @CondF_Sistolica		INT = NULL,  
   @CondF_Diastolica	INT = NULL  
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
		
					SELECT 
						   
						  *
						   
					FROM CondicionFisica
											
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

		INSERT INTO [dbo].[Diagnostico]
           ( 
		   [Dia_Descripcion], 
		   [Con_ID]
		   )
     VALUES
		(
		   @Dia_Descripcion,
		   @Con_ID
		  )	

	
		INSERT INTO [dbo].[Tratamiento]
           ( 
		 [Trat_Descripcion], 
		 [Con_ID]
		   )
     VALUES
		(
		   @Trat_Descripcion,
		   @Con_ID
		  )
	
	INSERT INTO [dbo].[ExamenFisico]
           ( 
			[Exa_Descripcion], 
			[Con_ID]
		   )
     VALUES
		(
		   @Exa_Descripcion,
		   @Con_ID
		  )
	
	
	INSERT INTO [dbo].[CondicionFisica]
           ( 
			[CondF_Peso], 
			[Cond_Talla], 
			[CondF_IndiceMC], 
			[CondF_Temp], 
			[CondF_Sistolica], 
			[CondF_Diastolica], 
			[Exa_ID]
		   )
     VALUES
		(
		   @CondF_Peso,
		   @Cond_Talla,
		   @CondF_IndiceMC,
		   @CondF_Temp,
		   @CondF_Sistolica,
		   @CondF_Diastolica,
		   @Exa_ID
		  )


		
END
GO

