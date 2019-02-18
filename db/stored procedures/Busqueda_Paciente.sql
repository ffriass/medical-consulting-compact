USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[Busqueda_Paciente]    Script Date: 21/11/2018 11:34:58 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Busqueda_Paciente]
   
   @Control					 VARCHAR(1) = NULL,
   @Sub_Control				 INT = NULL,
   @Pa_ID		     		 INT = NULL, 
   @Pa_Nombre				 VARCHAR(20) = NULL,
   @Pa_Apellido				 VARCHAR(20) = NULL,
   @Pa_Cedula				 VARCHAR(11) = NULL,
   @Pa_FechaNac				 Date = NULL,
   @Pa_FechaConsultaDesde	 DATE = NULL,
   @Pa_FechaConsultaHasta	 DATE = NULL,
   @Pa_FechaNacltaDesde		 DATE = NULL,
   @Pa_FechaNacltaHasta		 DATE = NULL,
   @Busqueda				 VARCHAR(11) = NULL,

   @Domi_ID				INT = NULL,
   @Pa_EstaActivo		bit = NULL,
   @Pa_EstaEliminado	bit = NULL,
   @Est_ID				INT = NULL,
   @Gen_ID				INT = NULL,  
   @Zo_ID				INT = NULL,
   @TP_ID				INT = NULL

  
   AS

   BEGIN 
   --En caso de queramos presentar toda la informacion relacionada por el paciente de aquello no eliminados
			IF(@Sub_Control =  1)
				BEGIN
					SELECT 
						   
						   [Pa_ID], 
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
					ON Pa.Domi_ID = Dom.Domi_ID INNER JOIN Municipio Mu
					ON Mu.Mu_ID = Dom.Mu_ID INNER JOIN Provincia Pro
					ON Pro.Pro_ID = Mu.Pro_ID 
					WHERE Pa_EstaEliminado = 0 ORDER BY Pa_Nombre
											
				END
			ELSE IF(@Sub_Control =  2)
				BEGIN
					SELECT 
						   [Pa_ID], 
						   [Pa_Nombre], 
						   [Pa_Apellido], 
						   [Pa_Cedula],
						   Gen.[Gen_ID],
						   [Pa_FechaNac], 
						   [Pa_FechaAlta],
						   [Pa_Telefono], 
						   [Pa_Celular], 
						   [Pa_Email], 
						   Zo.[Zo_ID],
						   TP.[TP_ID],
						   Est.[Est_ID],
						   Pa.[Domi_ID],
						   [Domi_Calle],
						   [Domi_Sector],
						   Do.Domi_Numero,
						   Mu.[Mu_ID],
						   Pro.[Pro_ID]
						 FROM Paciente Pa INNER JOIN Genero Gen 
						 ON Pa.Gen_ID = Gen.Gen_ID INNER JOIN Estado_Civil Est
						 ON Pa.Est_ID = Est.Est_ID INNER JOIN Zona Zo 
						 ON Pa.Zo_ID  = Zo.Zo_ID INNER JOIN Tipo_Paciente TP
						 ON Pa.TP_ID = TP.TP_ID INNER JOIN Domicilio Do
						 ON Pa.Domi_ID = Do.Domi_ID INNER JOIN Municipio Mu
						 ON Do.Mu_ID = Mu.Mu_ID INNER JOIN Provincia Pro
						 ON Mu.Pro_ID = Pro.Pro_ID
						 WHERE (Pa_ID LIKE @Busqueda OR Pa_Cedula LIKE @Busqueda) AND Pa.Pa_EstaEliminado = 0
				END

				IF(@Sub_Control =  3)
				BEGIN
					SELECT 
						   
						   [Pa_ID], 
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
						   [Domi_Numero],
						   [Mu_Nombre],
						   [Pro_Nombre]
						   
				    FROM Paciente Pa INNER JOIN Zona Zo
					ON Pa.Zo_ID = Zo.Zo_ID INNER JOIN Tipo_Paciente TP
					ON Pa.TP_ID = TP.TP_ID INNER JOIN Estado_Civil ET
					ON Pa.Est_ID = ET.Est_ID INNER JOIN Genero Gen
					ON Pa.Gen_ID = Gen.Gen_ID INNER JOIN Domicilio Dom
					ON Pa.Domi_ID = Dom.Domi_ID INNER JOIN Municipio Mu
					ON Mu.Mu_ID = Dom.Mu_ID INNER JOIN Provincia Pro
					ON Pro.Pro_ID = Mu.Pro_ID 
					WHERE (Pa_ID LIKE @Busqueda OR Pa_Cedula LIKE @Busqueda OR Pa_Nombre LIKE '%'+@Busqueda+'%'
						   OR Pa_Apellido LIKE '%'+@Busqueda+'%') AND  Pa_EstaEliminado = 0
											
				END
	END
GO

