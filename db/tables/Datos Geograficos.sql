USE [Consultorio_DB]
GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 20/04/2018 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[Mu_ID] [int] IDENTITY(1,1) NOT NULL,
	[Mu_Nombre] [varchar](30) NOT NULL,
	[Mu_EstaActivo] [bit] NULL,
	[Pro_ID] [int] NOT NULL,
 CONSTRAINT [PK_Municipio] PRIMARY KEY CLUSTERED 
(
	[Mu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 20/04/2018 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[Pro_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_Nombre] [varchar](30) NOT NULL,
	[Pro_EstaActivo] [bit] NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[Pro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 20/04/2018 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[Sec_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sec_Nombre] [varchar](50) NOT NULL,
	[Sec_EstaActivo] [bit] NOT NULL,
	[Mu_ID] [int] NOT NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[Sec_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Municipio] ON 

INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (1, N'Concepcion de La Vega', 1, 5)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (2, N'Constanza', 1, 5)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (3, N'Jarabacoa ', 1, 5)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (4, N'Jima Abajo', 1, 5)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (5, N'Santo Domingo Norte', 1, 32)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (6, N'Santo Domingo Este', 1, 32)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (7, N'Santo Domingo Sur', 1, 32)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (8, N'San Luis ', 1, 32)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (9, N'Pedro Brand', 1, 32)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (10, N'Boca Chica', 1, 32)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (11, N'Azua de Compotesla', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (12, N'Estebania', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (13, N'Guayabal', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (14, N'Las Charcas', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (15, N'La Yayas de Viajama', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (16, N'Padre las Casas', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (17, N'Peralta', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (18, N'Pueblo Viejo', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (19, N'Tabara Arriba', 1, 17)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (20, N'Las Terrenas', 1, 11)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (21, N'Sanchez', 1, 11)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (22, N'Minicipio de Samana', 1, 11)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (23, N'Distrito Nacional', 1, 33)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (24, N'Municipo la Romana', 1, 26)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (25, N'Guaymate', 1, 26)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (26, N'Villa Hermosa', 1, 26)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (27, N'Altamira', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (28, N'Guananico', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (29, N'Imbert', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (30, N'Los Hidalgos', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (31, N'Luperon', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (32, N'Sosua', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (33, N'Villa Isabela', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (34, N'Minicipio de Puerto Plata', 1, 2)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (35, N'Municipio de Pedernales', 1, 24)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (36, N'Oviedo', 1, 24)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (37, N'Cotui', 1, 7)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (38, N'Cevicos', 1, 7)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (39, N'Fantino', 1, 7)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (40, N'La Mata', 1, 7)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (41, N'Hato Mayor del Rey', 1, 30)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (42, N'El Valle', 1, 30)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (43, N'Sabana de la Mar', 1, 30)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (44, N'Ignacio de Sabaneta', 1, 15)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (45, N'Monción', 1, 15)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (46, N'Villa Los Almácigos', 1, 15)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (47, N'Municipio de Santiago', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (48, N'Bisono', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (49, N'Jánico', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (50, N'Licey al Medio', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (51, N'Puñal', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (52, N'San José de las Matas', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (53, N'Tamboril', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (54, N'Villa González', 1, 1)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (55, N'San Fernando de Montecristi', 1, 13)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (56, N'Castañuelas', 1, 13)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (57, N'Guayubín', 1, 13)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (58, N'Las Matas de Santa Cruz', 1, 13)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (59, N'Pepillo Salcedo', 1, 13)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (60, N'Villa Vásquez', 1, 13)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (61, N'Higüey', 1, 27)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (62, N'San Rafael del Yuma', 1, 27)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (63, N'Sabana Grande de Boyá
', 1, 31)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (64, N'Peralvillo', 1, 31)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (65, N'Bayaguana', 1, 31)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (66, N'Municipio de Monte Plata', 1, 31)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (67, N'Yamasá', 1, 31)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (68, N'Municipio de San Cristóbal', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (69, N'Bajos de Haina', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (70, N'Cambita Garabito', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (71, N'Los Cacaos', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (72, N'Sabana Grande de Palenque', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (73, N'San Gregorio de Nigua', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (74, N'Villa Altagracia', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (75, N'Yaguate', 1, 16)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (76, N'Jimaní', 1, 25)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (77, N'Cristóbal', 1, 25)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (78, N'Duvergé', 1, 25)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (79, N'La Descubierta', 1, 25)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (80, N'Mella', 1, 25)
INSERT [dbo].[Municipio] ([Mu_ID], [Mu_Nombre], [Mu_EstaActivo], [Pro_ID]) VALUES (81, N'Postrer Río', 1, 25)
SET IDENTITY_INSERT [dbo].[Municipio] OFF
SET IDENTITY_INSERT [dbo].[Provincia] ON 

INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (1, N'Santiago', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (2, N'Puerto Plata', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (3, N'Espalliat', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (5, N'La Vega', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (6, N'Mosenol Nouel', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (7, N'Sanchez Ramirez', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (8, N'Duarte', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (9, N'Salcedo', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (10, N'Maria Trinidad Sanchez', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (11, N'Samana', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (12, N'Valverde', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (13, N'Montecristi', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (14, N'Dajabon', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (15, N'Santiago Rodriguez', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (16, N'Sancristobal', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (17, N'Azua', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (18, N'Peravia', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (19, N'San Jose de Ocoa', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (20, N'San Juan', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (21, N'Elias Pina', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (22, N'Barahona', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (23, N'Baoruco', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (24, N'Pedernales', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (25, N'Independencia', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (26, N'La Romana', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (27, N'La Altagracia', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (28, N'El Seibo', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (29, N'San Pedro de Macoris', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (30, N'Hato Mayor', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (31, N'Monte Plata', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (32, N'Santo Domingo', 1)
INSERT [dbo].[Provincia] ([Pro_ID], [Pro_Nombre], [Pro_EstaActivo]) VALUES (33, N'Distrito Nacional', 1)
SET IDENTITY_INSERT [dbo].[Provincia] OFF
SET IDENTITY_INSERT [dbo].[Sector] ON 

INSERT [dbo].[Sector] ([Sec_ID], [Sec_Nombre], [Sec_EstaActivo], [Mu_ID]) VALUES (1, N'Colonia de los Doctores', 1, 5)
SET IDENTITY_INSERT [dbo].[Sector] OFF
ALTER TABLE [dbo].[Municipio]  WITH CHECK ADD  CONSTRAINT [FK_Municipio_Provincia] FOREIGN KEY([Pro_ID])
REFERENCES [dbo].[Provincia] ([Pro_ID])
GO
ALTER TABLE [dbo].[Municipio] CHECK CONSTRAINT [FK_Municipio_Provincia]
GO
ALTER TABLE [dbo].[Sector]  WITH CHECK ADD  CONSTRAINT [FK_Sector_Municipio] FOREIGN KEY([Mu_ID])
REFERENCES [dbo].[Municipio] ([Mu_ID])
GO
ALTER TABLE [dbo].[Sector] CHECK CONSTRAINT [FK_Sector_Municipio]
GO
