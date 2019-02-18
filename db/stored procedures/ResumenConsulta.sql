USE [Consultorio_DB]
GO

/****** Object:  StoredProcedure [dbo].[ResumenConsulta]    Script Date: 21/11/2018 11:36:12 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ResumenConsulta]
   
   @Con_ID              INT = NULL
   AS

   BEGIN 
			SELECT 
						   
					Co.[Con_ID],
					Pa.[Pa_ID],
					Pa_Nombre,
					Pa_Apellido,
					Pa_Cedula,
					Gen_Descripcion,
					Pa_FechaNac,								   
					[Con_Fecha], 
					[Con_Hora], 
					[Con_Motivo], 
					[Con_Historial], 
					[Con_Seguimiento],
					[Dia_Descripcion],
					[Exa_Descripcion],
					[Trat_Descripcion],
					[CondF_Peso], 
					[Cond_Talla], 
					[CondF_IndiceMC], 
					[CondF_Temp], 
					[CondF_Sistolica], 
					[CondF_Diastolica]

			FROM Consulta Co INNER JOIN Diagnostico Di
			ON Co.Con_ID = Di.Con_ID INNER JOIN Tratamiento Tr
			ON Co.Con_ID = Tr.Con_ID INNER JOIN ExamenFisico Ex
			ON Co.Con_ID = Ex.Con_ID INNER JOIN CondicionFisica CondF
			ON Ex.Exa_ID = CondF.Exa_ID INNER JOIN Paciente Pa
			ON Co.Pa_ID = Pa.Pa_ID INNER JOIN Genero Gen
			ON Gen.Gen_ID = pa. Gen_ID
			WHERE Co.Con_ID = @Con_ID 
	
END
GO

