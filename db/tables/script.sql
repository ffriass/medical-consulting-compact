USE [Consultorio_Prueba]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 20/04/2018 14:30:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[Ci_ID] [int] NOT NULL,
	[Ci_Motivo] [varchar](60) NOT NULL,
	[Ci_Fecha] [date] NOT NULL,
	[Ci_Nota] [varchar](100) NULL,
	[Pa_ID] [int] NOT NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[Ci_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CondicionFisica]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CondicionFisica](
	[CondF_ID] [int] NOT NULL,
	[CondF_Peso] [decimal](3, 2) NULL,
	[Cond_Talla] [decimal](3, 2) NULL,
	[CondF_IndiceMC] [decimal](3, 2) NULL,
	[CondF_Temp] [decimal](3, 2) NULL,
	[CondF_Sistolica] [int] NULL,
	[CondF_Diastolica] [int] NULL,
	[Exa_ID] [int] NOT NULL,
 CONSTRAINT [PK_CondicionFisica] PRIMARY KEY CLUSTERED 
(
	[CondF_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consulta]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[Con_ID] [int] NOT NULL,
	[Con_Fecha] [date] NOT NULL,
	[Con_Hora] [time](7) NOT NULL,
	[Con_Motivo] [varchar](60) NOT NULL,
	[Con_Historial] [varchar](500) NULL,
	[Con_Seguimiento] [bit] NULL,
	[Pa_ID] [int] NOT NULL,
	[Doc_ID] [int] NOT NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[Con_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[Dia_ID] [int] NOT NULL,
	[Dia_Descripcion] [varchar](500) NOT NULL,
	[Con_ID] [int] NOT NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[Dia_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[Doc_ID] [int] NOT NULL,
	[Doc_Nombre] [varchar](20) NOT NULL,
	[Doc_Apellido] [varchar](20) NOT NULL,
	[Doc_Cedula] [varchar](13) NOT NULL,
	[Doc_Codico] [varchar](20) NULL,
	[Doc_Telefono] [varchar](15) NULL,
	[Doc_Email] [varchar](60) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[Doc_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor_Especialiades]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Especialiades](
	[Doc_ID] [int] NOT NULL,
	[Esp_ID] [int] NOT NULL,
 CONSTRAINT [PK_Doctor_Especialiades] PRIMARY KEY CLUSTERED 
(
	[Doc_ID] ASC,
	[Esp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[Esp_ID] [int] NOT NULL,
	[Esp_Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[Esp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Civil]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Civil](
	[Est_ID] [int] NOT NULL,
	[Est_Descripcion] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Estado_Civil] PRIMARY KEY CLUSTERED 
(
	[Est_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenFisico]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenFisico](
	[Exa_ID] [int] NOT NULL,
	[Exa_Descripcion] [varchar](500) NOT NULL,
	[Con_ID] [int] NOT NULL,
 CONSTRAINT [PK_ExamenFisico] PRIMARY KEY CLUSTERED 
(
	[Exa_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 20/04/2018 14:30:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[Gen_ID] [int] NOT NULL,
	[Gen_Descripcion] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[Gen_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[Mu_ID] [int] NOT NULL,
	[Mu_Nombre] [varchar](30) NOT NULL,
	[Mu_EstaActivo] [bit] NULL,
	[Pro_ID] [int] NOT NULL,
 CONSTRAINT [PK_Municipio] PRIMARY KEY CLUSTERED 
(
	[Mu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[Pa_ID] [int] NOT NULL,
	[Pa_Nombre] [varchar](20) NOT NULL,
	[Pa_Apellido] [varchar](20) NOT NULL,
	[Pa_Cedula] [varchar](11) NULL,
	[Pa_FechaNac] [date] NULL,
	[Pa_FechaAlta] [date] NULL,
	[Pa_Telefono] [varchar](15) NULL,
	[Pa_Celular] [varchar](15) NULL,
	[Pa_Calle] [varchar](60) NULL,
	[Sec_ID] [int] NULL,
	[Pa_EstaActivo] [bit] NOT NULL,
	[Zo_ID] [int] NULL,
	[TP_ID] [int] NULL,
	[Est_ID] [int] NULL,
	[Gen_ID] [int] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Pa_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[Pro_ID] [int] NOT NULL,
	[Pro_Nombre] [varchar](30) NOT NULL,
	[Pro_EstaActivo] [bit] NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[Pro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[Sec_ID] [int] NOT NULL,
	[Sec_Nombre] [varchar](50) NOT NULL,
	[Sec_EstaActivo] [bit] NOT NULL,
	[Mu_ID] [int] NOT NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[Sec_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Paciente]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Paciente](
	[TP_ID] [int] NOT NULL,
	[TP_Descripcion] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Tipo_Paciente] PRIMARY KEY CLUSTERED 
(
	[TP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tratamiento]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tratamiento](
	[Trat_ID] [int] NOT NULL,
	[Trat_Descrpcion] [varchar](500) NOT NULL,
	[Con_ID] [int] NOT NULL,
 CONSTRAINT [PK_Tratamiento] PRIMARY KEY CLUSTERED 
(
	[Trat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Us_ID] [int] NOT NULL,
	[Us_Usuario] [varchar](20) NOT NULL,
	[Us_Contrasena] [varchar](20) NOT NULL,
	[Doc_ID] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Us_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zona]    Script Date: 20/04/2018 14:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zona](
	[Zo_ID] [int] NOT NULL,
	[Zo_Nombre] [varchar](50) NOT NULL,
	[Zo_EstaActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Zona] PRIMARY KEY CLUSTERED 
(
	[Zo_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([Pa_ID])
REFERENCES [dbo].[Paciente] ([Pa_ID])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
ALTER TABLE [dbo].[CondicionFisica]  WITH CHECK ADD  CONSTRAINT [FK_CondicionFisica_ExamenFisico] FOREIGN KEY([Exa_ID])
REFERENCES [dbo].[ExamenFisico] ([Exa_ID])
GO
ALTER TABLE [dbo].[CondicionFisica] CHECK CONSTRAINT [FK_CondicionFisica_ExamenFisico]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Doctor] FOREIGN KEY([Doc_ID])
REFERENCES [dbo].[Doctor] ([Doc_ID])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Doctor]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Paciente] FOREIGN KEY([Pa_ID])
REFERENCES [dbo].[Paciente] ([Pa_ID])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Paciente]
GO
ALTER TABLE [dbo].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Consulta] FOREIGN KEY([Con_ID])
REFERENCES [dbo].[Consulta] ([Con_ID])
GO
ALTER TABLE [dbo].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Consulta]
GO
ALTER TABLE [dbo].[Doctor_Especialiades]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Especialiades_Doctor] FOREIGN KEY([Doc_ID])
REFERENCES [dbo].[Doctor] ([Doc_ID])
GO
ALTER TABLE [dbo].[Doctor_Especialiades] CHECK CONSTRAINT [FK_Doctor_Especialiades_Doctor]
GO
ALTER TABLE [dbo].[Doctor_Especialiades]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Especialiades_Especialidad] FOREIGN KEY([Esp_ID])
REFERENCES [dbo].[Especialidad] ([Esp_ID])
GO
ALTER TABLE [dbo].[Doctor_Especialiades] CHECK CONSTRAINT [FK_Doctor_Especialiades_Especialidad]
GO
ALTER TABLE [dbo].[ExamenFisico]  WITH CHECK ADD  CONSTRAINT [FK_ExamenFisico_Consulta] FOREIGN KEY([Con_ID])
REFERENCES [dbo].[Consulta] ([Con_ID])
GO
ALTER TABLE [dbo].[ExamenFisico] CHECK CONSTRAINT [FK_ExamenFisico_Consulta]
GO
ALTER TABLE [dbo].[Municipio]  WITH CHECK ADD  CONSTRAINT [FK_Municipio_Provincia] FOREIGN KEY([Pro_ID])
REFERENCES [dbo].[Provincia] ([Pro_ID])
GO
ALTER TABLE [dbo].[Municipio] CHECK CONSTRAINT [FK_Municipio_Provincia]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_EstadoCivil] FOREIGN KEY([Est_ID])
REFERENCES [dbo].[Estado_Civil] ([Est_ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_EstadoCivil]
GO
ALTER TABLE [dbo].[Paciente]  WITH NOCHECK ADD  CONSTRAINT [FK_Paciente_Genero] FOREIGN KEY([Gen_ID])
REFERENCES [dbo].[Genero] ([Gen_ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Genero]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Sector] FOREIGN KEY([Sec_ID])
REFERENCES [dbo].[Sector] ([Sec_ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Sector]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_TipoPaciente] FOREIGN KEY([TP_ID])
REFERENCES [dbo].[Tipo_Paciente] ([TP_ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_TipoPaciente]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Zona] FOREIGN KEY([Zo_ID])
REFERENCES [dbo].[Zona] ([Zo_ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Zona]
GO
ALTER TABLE [dbo].[Sector]  WITH CHECK ADD  CONSTRAINT [FK_Sector_Municipio] FOREIGN KEY([Mu_ID])
REFERENCES [dbo].[Municipio] ([Mu_ID])
GO
ALTER TABLE [dbo].[Sector] CHECK CONSTRAINT [FK_Sector_Municipio]
GO
ALTER TABLE [dbo].[Tratamiento]  WITH CHECK ADD  CONSTRAINT [FK_Tratamiento_Consulta] FOREIGN KEY([Con_ID])
REFERENCES [dbo].[Consulta] ([Con_ID])
GO
ALTER TABLE [dbo].[Tratamiento] CHECK CONSTRAINT [FK_Tratamiento_Consulta]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Doctor] FOREIGN KEY([Doc_ID])
REFERENCES [dbo].[Doctor] ([Doc_ID])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Doctor]
GO
