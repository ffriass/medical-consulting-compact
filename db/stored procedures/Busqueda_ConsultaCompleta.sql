USE [Consultorio_DB]
GO
/****** Object:  StoredProcedure [dbo].[Busqueda_ConsultaCompleta]    Script Date: 21/11/2018 11:30:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[Busqueda_ConsultaCompleta]
   
   @Control				VARCHAR(1) = NULL,
   @Sub_Control         INT = NULL,
   @Busqueda			VARCHAR(11) = NULL,
  
   @Con_ID              INT = NULL,
   @Con_Fecha           Date = NULL,
   @Con_FechaDesde      Date = NULL,
   @Con_FechaHasta      Date = NULL,
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
			IF(@Sub_Control =  1)
				BEGIN
					 IF(@Busqueda = 0)
						BEGIN
							SELECT 
						   
								  Co.[Con_ID],
								  [Pa_ID], 
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
							ON Ex.Exa_ID = CondF.Exa_ID
							WHERE Pa_ID Like @Pa_ID ORDER BY Con_Fecha DESC
						END
				ELSE 
					BEGIN
					SELECT 					   
								  Co.[Con_ID],
								  Pa.[Pa_ID],
								  [Pa_Nombre],
								  [Pa_Apellido], 
								  [Con_Fecha], 
								  [Con_Hora], 
								  [Con_Motivo], 
								  [Con_Seguimiento]
								  

							FROM Consulta Co INNER JOIN Diagnostico Di
							ON Co.Con_ID = Di.Con_ID INNER JOIN Tratamiento Tr
							ON Co.Con_ID = Tr.Con_ID INNER JOIN ExamenFisico Ex
							ON Co.Con_ID = Ex.Con_ID INNER JOIN CondicionFisica CondF
							ON Ex.Exa_ID = CondF.Exa_ID INNER JOIN Paciente Pa
							ON Co.Pa_ID = Pa.Pa_ID
							WHERE Co.Pa_ID Like @Busqueda OR Pa_Cedula = @Busqueda ORDER BY Con_Fecha DESC
					END
				END

			IF(@Sub_Control =  2)
				BEGIN
					if(@Busqueda =0)
						BEGIN 
							SELECT 
						   
							  Co.[Con_ID],
							  Co.[Pa_ID], 
							  [Pa_Nombre],
							  [Pa_Apellido],
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
							ON Co.Pa_ID = Pa.Pa_ID
							WHERE (Con_Fecha BETWEEN @Con_FechaDesde AND @Con_FechaHasta) ORDER BY Con_Fecha DESC
						END
					ELSE 
						BEGIN
							SELECT 
						   
							  Co.[Con_ID],
							  Co.[Pa_ID], 
							  [Pa_Nombre],
							  [Pa_Apellido],
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
							ON Co.Pa_ID = Pa.Pa_ID
							WHERE (Con_Fecha BETWEEN @Con_FechaDesde AND @Con_FechaHasta) AND (Co.Pa_ID Like @Busqueda OR  Pa.Pa_Cedula = @Busqueda)  ORDER BY Con_Fecha DESC
						END
					END

		IF(@Sub_Control =  3)
				BEGIN
					SELECT 
						   
						  Co.[Con_ID],
						  Co.[Pa_ID], 
					      Pa.[Pa_Nombre],
						  Pa.[Pa_Apellido],
						  [Con_Fecha], 
						  [Con_Hora], 
						  [Con_Motivo], 
						  [Con_Seguimiento]

					FROM Consulta Co INNER JOIN Paciente Pa
					ON Co.Pa_ID = Pa.Pa_ID 
				    ORDER BY Con_Fecha DESC
				END
END





		




