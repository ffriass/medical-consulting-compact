USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[SIUD_CondicionFisica]    Script Date: 21/11/2018 11:37:20 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SIUD_CondicionFisica]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,

   @CondF_ID			INT = NULL,
   @CondF_Peso			FLOAT = NULL,
   @Cond_Talla			FLOAT = NULL,
   @CondF_IndiceMC		FLOAT = NULL,
   @CondF_Temp			FLOAT = NULL,
   @CondF_Sistolica		INT = NULL,  
   @CondF_Diastolica	INT = NULL,  
   @Exa_ID				INT = NULL
  
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
		INSERT INTO [dbo].CondicionFisica
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
END
GO

