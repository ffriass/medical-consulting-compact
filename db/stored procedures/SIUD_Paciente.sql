USE [Consultorio_DB]
GO
/****** Object:  StoredProcedure [dbo].[SIUD_Paciente]    Script Date: 21/4/2018 12:34:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SIUD_Paciente]
   
   @Control				VARCHAR(1),
   @Sub_Control         INT = NULL,
   @Pa_ID		     	INT = NULL, 
   @Pa_Nombre           VARCHAR(20) = NULL,
   @Pa_Apellido         VARCHAR(20) = NULL,
   @Pa_Cedula			VARCHAR(11) = NULL,
   @Pa_FechaNac			Date = NULL,
   @Pa_FechaAlta		DATE = NULL,
   @Pa_Telefono			VARCHAR(15) = NULL,
   @Pa_Celular			VARCHAR(15) = NULL,
   @Pa_Email			VARCHAR(60) = NULL,
   @Pa_EstaActivo		bit = NULL,
   @Pa_EstaEliminado	bit = NULL,
   @Zo_ID				INT = NULL,
   @TP_ID				INT = NULL,
   @Est_ID				INT = NULL,
   @Gen_ID				INT = NULL  
  
   AS

   BEGIN 
   IF (@Control =  'S')
		BEGIN
			IF(@Sub_Control =  1)
		
					SELECT 
						   
						   Pa.[Pa_ID], 
						   [Pa_Nombre], 
						   [Pa_Apellido], 
						   [Pa_Cedula],
						   [Gen_Descripcion],
						   [Pa_FechaNac], 
						   [Pa_FechaAlta],
						   [Pa_Telefono], 
						   [Pa_Celular], 
						   [Pa_Email], 
						   [Zo_Nombre],
						   [TP_Descripcion],
						   [Est_Descripcion],
						   [Domi_Calle],
						   [Domi_Sector],
						   Domi_Numero,
						   [Mu_Nombre],
						   [Pro_Nombre]
						   
					FROM Paciente Pa INNER JOIN Zona Zo
					ON Pa.Zo_ID = Zo.Zo_ID INNER JOIN Tipo_Paciente TP
					ON Pa.TP_ID = TP.TP_ID INNER JOIN Estado_Civil ET
					ON Pa.Est_ID = ET.Est_ID INNER JOIN Genero Gen
					ON Pa.Gen_ID = Gen.Gen_ID INNER JOIN Domicilio Dom
					ON Dom.Pa_ID = Pa.Pa_ID INNER JOIN Municipio Mu
					ON Mu.Mu_EstaActivo = Dom.Mu_ID INNER JOIN Provincia Pro
					ON Pro.Pro_EstaActivo = Mu.Mu_ID
											
		END

 IF (@Control =  'I')
		BEGIN
		SELECT @Pa_FechaAlta =  CONVERT(DATETIME, SYSDATETIME())
		INSERT INTO [dbo].[Paciente]
           ([Pa_Nombre]
           ,[Pa_Apellido]
           ,[Pa_Cedula]
           ,[Pa_FechaNac]
           ,[Pa_FechaAlta]
           ,[Pa_Telefono]
           ,[Pa_Celular]
		   ,[Pa_Email]
           ,[Zo_ID]
           ,[TP_ID]
           ,[Est_ID]
           ,[Gen_ID])
     VALUES
           (@Pa_Nombre,
            @Pa_Apellido,
            @Pa_Cedula, 
            @Pa_FechaNac,
            @Pa_FechaAlta,
            @Pa_Telefono,
            @Pa_Celular,
			@Pa_Email,
            @Zo_ID,
		    @TP_ID,
            @Est_ID,
            @Gen_ID)

	SELECT
		  Pa_ID
		  FROM Paciente
		  WHERE Pa_ID = @@IDENTITY
		END

IF (@Control =  'U')
		BEGIN
		--SELECT @Pa_FechaAlta =  CONVERT(DATETIME, SYSDATETIME())
		UPDATE [dbo].[Paciente]
			  SET
				[Pa_Nombre]       =@Pa_Nombre,
			    [Pa_Apellido]	  =@Pa_Apellido,
			    [Pa_Cedula]		  =@Pa_Cedula,
			    [Pa_FechaNac]	  =@Pa_FechaNac,
			    [Pa_Telefono]	  =@Pa_Telefono,
			    [Pa_Celular]	  =@Pa_Celular,
				[Pa_Email]		  =@Pa_Email,
			    [Zo_ID]	          =@Zo_ID,
			    [TP_ID]           =@TP_ID,
			    [Est_ID]		  =@Est_ID,
			    [Gen_ID]		  =@Gen_ID
     
		  WHERE Pa_ID =@Pa_ID

		 END

 IF(@Control = 'D')
	BEGIN
			IF(@Sub_Control =1)
				BEGIN
					UPDATE [dbo].[Paciente]
						  SET
							[Pa_EstaEliminado]     = 1
			   
						  WHERE Pa_ID =@Pa_ID
				END
			IF(@Sub_Control = 2)
				BEGIN
					UPDATE [dbo].[Paciente]
						  SET
							[Pa_EstaEliminado]     = 0
			   
						  WHERE Pa_ID =@Pa_ID
				END

   END

  END

