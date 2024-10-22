
/****** Object:  Table [dbo].[seguimientos]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[seguimientos](
	[id_Seguimiento] [int] IDENTITY(1,1) NOT NULL,
	[seguimiento] [varchar](70) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Seguimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidades](
	[id_Localidad] [int] NOT NULL,
	[localidades] [varchar](60) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__localida__44A38FCE0EA330E9] PRIMARY KEY CLUSTERED 
(
	[id_Localidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[localidades] ([id_Localidad], [localidades], [activo]) VALUES (1, N'Villa Dolores', 1)
INSERT [dbo].[localidades] ([id_Localidad], [localidades], [activo]) VALUES (2, N'Sarmiento', 1)
INSERT [dbo].[localidades] ([id_Localidad], [localidades], [activo]) VALUES (3, N'San pedro', 1)
/****** Object:  Table [dbo].[laboratorios]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[laboratorios](
	[id_Laboratorio] [int] IDENTITY(1,1) NOT NULL,
	[nomlaboratorio] [varchar](100) NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](50) NULL,
	[gmail] [varchar](70) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Laboratorio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[laboratorios] ON
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (1, N'SIL', N'Italia 53 vd', N'3544422865', N'laboratorio_sil@gmail.com', 1)
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (2, N'Einat', N'Belgrano 2115 vd', N'2664227284', N'dptocontrolecalidad.einat@gmail.com', 1)
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (3, N'UTN', N'Maestro M.Lopez esquina Cruz Roja Argentina s/n Córdoba', N'3515986000', N'ccortas@frc.utn.edu.ar', 1)
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (4, N'dkjf ', N'lksj235 ', N'543gfd ', N'fdddddddd', 0)
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (5, N'ertyu ', N'23456 ', N'ieiei', N'uytrs45768', 0)
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (6, N'eieityuid273w++', N'errstesz46 ', N'657890tretyui ', N'sfdgh5456@gamil.com', 0)
INSERT [dbo].[laboratorios] ([id_Laboratorio], [nomlaboratorio], [direccion], [telefono], [gmail], [activo]) VALUES (7, N'sd deee', N'san pedro ', N'3544 ', N'fkfj@', 0)
SET IDENTITY_INSERT [dbo].[laboratorios] OFF
/****** Object:  Table [dbo].[empleados]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleados](
	[id_Empleados] [int] IDENTITY(1,1) NOT NULL,
	[nombre_apellido] [varchar](70) NULL,
	[telefono] [varchar](50) NULL,
	[gmail] [varchar](70) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Empleados] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[empleados] ON
INSERT [dbo].[empleados] ([id_Empleados], [nombre_apellido], [telefono], [gmail], [activo]) VALUES (1, N'Brenda Rivarolassssssss', N'3544408498', N'rivarolabrenda184@gmail.com', 0)
INSERT [dbo].[empleados] ([id_Empleados], [nombre_apellido], [telefono], [gmail], [activo]) VALUES (2, N'j ', N' ', N'', 0)
INSERT [dbo].[empleados] ([id_Empleados], [nombre_apellido], [telefono], [gmail], [activo]) VALUES (3, N'h ', N'234 ', N'sd', 0)
INSERT [dbo].[empleados] ([id_Empleados], [nombre_apellido], [telefono], [gmail], [activo]) VALUES (4, N'Lourdes Newbery ', N'1234567890 ', N'fsnfsnfknsd', 1)
INSERT [dbo].[empleados] ([id_Empleados], [nombre_apellido], [telefono], [gmail], [activo]) VALUES (5, N'brend ', N'123456789 ', N',kmujnhbgvf', 1)
INSERT [dbo].[empleados] ([id_Empleados], [nombre_apellido], [telefono], [gmail], [activo]) VALUES (6, N'erick ', N'432 ', N'erika@', 0)
SET IDENTITY_INSERT [dbo].[empleados] OFF
/****** Object:  Table [dbo].[dbo.Estado-Reclamo]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dbo.Estado-Reclamo](
	[id_estado_reclamo] [int] NULL,
	[Estado_Reclamo] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreapellido] [varchar](59) NULL,
	[telefono] [varchar](50) NULL,
	[DNI] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[gmail] [varchar](70) NULL,
	[activo] [bit] NULL,
	[contraseña] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON
INSERT [dbo].[usuarios] ([id_Usuario], [nombreapellido], [telefono], [DNI], [direccion], [gmail], [activo], [contraseña]) VALUES (2, N'ave', N'3544', N'46306', N'san pedro', N'okdof@gmail.com', 1, N'1')
INSERT [dbo].[usuarios] ([id_Usuario], [nombreapellido], [telefono], [DNI], [direccion], [gmail], [activo], [contraseña]) VALUES (3, N'okdd', N'3544', N'322', N'sdff', N'kfkfdkd', 1, N'1')
INSERT [dbo].[usuarios] ([id_Usuario], [nombreapellido], [telefono], [DNI], [direccion], [gmail], [activo], [contraseña]) VALUES (4, N'pavo', N'343535666', N'66666666', N'pavoland', N'pavosabroso@gmail.com', 1, N'1')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
/****** Object:  Table [dbo].[TiposAguas]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposAguas](
	[id_TipoAgua] [int] IDENTITY(1,1) NOT NULL,
	[TipoAgua] [varchar](70) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_TiposAguas] PRIMARY KEY CLUSTERED 
(
	[id_TipoAgua] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TiposAguas] ON
INSERT [dbo].[TiposAguas] ([id_TipoAgua], [TipoAgua], [activo]) VALUES (1, N'Filtrada', 1)
INSERT [dbo].[TiposAguas] ([id_TipoAgua], [TipoAgua], [activo]) VALUES (2, N'Potable', 1)
INSERT [dbo].[TiposAguas] ([id_TipoAgua], [TipoAgua], [activo]) VALUES (3, N'Cruda', 1)
SET IDENTITY_INSERT [dbo].[TiposAguas] OFF
/****** Object:  Table [dbo].[tipos_reclamo]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_reclamo](
	[id_TipoReclamo] [int] IDENTITY(1,1) NOT NULL,
	[tiporeclamo] [varchar](70) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_TipoReclamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipos_analisis]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipos_analisis](
	[id_TipoAnalisis] [int] IDENTITY(1,1) NOT NULL,
	[tipoanalisis] [varchar](50) NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_TipoAnalisis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tipos_analisis] ON
INSERT [dbo].[tipos_analisis] ([id_TipoAnalisis], [tipoanalisis], [activo]) VALUES (1, N'Fisico', 1)
INSERT [dbo].[tipos_analisis] ([id_TipoAnalisis], [tipoanalisis], [activo]) VALUES (2, N'Quimico', 1)
INSERT [dbo].[tipos_analisis] ([id_TipoAnalisis], [tipoanalisis], [activo]) VALUES (3, N'Microbiologico', 1)
SET IDENTITY_INSERT [dbo].[tipos_analisis] OFF
/****** Object:  Table [dbo].[tecnicolaboratorio]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tecnicolaboratorio](
	[id_TecLaboratorio] [int] IDENTITY(1,1) NOT NULL,
	[nombreapellido] [varchar](100) NULL,
	[DNI] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[gmail] [varchar](70) NULL,
	[id_Laboratorio] [int] NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_TecLaboratorio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tecnicolaboratorio] ON
INSERT [dbo].[tecnicolaboratorio] ([id_TecLaboratorio], [nombreapellido], [DNI], [telefono], [gmail], [id_Laboratorio], [activo]) VALUES (1, N'Erick', N'47988466', N'3544574635', N'erickmolinagmail.com', 1, 1)
SET IDENTITY_INSERT [dbo].[tecnicolaboratorio] OFF
/****** Object:  Table [dbo].[NombreAnalisis]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NombreAnalisis](
	[id_NombreAnalisis] [int] IDENTITY(1,1) NOT NULL,
	[id_TipoAnalisis] [int] NOT NULL,
	[nombreanalisis] [varchar](70) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_NombreAnalisis] PRIMARY KEY CLUSTERED 
(
	[id_NombreAnalisis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NombreAnalisis] ON
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (1, 1, N'Turbidez', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (2, 1, N'Conductividad electrica', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (3, 1, N'PH', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (4, 2, N'Calcio', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (5, 2, N'Magnesio', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (6, 2, N'PH de saturacion', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (7, 2, N'Cloruros', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (8, 2, N'Sodio', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (9, 2, N'Oxigeno disuelto', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (10, 2, N'Solidos totales disuelltos ', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (11, 2, N'Temperatura', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (12, 3, N'Eschericcia colli', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (13, 3, N'Coliforme totales', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (14, 3, N'Pseudomanas', 1)
INSERT [dbo].[NombreAnalisis] ([id_NombreAnalisis], [id_TipoAnalisis], [nombreanalisis], [Activo]) VALUES (15, 3, N'Bacterias mesoficas', 1)
SET IDENTITY_INSERT [dbo].[NombreAnalisis] OFF
/****** Object:  Table [dbo].[lugar_muestras]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lugar_muestras](
	[id_LugarMuestra] [int] IDENTITY(1,1) NOT NULL,
	[sector] [int] NULL,
	[lugar_muestra] [varchar](100) NULL,
	[lugar_aleatorio] [varchar](100) NULL,
	[id_Localidad] [int] NULL,
	[observaciones] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__lugar_mu__D554D8E51DE57479] PRIMARY KEY CLUSTERED 
(
	[id_LugarMuestra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[lugar_muestras] ON
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (1, 1, N'Medardo Ulloque s/n', NULL, 1, N'El matadero                                       ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (2, 1, N'Las Encrucijadas', NULL, 1, N'Escuela                                           ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (3, 2, N'Villalba y Timoteo Bustos', NULL, 1, N'Familia Flores                                    ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (4, 2, N'Ldor. Urquiza N°865', NULL, 1, N'Sector hogar de ancianos                          ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (5, 2, N'Parque industrial', NULL, 1, N'Control de ingreso                                ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (6, 3, N'Brochero Nuevo - Fovicor', N'                                                                                                    ', 1, N'Plazaaa                                           ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (7, 3, N'Gremdial', NULL, 1, N'Plaza                                             ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (8, 3, N'B° Colón', NULL, 1, N'Escuela                                           ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (9, 3, N'Presidente Perón', NULL, 1, N'Pico público, final de la red                     ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (10, 4, N'B° Jardín ', NULL, 1, N'Plaza Sarmiento                                   ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (11, 4, N'Av. España N°1087', NULL, 1, N'Familia Navarro                                   ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (12, 5, N'Av. San Martín N°1300', NULL, 1, N'Plaza                                             ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (13, 5, N'Pueyrredon N°1315', NULL, 1, N'Familia Plaza                                     ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (14, 5, N'Libertad y Luis Laje', NULL, 1, N'Familia Gallardo                                  ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (15, 5, N'Godoy Cruz N°350', NULL, 1, N'Iglesia                                           ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (16, 6, N'Av. Belgrano ', NULL, 1, N'Plazoleta Belgrano                                ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (17, 6, N'Ruta 148', NULL, 1, N'C.R.E.S.                                          ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (18, 6, N'Av. San Martín N°2050', NULL, 1, N'Plazoleta Malvinas                                ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (19, 6, N'San Lorenzo N°155', NULL, 1, N'Familia Ponce                                     ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (20, 7, N'Av. Blegrano N°2215', NULL, 1, N'Cámara de carga - Planta                          ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (21, 7, N'Av. Belgrano N°2215', NULL, 1, N'Cisterna - Planta                                 ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (22, 7, N'Av. Belgrano N°2215', NULL, 1, N'Intermedio - Planta                               ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (23, 7, N'Gral. Paz N°2641', NULL, 1, N'Familia Altamirano                                ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (24, 7, N'Crespin y traslasierra B° San Pablo', NULL, 1, N'Centro comunitario                                ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (25, 7, N'Av. Belgrano', NULL, 1, N'El Portugues                                      ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (26, 8, N'Miguel Cane 38', NULL, 1, N'Familia Pereyra                                   ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (27, 8, N'Av. Belen N°350 B° Sep', NULL, 1, N'Plaza                                             ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (28, 8, N'Torres Amaral N°1745', NULL, 1, N'Familia Nicoletti                                 ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (29, 8, N'Pública s/n', NULL, 1, N'Loteo Arrieta                                     ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (30, 8, N'Av. Belgrano', NULL, 1, N'Ioacari Av. Belgrano N°1071                       ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (31, 9, N'Gral. Paz 323', NULL, 1, N'Frente de la plaza blanca. Familia Castellano     ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (32, 9, N'I. Españoles N°135', NULL, 1, N'Familia Quiroga Mattio                            ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (33, 9, N'Loteo Bruno B° Fátima', NULL, 1, N'Sitram. Familia Perez Cortez                      ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (34, 9, N'Juan Bernardon y E. Castellano', NULL, 1, N'SUM                                               ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (35, 10, N'Cárcano N°355', NULL, 1, N'Jardín San Martín                                 ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (36, 10, N'Cenobio Soto N°170', NULL, 1, N'Familia Nicotra                                   ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (37, 11, N'Av. Climaco Leyes N°255', NULL, 2, N'Dispensario                                       ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (38, 11, N'San Roque 369', NULL, 2, N'Familia Lopez                                     ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (39, 11, N'Comisionado de agreda y Gastón Cepa', NULL, 2, N'Familia Melian                                    ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (40, 11, N'Loteo el Bordo', NULL, 2, N'Famillia Ferreyra                                 ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (41, 12, N'B° Obrero', NULL, 3, N'Dispensario                                       ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (42, 12, N'Av. Morillo 46', NULL, 3, N'Familia Maldonado                                 ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (43, 12, N'Av. Juan Pablo II N°1050', NULL, 3, N'Escuela Stella Maris                              ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (44, 12, N'Manuel Cuestas - Loteo Moretta ', NULL, 3, N'Familia Miranda                                   ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (45, 12, N'Poeta ahumada y pública B° Epam', NULL, 3, N'Salón del Divino Niño                             ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (60, 1, N'san pedro ', N'                                                                                                    ', NULL, N'plaza                                             ', 1)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (61, 1, N'san pedro ', N'', 1, N'plaza', 0)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (62, 1, N'Pileta ', N'', 1, N'piletas', 0)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (63, 1, N'lolo ', N'', 2, N'lolo', 0)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (64, 1, N'profe ', N'', 2, N'profe', 0)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (65, 1, N'san pedro ', N'', 2, N'plaza', 0)
INSERT [dbo].[lugar_muestras] ([id_LugarMuestra], [sector], [lugar_muestra], [lugar_aleatorio], [id_Localidad], [observaciones], [activo]) VALUES (66, 10, N'piletA ', N'', 3, N'PLAZA', 0)
SET IDENTITY_INSERT [dbo].[lugar_muestras] OFF
/****** Object:  Table [dbo].[reclamos]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reclamos](
	[id_Reclamos] [int] IDENTITY(1,1) NOT NULL,
	[cod_cliente] [varchar](70) NULL,
	[fecha_hora] [datetime] NULL,
	[reclamo] [varchar](100) NULL,
	[id_estado_reclamo] [varchar](100) NULL,
	[id_TipoReclamo] [int] NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Reclamos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[resultadosanalisis]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[resultadosanalisis](
	[id_ResultadoAnalisis] [int] IDENTITY(1,1) NOT NULL,
	[resultado] [varchar](100) NULL,
	[activo] [bit] NULL,
	[id_NombreAnalisis] [int] NULL,
	[id_Analisis] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ResultadoAnalisis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[resultadosanalisis] ON
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (1, N'90', 1, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (2, N'38', 1, 2, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (5, N'41', 1, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (6, N'41', 1, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (7, N'42', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (8, N'43', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (9, N'44', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (10, N'45', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (11, N'46', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (12, N'47', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (13, N'48', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (14, N'49', 0, 1, NULL)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (15, N'7', 1, 4, 52)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (16, N'7', 1, 15, 53)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (17, N'7', 1, 7, 55)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (18, N'9', 1, 4, 56)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (19, N'9', 1, 3, 57)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (20, N'2', 1, 7, 58)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (21, N'12', 1, 11, 59)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (22, N'2', 1, 7, 60)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (23, N'2', 1, 4, 61)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (24, N'2', 1, 4, 62)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (25, N'5', 1, 7, 63)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (26, N'3', 1, 15, 64)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (27, N'2', 1, 13, 65)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (28, N'6', 1, 4, 66)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (29, N'9', 1, 7, 68)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (30, N'1', 1, 15, 70)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (31, N'99', 1, 4, 71)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (32, N'2', 1, 7, 72)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (33, N'12', 1, 6, 73)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (34, N'43', 1, 1, 74)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (35, N'22', 1, 8, 75)
INSERT [dbo].[resultadosanalisis] ([id_ResultadoAnalisis], [resultado], [activo], [id_NombreAnalisis], [id_Analisis]) VALUES (36, N'22', 1, 2, 76)
SET IDENTITY_INSERT [dbo].[resultadosanalisis] OFF
/****** Object:  View [dbo].[Vista_LugarMuestra]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_LugarMuestra]
AS
SELECT     dbo.lugar_muestras.activo, dbo.lugar_muestras.observaciones, dbo.lugar_muestras.lugar_muestra, dbo.lugar_muestras.sector, dbo.lugar_muestras.id_LugarMuestra, 
                      dbo.lugar_muestras.id_Localidad, dbo.lugar_muestras.lugar_aleatorio, dbo.localidades.localidades
FROM         dbo.lugar_muestras INNER JOIN
                      dbo.localidades ON dbo.lugar_muestras.id_Localidad = dbo.localidades.id_Localidad
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "localidades"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 111
               Right = 405
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "lugar_muestras"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 181
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_LugarMuestra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_LugarMuestra'
GO
/****** Object:  Table [dbo].[analisis1]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[analisis1](
	[id_Analisis] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[hora] [time](7) NULL,
	[activo] [bit] NULL,
	[id_TecLaboratorio] [int] NULL,
 CONSTRAINT [PK__analisis__365728C82BFE89A6] PRIMARY KEY CLUSTERED 
(
	[id_Analisis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[analisis1] ON
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (1, CAST(0xE3450B00 AS Date), CAST(0x0700000000000000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (2, CAST(0x02460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (3, CAST(0xEB450B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (4, CAST(0xE4450B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (12, CAST(0x03460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (13, CAST(0x03460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (14, CAST(0x03460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (15, CAST(0x03460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (16, CAST(0x07460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (17, CAST(0x00460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (18, CAST(0x06460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (19, CAST(0x06460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (20, CAST(0x06460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (21, CAST(0x06460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (22, CAST(0x93450B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (23, CAST(0xEA450B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (24, CAST(0x07460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (25, CAST(0xD4450B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (26, CAST(0x08460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (27, CAST(0x25460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (28, CAST(0x09460B00 AS Date), CAST(0x07003411995D0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (29, CAST(0x09460B00 AS Date), CAST(0x07001E68935E0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (30, CAST(0x0A460B00 AS Date), CAST(0x0700642BB75E0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (31, CAST(0x10460B00 AS Date), CAST(0x0700F272A64E0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (32, CAST(0x10460B00 AS Date), CAST(0x07009E96A2550000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (33, CAST(0x10460B00 AS Date), CAST(0x07002A1DEA550000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (34, CAST(0x10460B00 AS Date), CAST(0x0700A0FA2B570000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (35, CAST(0x16460B00 AS Date), CAST(0x07001E68935E0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (36, CAST(0x16460B00 AS Date), CAST(0x0700DED00B630000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (37, CAST(0x17460B00 AS Date), CAST(0x0700BAC862470000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (38, CAST(0x17460B00 AS Date), CAST(0x07008C12CE470000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (39, CAST(0x17460B00 AS Date), CAST(0x0700189915480000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (40, CAST(0x17460B00 AS Date), CAST(0x07007669C8480000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (41, CAST(0x17460B00 AS Date), CAST(0x0700BC2CEC480000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (42, CAST(0x17460B00 AS Date), CAST(0x07001AFD9E490000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (43, CAST(0x17460B00 AS Date), CAST(0x070062244C4B0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (44, CAST(0x17460B00 AS Date), CAST(0x0700EEAA934B0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (45, CAST(0x17460B00 AS Date), CAST(0x0700346EB74B0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (46, CAST(0x17460B00 AS Date), CAST(0x07006488D54C0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (47, CAST(0x17460B00 AS Date), CAST(0x0700AA4BF94C0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (48, CAST(0x17460B00 AS Date), CAST(0x0700081CAC4D0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (49, CAST(0x17460B00 AS Date), CAST(0x07004856155B0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (50, CAST(0x17460B00 AS Date), CAST(0x070004F77A5C0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (51, CAST(0x17460B00 AS Date), CAST(0x07004ABA9E5C0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (52, CAST(0x17460B00 AS Date), CAST(0x0700D640E65C0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (53, CAST(0x17460B00 AS Date), CAST(0x070062C72D5D0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (54, CAST(0x17460B00 AS Date), CAST(0x0700A88A515D0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (55, CAST(0x17460B00 AS Date), CAST(0x07007AD4BC5D0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (56, CAST(0x17460B00 AS Date), CAST(0x0700065B045E0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (57, CAST(0x17460B00 AS Date), CAST(0x070092E14B5E0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (58, CAST(0x1C460B00 AS Date), CAST(0x07008E19395B0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (59, CAST(0x1C460B00 AS Date), CAST(0x07000454994A0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (60, CAST(0x1C460B00 AS Date), CAST(0x0700C0F4FE4B0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (61, CAST(0x1C460B00 AS Date), CAST(0x070006B8224C0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (62, CAST(0x1C460B00 AS Date), CAST(0x07004C7B464C0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (63, CAST(0x1C460B00 AS Date), CAST(0x0700F00E1D4D0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (64, CAST(0x1C460B00 AS Date), CAST(0x0700C258884D0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (65, CAST(0x1C460B00 AS Date), CAST(0x070096067D4F0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (66, CAST(0x80360B00 AS Date), CAST(0x070062C72D5D0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (67, CAST(0x1C460B00 AS Date), CAST(0x070096A95E610000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (68, CAST(0x17460B00 AS Date), CAST(0x0700000000000000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (69, CAST(0x0D460B00 AS Date), CAST(0x07007870335C0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (70, CAST(0x1D460B00 AS Date), CAST(0x0700AE130C500000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (71, CAST(0x80360B00 AS Date), CAST(0x070020293B4E0000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (72, CAST(0x1E460B00 AS Date), CAST(0x070016D86D580000 AS Time), 0, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (73, CAST(0x1E460B00 AS Date), CAST(0x0700E821D9580000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (74, CAST(0x1E460B00 AS Date), CAST(0x0700A4C23E5A0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (75, CAST(0x1E460B00 AS Date), CAST(0x07008E19395B0000 AS Time), 1, 1)
INSERT [dbo].[analisis1] ([id_Analisis], [fecha], [hora], [activo], [id_TecLaboratorio]) VALUES (76, CAST(0x23460B00 AS Date), CAST(0x07009ACE8F520000 AS Time), 1, 1)
SET IDENTITY_INSERT [dbo].[analisis1] OFF
/****** Object:  Table [dbo].[muestras]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muestras](
	[id_Muestra] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[id_Empleados] [int] NULL,
	[id_LugarMuestra] [int] NULL,
	[activo] [bit] NULL,
	[id_TipoAgua] [int] NULL,
	[Hora] [time](7) NULL,
 CONSTRAINT [PK__muestras__908E8E4022AA2996] PRIMARY KEY CLUSTERED 
(
	[id_Muestra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[muestras] ON
INSERT [dbo].[muestras] ([id_Muestra], [fecha], [id_Empleados], [id_LugarMuestra], [activo], [id_TipoAgua], [Hora]) VALUES (1, CAST(0x80360B00 AS Date), 1, 1, 1, 1, NULL)
INSERT [dbo].[muestras] ([id_Muestra], [fecha], [id_Empleados], [id_LugarMuestra], [activo], [id_TipoAgua], [Hora]) VALUES (2, CAST(0x17460B00 AS Date), 1, 21, 1, 3, CAST(0x0700000000000000 AS Time))
INSERT [dbo].[muestras] ([id_Muestra], [fecha], [id_Empleados], [id_LugarMuestra], [activo], [id_TipoAgua], [Hora]) VALUES (3, CAST(0x11460B00 AS Date), 1, 43, 1, 2, CAST(0x0700000000000000 AS Time))
SET IDENTITY_INSERT [dbo].[muestras] OFF
/****** Object:  Table [dbo].[parametros]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[parametros](
	[id_Parametro] [int] IDENTITY(1,1) NOT NULL,
	[cod_alimentario] [varchar](50) NULL,
	[norm_provincial] [varchar](50) NULL,
	[id_NombreAnalisis] [int] NULL,
	[norm_provincial_limite] [float] NULL,
	[cod_alimentario_limite] [float] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__parametr__0EE75D6E0AD2A005] PRIMARY KEY CLUSTERED 
(
	[id_Parametro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[parametros] ON
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (1, N'3', N'1', 1, 2, 3, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (2, N'45', N'7', 2, 7, 87, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (3, N'6,5', N'6,5', 3, 8.5, 8.5, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (4, N'456', N'567', 4, 67, 567, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (5, N'54', N'56', 5, 8776, 56, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (6, N'76', N'67', 6, 546, 87, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (7, N'350', N'250', 7, 400, 350, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (8, N'44', N'66', 8, 77, 98, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (9, N'2233', N'56', 9, 77, 99, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (10, N'1500', N'50-1000', 10, 1500, 1500, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (11, N'09', N'98', 11, 88, 77, 0)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (12, N'234', N'45', 12, 888887, 99, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (13, N'-1,1', N'65', 13, 3, 9, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (14, N'-1,8', N'44', 14, 100, 77, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (15, N'56', N'2134', 15, 44, 876, 1)
INSERT [dbo].[parametros] ([id_Parametro], [cod_alimentario], [norm_provincial], [id_NombreAnalisis], [norm_provincial_limite], [cod_alimentario_limite], [activo]) VALUES (27, N'1', N'2', 1, 6, 5, 0)
SET IDENTITY_INSERT [dbo].[parametros] OFF
/****** Object:  Table [dbo].[Muestras_Seguimientos]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muestras_Seguimientos](
	[id_Muestra_Seguimiento] [int] IDENTITY(1,1) NOT NULL,
	[id_Muestra] [int] NULL,
	[id_Seguimiento] [int] NULL,
 CONSTRAINT [PK_Muestras_Seguimientos] PRIMARY KEY CLUSTERED 
(
	[id_Muestra_Seguimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[intermedia]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[intermedia](
	[id_Intermedia] [int] IDENTITY(1,1) NOT NULL,
	[id_Analisis] [int] NULL,
	[id_Muestra] [int] NULL,
	[activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Intermedia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[intermedia] ON
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (1, 1, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (2, 35, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (3, 36, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (4, 37, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (5, 38, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (6, 39, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (7, 40, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (8, 41, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (9, 42, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (10, 43, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (11, 44, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (12, 45, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (13, 46, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (14, 47, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (15, 48, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (16, 49, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (18, 51, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (19, 52, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (20, 53, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (21, 54, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (22, 55, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (23, 56, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (24, 57, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (25, 58, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (26, 59, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (27, 60, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (28, 61, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (29, 62, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (30, 63, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (31, 64, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (32, 65, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (33, 66, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (35, 68, 3, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (37, 70, 3, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (38, 71, 2, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (39, 72, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (40, 73, 1, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (41, 74, 3, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (42, 75, 3, 1)
INSERT [dbo].[intermedia] ([id_Intermedia], [id_Analisis], [id_Muestra], [activo]) VALUES (43, 76, 2, 1)
SET IDENTITY_INSERT [dbo].[intermedia] OFF
/****** Object:  Table [dbo].[analisis_detalles]    Script Date: 07/30/2024 11:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[analisis_detalles](
	[id_AnalisisDetalles] [int] IDENTITY(1,1) NOT NULL,
	[id_ResultadoAnalisis] [int] NULL,
	[id_Analisis] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK__analisis__1BF3030E49C3F6B7] PRIMARY KEY CLUSTERED 
(
	[id_AnalisisDetalles] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[analisis_detalles] ON
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (5, 1, 1, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (11, 5, 1, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (19, 19, 57, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (20, 20, 58, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (21, 21, 59, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (22, 22, 60, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (23, 23, 61, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (24, 24, 62, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (25, 25, 63, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (26, 26, 64, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (27, 27, 65, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (28, 28, 66, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (29, 29, 68, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (30, 30, 70, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (31, 31, 71, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (32, 32, 72, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (33, 33, 73, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (34, 34, 74, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (35, 35, 75, 1)
INSERT [dbo].[analisis_detalles] ([id_AnalisisDetalles], [id_ResultadoAnalisis], [id_Analisis], [activo]) VALUES (36, 36, 76, 1)
SET IDENTITY_INSERT [dbo].[analisis_detalles] OFF
/****** Object:  View [dbo].[Vista_BusquedaMuestra]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_BusquedaMuestra]
AS
SELECT     dbo.muestras.fecha, dbo.muestras.Hora, dbo.muestras.id_LugarMuestra, dbo.lugar_muestras.lugar_muestra, dbo.lugar_muestras.lugar_aleatorio, dbo.lugar_muestras.sector, 
                      dbo.muestras.id_Muestra, dbo.muestras.id_Empleados, dbo.muestras.activo, dbo.muestras.id_TipoAgua, dbo.empleados.nombre_apellido, dbo.TiposAguas.TipoAgua, 
                      dbo.lugar_muestras.id_Localidad, dbo.lugar_muestras.observaciones, dbo.localidades.localidades
FROM         dbo.lugar_muestras INNER JOIN
                      dbo.muestras ON dbo.lugar_muestras.id_LugarMuestra = dbo.muestras.id_LugarMuestra INNER JOIN
                      dbo.empleados ON dbo.muestras.id_Empleados = dbo.empleados.id_Empleados INNER JOIN
                      dbo.TiposAguas ON dbo.muestras.id_TipoAgua = dbo.TiposAguas.id_TipoAgua INNER JOIN
                      dbo.localidades ON dbo.lugar_muestras.id_Localidad = dbo.localidades.id_Localidad
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[68] 4[4] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "lugar_muestras"
            Begin Extent = 
               Top = 215
               Left = 23
               Bottom = 379
               Right = 192
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "muestras"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 180
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "empleados"
            Begin Extent = 
               Top = 6
               Left = 245
               Bottom = 146
               Right = 412
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposAguas"
            Begin Extent = 
               Top = 6
               Left = 450
               Bottom = 111
               Right = 610
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "localidades"
            Begin Extent = 
               Top = 6
               Left = 648
               Bottom = 123
               Right = 808
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 90' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_BusquedaMuestra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'0
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_BusquedaMuestra'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_BusquedaMuestra'
GO
/****** Object:  View [dbo].[Vista_Muestras]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Muestras]
AS
SELECT     dbo.muestras.id_Muestra, dbo.muestras.fecha, dbo.muestras.Hora, dbo.muestras.id_Empleados, dbo.muestras.id_LugarMuestra, dbo.muestras.id_TipoAgua, dbo.muestras.activo, 
                      dbo.empleados.nombre_apellido, dbo.TiposAguas.TipoAgua, dbo.lugar_muestras.sector, dbo.lugar_muestras.lugar_muestra, dbo.lugar_muestras.lugar_aleatorio, dbo.lugar_muestras.id_Localidad, 
                      dbo.lugar_muestras.observaciones, dbo.localidades.localidades
FROM         dbo.muestras INNER JOIN
                      dbo.TiposAguas ON dbo.muestras.id_TipoAgua = dbo.TiposAguas.id_TipoAgua INNER JOIN
                      dbo.lugar_muestras ON dbo.muestras.id_LugarMuestra = dbo.lugar_muestras.id_LugarMuestra INNER JOIN
                      dbo.localidades ON dbo.lugar_muestras.id_Localidad = dbo.localidades.id_Localidad INNER JOIN
                      dbo.empleados ON dbo.muestras.id_Empleados = dbo.empleados.id_Empleados
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[61] 4[15] 2[6] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "muestras"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 190
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposAguas"
            Begin Extent = 
               Top = 157
               Left = 244
               Bottom = 275
               Right = 404
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "lugar_muestras"
            Begin Extent = 
               Top = 6
               Left = 443
               Bottom = 187
               Right = 612
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "localidades"
            Begin Extent = 
               Top = 6
               Left = 650
               Bottom = 132
               Right = 810
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "empleados"
            Begin Extent = 
               Top = 0
               Left = 233
               Bottom = 140
               Right = 400
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Muestras'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'        Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1365
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Muestras'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Muestras'
GO
/****** Object:  View [dbo].[Vista_analisis]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_analisis]
AS
SELECT     dbo.analisis1.id_Analisis, dbo.analisis1.analisis, dbo.analisis1.fecha, dbo.analisis1.hora, dbo.analisis1.activo, dbo.analisis1.id_TecLaboratorio, dbo.tecnicolaboratorio.nombreapellido
FROM         dbo.analisis1 INNER JOIN
                      dbo.tecnicolaboratorio ON dbo.analisis1.id_TecLaboratorio = dbo.tecnicolaboratorio.id_TecLaboratorio
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "analisis1"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 179
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tecnicolaboratorio"
            Begin Extent = 
               Top = 6
               Left = 251
               Bottom = 181
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_analisis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_analisis'
GO
/****** Object:  View [dbo].[Vista_profe]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_profe]
AS
SELECT     dbo.tipos_analisis.tipoanalisis, dbo.NombreAnalisis.nombreanalisis, dbo.parametros.id_Parametro, dbo.parametros.activo, dbo.parametros.cod_alimentario, dbo.parametros.norm_provincial, 
                      dbo.parametros.norm_provincial_limite, dbo.NombreAnalisis.id_TipoAnalisis, dbo.parametros.cod_alimentario_limite, dbo.parametros.id_NombreAnalisis
FROM         dbo.tipos_analisis INNER JOIN
                      dbo.NombreAnalisis ON dbo.tipos_analisis.id_TipoAnalisis = dbo.NombreAnalisis.id_TipoAnalisis INNER JOIN
                      dbo.parametros ON dbo.NombreAnalisis.id_NombreAnalisis = dbo.parametros.id_NombreAnalisis
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[9] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tipos_analisis"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "parametros"
            Begin Extent = 
               Top = 96
               Left = 216
               Bottom = 297
               Right = 410
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NombreAnalisis"
            Begin Extent = 
               Top = 6
               Left = 468
               Bottom = 128
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_profe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_profe'
GO
/****** Object:  View [dbo].[Vista_Parametros]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Parametros]
AS
SELECT     dbo.parametros.id_Parametro, dbo.parametros.cod_alimentario, dbo.parametros.norm_provincial, dbo.parametros.id_NombreAnalisis, dbo.parametros.norm_provincial_limite, 
                      dbo.parametros.cod_alimentario_limite, dbo.parametros.activo, dbo.NombreAnalisis.id_TipoAnalisis, dbo.NombreAnalisis.nombreanalisis, dbo.tipos_analisis.tipoanalisis
FROM         dbo.parametros INNER JOIN
                      dbo.NombreAnalisis ON dbo.parametros.id_NombreAnalisis = dbo.NombreAnalisis.id_NombreAnalisis INNER JOIN
                      dbo.tipos_analisis ON dbo.NombreAnalisis.id_TipoAnalisis = dbo.tipos_analisis.id_TipoAnalisis
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "parametros"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 182
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NombreAnalisis"
            Begin Extent = 
               Top = 6
               Left = 270
               Bottom = 141
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tipos_analisis"
            Begin Extent = 
               Top = 6
               Left = 483
               Bottom = 111
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Parametros'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Parametros'
GO
/****** Object:  View [dbo].[vista_NombreAnalisis]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vista_NombreAnalisis]
AS
SELECT     dbo.NombreAnalisis.id_TipoAnalisis, dbo.NombreAnalisis.nombreanalisis, dbo.resultadosanalisis.resultado, dbo.resultadosanalisis.id_NombreAnalisis, dbo.analisis_detalles.id_ResultadoAnalisis, 
                      dbo.analisis1.analisis, dbo.analisis1.fecha, dbo.analisis1.hora, dbo.intermedia.id_Muestra, dbo.muestras.fechahora, dbo.muestras.id_LugarMuestra, dbo.lugar_muestras.sector, 
                      dbo.lugar_muestras.lugar_muestra, dbo.lugar_muestras.lugar_aleatorio, dbo.lugar_muestras.observaciones, dbo.analisis1.id_Analisis
FROM         dbo.resultadosanalisis INNER JOIN
                      dbo.NombreAnalisis ON dbo.resultadosanalisis.id_NombreAnalisis = dbo.NombreAnalisis.id_NombreAnalisis INNER JOIN
                      dbo.analisis_detalles ON dbo.resultadosanalisis.id_ResultadoAnalisis = dbo.analisis_detalles.id_ResultadoAnalisis INNER JOIN
                      dbo.analisis1 ON dbo.analisis_detalles.id_Analisis = dbo.analisis1.id_Analisis INNER JOIN
                      dbo.intermedia ON dbo.analisis1.id_Analisis = dbo.intermedia.id_Analisis INNER JOIN
                      dbo.muestras ON dbo.intermedia.id_Muestra = dbo.muestras.id_Muestra INNER JOIN
                      dbo.lugar_muestras ON dbo.muestras.id_LugarMuestra = dbo.lugar_muestras.id_LugarMuestra
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[68] 4[4] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -288
      End
      Begin Tables = 
         Begin Table = "resultadosanalisis"
            Begin Extent = 
               Top = 5
               Left = 493
               Bottom = 125
               Right = 679
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NombreAnalisis"
            Begin Extent = 
               Top = 14
               Left = 274
               Bottom = 134
               Right = 449
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "analisis_detalles"
            Begin Extent = 
               Top = 13
               Left = 957
               Bottom = 165
               Right = 1143
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "analisis1"
            Begin Extent = 
               Top = 143
               Left = 709
               Bottom = 296
               Right = 884
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "intermedia"
            Begin Extent = 
               Top = 138
               Left = 504
               Bottom = 258
               Right = 664
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "muestras"
            Begin Extent = 
               Top = 170
               Left = 287
               Bottom = 321
               Right = 456
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "lugar_muestras"
            Begin Extent = 
               Top = 108
               Left = 52
               Bottom = 272
               Right = 221
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vista_NombreAnalisis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'          End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 18
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vista_NombreAnalisis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vista_NombreAnalisis'
GO
/****** Object:  View [dbo].[Vista_dgbDoble]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_dgbDoble]
AS
SELECT     dbo.TiposAguas.TipoAgua, dbo.muestras.id_TipoAgua, dbo.intermedia.id_Muestra, dbo.intermedia.id_Analisis, dbo.analisis_detalles.id_AnalisisDetalles, dbo.analisis_detalles.id_TipoAnalisis, 
                      dbo.analisis_detalles.id_ResultadoAnalisis, dbo.analisis_detalles.activo, dbo.resultadosanalisis.resultado, dbo.NombreAnalisis.nombreanalisis, dbo.tipos_analisis.tipoanalisis, 
                      dbo.parametros.cod_alimentario, dbo.parametros.norm_provincial, dbo.parametros.norm_provincial_limite, dbo.parametros.cod_alimentario_limite, dbo.parametros.id_NombreAnalisis
FROM         dbo.analisis1 INNER JOIN
                      dbo.analisis_detalles ON dbo.analisis1.id_Analisis = dbo.analisis_detalles.id_Analisis INNER JOIN
                      dbo.intermedia ON dbo.analisis1.id_Analisis = dbo.intermedia.id_Analisis INNER JOIN
                      dbo.muestras ON dbo.intermedia.id_Muestra = dbo.muestras.id_Muestra INNER JOIN
                      dbo.TiposAguas ON dbo.muestras.id_TipoAgua = dbo.TiposAguas.id_TipoAgua INNER JOIN
                      dbo.resultadosanalisis ON dbo.analisis_detalles.id_ResultadoAnalisis = dbo.resultadosanalisis.id_ResultadoAnalisis INNER JOIN
                      dbo.NombreAnalisis ON dbo.resultadosanalisis.id_NombreAnalisis = dbo.NombreAnalisis.id_NombreAnalisis INNER JOIN
                      dbo.tipos_analisis ON dbo.NombreAnalisis.id_TipoAnalisis = dbo.tipos_analisis.id_TipoAnalisis INNER JOIN
                      dbo.parametros ON dbo.NombreAnalisis.id_NombreAnalisis = dbo.parametros.id_NombreAnalisis
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[69] 4[2] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -1
      End
      Begin Tables = 
         Begin Table = "analisis1"
            Begin Extent = 
               Top = 114
               Left = 67
               Bottom = 267
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "analisis_detalles"
            Begin Extent = 
               Top = 132
               Left = 370
               Bottom = 252
               Right = 556
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "intermedia"
            Begin Extent = 
               Top = 17
               Left = 582
               Bottom = 137
               Right = 742
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "muestras"
            Begin Extent = 
               Top = 0
               Left = 254
               Bottom = 138
               Right = 423
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposAguas"
            Begin Extent = 
               Top = 0
               Left = 20
               Bottom = 105
               Right = 180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "resultadosanalisis"
            Begin Extent = 
               Top = 263
               Left = 150
               Bottom = 383
               Right = 336
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NombreAnalisis"
            Begin Extent = 
               Top = 248
               Left = 435
               Bottom = 368
               Right = 610
           ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_dgbDoble'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tipos_analisis"
            Begin Extent = 
               Top = 126
               Left = 673
               Bottom = 231
               Right = 833
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "parametros"
            Begin Extent = 
               Top = 237
               Left = 719
               Bottom = 402
               Right = 911
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_dgbDoble'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_dgbDoble'
GO
/****** Object:  View [dbo].[Vista_Analisis1]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Analisis1]
AS
SELECT     dbo.analisis1.fecha, dbo.analisis1.hora, dbo.analisis1.activo, dbo.analisis1.id_TecLaboratorio, dbo.analisis_detalles.id_AnalisisDetalles, dbo.NombreAnalisis.nombreanalisis, 
                      dbo.analisis_detalles.id_ResultadoAnalisis, dbo.resultadosanalisis.id_NombreAnalisis, dbo.NombreAnalisis.id_TipoAnalisis, dbo.tipos_analisis.tipoanalisis, dbo.TiposAguas.TipoAgua, 
                      dbo.intermedia.id_Analisis, dbo.intermedia.id_Muestra, dbo.muestras.id_TipoAgua
FROM         dbo.analisis1 INNER JOIN
                      dbo.analisis_detalles ON dbo.analisis1.id_Analisis = dbo.analisis_detalles.id_Analisis INNER JOIN
                      dbo.resultadosanalisis ON dbo.analisis_detalles.id_ResultadoAnalisis = dbo.resultadosanalisis.id_ResultadoAnalisis INNER JOIN
                      dbo.NombreAnalisis ON dbo.resultadosanalisis.id_NombreAnalisis = dbo.NombreAnalisis.id_NombreAnalisis INNER JOIN
                      dbo.tipos_analisis ON dbo.NombreAnalisis.id_TipoAnalisis = dbo.tipos_analisis.id_TipoAnalisis INNER JOIN
                      dbo.intermedia ON dbo.analisis1.id_Analisis = dbo.intermedia.id_Analisis INNER JOIN
                      dbo.muestras ON dbo.intermedia.id_Muestra = dbo.muestras.id_Muestra INNER JOIN
                      dbo.TiposAguas ON dbo.muestras.id_TipoAgua = dbo.TiposAguas.id_TipoAgua
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[61] 4[17] 2[4] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "resultadosanalisis"
            Begin Extent = 
               Top = 45
               Left = 681
               Bottom = 218
               Right = 867
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NombreAnalisis"
            Begin Extent = 
               Top = 63
               Left = 894
               Bottom = 183
               Right = 1069
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tipos_analisis"
            Begin Extent = 
               Top = 138
               Left = 457
               Bottom = 243
               Right = 617
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "muestras"
            Begin Extent = 
               Top = 224
               Left = 227
               Bottom = 344
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TiposAguas"
            Begin Extent = 
               Top = 144
               Left = 38
               Bottom = 249
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "analisis1"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 141
               Right = 213
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "analisis_detalles"
            Begin Extent = 
               Top = 0
               Left = 423
               Bottom = 137
               Right = 609
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Analisis1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'    End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "intermedia"
            Begin Extent = 
               Top = 248
               Left = 515
               Bottom = 368
               Right = 675
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Analisis1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Analisis1'
GO
/****** Object:  View [dbo].[Vista_analisis_ultima]    Script Date: 07/30/2024 11:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_analisis_ultima]
AS
SELECT     dbo.analisis1.id_TecLaboratorio, dbo.analisis1.activo, dbo.tecnicolaboratorio.nombreapellido, dbo.parametros.cod_alimentario, dbo.parametros.norm_provincial, 
                      dbo.parametros.norm_provincial_limite, dbo.parametros.cod_alimentario_limite, dbo.NombreAnalisis.id_TipoAnalisis, dbo.NombreAnalisis.nombreanalisis, dbo.tipos_analisis.tipoanalisis, 
                      dbo.TiposAguas.TipoAgua, dbo.muestras.id_TipoAgua, dbo.resultadosanalisis.resultado, dbo.analisis_detalles.id_Analisis, dbo.analisis_detalles.id_ResultadoAnalisis, 
                      dbo.analisis_detalles.id_AnalisisDetalles, dbo.muestras.id_Muestra, dbo.lugar_muestras.lugar_muestra, dbo.lugar_muestras.lugar_aleatorio, dbo.muestras.id_LugarMuestra, dbo.analisis1.fecha, 
                      dbo.analisis1.hora, dbo.parametros.id_NombreAnalisis, dbo.intermedia.id_Intermedia
FROM         dbo.analisis_detalles INNER JOIN
                      dbo.analisis1 INNER JOIN
                      dbo.tecnicolaboratorio ON dbo.analisis1.id_TecLaboratorio = dbo.tecnicolaboratorio.id_TecLaboratorio ON dbo.analisis_detalles.id_Analisis = dbo.analisis1.id_Analisis INNER JOIN
                      dbo.resultadosanalisis ON dbo.analisis_detalles.id_ResultadoAnalisis = dbo.resultadosanalisis.id_ResultadoAnalisis INNER JOIN
                      dbo.NombreAnalisis INNER JOIN
                      dbo.tipos_analisis ON dbo.NombreAnalisis.id_TipoAnalisis = dbo.tipos_analisis.id_TipoAnalisis INNER JOIN
                      dbo.parametros ON dbo.NombreAnalisis.id_NombreAnalisis = dbo.parametros.id_NombreAnalisis ON 
                      dbo.resultadosanalisis.id_NombreAnalisis = dbo.NombreAnalisis.id_NombreAnalisis INNER JOIN
                      dbo.intermedia ON dbo.analisis1.id_Analisis = dbo.intermedia.id_Analisis INNER JOIN
                      dbo.muestras INNER JOIN
                      dbo.TiposAguas ON dbo.muestras.id_TipoAgua = dbo.TiposAguas.id_TipoAgua INNER JOIN
                      dbo.lugar_muestras ON dbo.muestras.id_LugarMuestra = dbo.lugar_muestras.id_LugarMuestra ON dbo.intermedia.id_Muestra = dbo.muestras.id_Muestra
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[68] 4[9] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "analisis_detalles"
            Begin Extent = 
               Top = 0
               Left = 200
               Bottom = 120
               Right = 386
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "analisis1"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 146
               Right = 175
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tecnicolaboratorio"
            Begin Extent = 
               Top = 185
               Left = 4
               Bottom = 356
               Right = 179
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "resultadosanalisis"
            Begin Extent = 
               Top = 152
               Left = 401
               Bottom = 292
               Right = 587
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NombreAnalisis"
            Begin Extent = 
               Top = 0
               Left = 590
               Bottom = 126
               Right = 765
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tipos_analisis"
            Begin Extent = 
               Top = 165
               Left = 855
               Bottom = 277
               Right = 1015
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "parametros"
            Begin Extent = 
               Top = 0
               Left = 823
               Bottom = 163
               Right = 1017
 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_analisis_ultima'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'           End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "intermedia"
            Begin Extent = 
               Top = 132
               Left = 209
               Bottom = 252
               Right = 369
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "muestras"
            Begin Extent = 
               Top = 260
               Left = 197
               Bottom = 434
               Right = 366
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TiposAguas"
            Begin Extent = 
               Top = 361
               Left = 484
               Bottom = 471
               Right = 644
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "lugar_muestras"
            Begin Extent = 
               Top = 242
               Left = 662
               Bottom = 406
               Right = 831
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 24
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1785
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_analisis_ultima'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_analisis_ultima'
GO
/****** Object:  ForeignKey [FK__analisis___id_re__4D94879B]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[analisis_detalles]  WITH CHECK ADD  CONSTRAINT [FK__analisis___id_re__4D94879B] FOREIGN KEY([id_ResultadoAnalisis])
REFERENCES [dbo].[resultadosanalisis] ([id_ResultadoAnalisis])
GO
ALTER TABLE [dbo].[analisis_detalles] CHECK CONSTRAINT [FK__analisis___id_re__4D94879B]
GO
/****** Object:  ForeignKey [FK_analisis_detalles_analisis1]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[analisis_detalles]  WITH CHECK ADD  CONSTRAINT [FK_analisis_detalles_analisis1] FOREIGN KEY([id_Analisis])
REFERENCES [dbo].[analisis1] ([id_Analisis])
GO
ALTER TABLE [dbo].[analisis_detalles] CHECK CONSTRAINT [FK_analisis_detalles_analisis1]
GO
/****** Object:  ForeignKey [FK_analisis1_tecnicolaboratorio]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[analisis1]  WITH CHECK ADD  CONSTRAINT [FK_analisis1_tecnicolaboratorio] FOREIGN KEY([id_TecLaboratorio])
REFERENCES [dbo].[tecnicolaboratorio] ([id_TecLaboratorio])
GO
ALTER TABLE [dbo].[analisis1] CHECK CONSTRAINT [FK_analisis1_tecnicolaboratorio]
GO
/****** Object:  ForeignKey [FK_intermedia_analisis1]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[intermedia]  WITH CHECK ADD  CONSTRAINT [FK_intermedia_analisis1] FOREIGN KEY([id_Analisis])
REFERENCES [dbo].[analisis1] ([id_Analisis])
GO
ALTER TABLE [dbo].[intermedia] CHECK CONSTRAINT [FK_intermedia_analisis1]
GO
/****** Object:  ForeignKey [FK_intermedia_muestras]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[intermedia]  WITH CHECK ADD  CONSTRAINT [FK_intermedia_muestras] FOREIGN KEY([id_Muestra])
REFERENCES [dbo].[muestras] ([id_Muestra])
GO
ALTER TABLE [dbo].[intermedia] CHECK CONSTRAINT [FK_intermedia_muestras]
GO
/****** Object:  ForeignKey [FK_lugar_muestras_localidades]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[lugar_muestras]  WITH CHECK ADD  CONSTRAINT [FK_lugar_muestras_localidades] FOREIGN KEY([id_Localidad])
REFERENCES [dbo].[localidades] ([id_Localidad])
GO
ALTER TABLE [dbo].[lugar_muestras] CHECK CONSTRAINT [FK_lugar_muestras_localidades]
GO
/****** Object:  ForeignKey [FK__muestras__id_emp__25869641]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[muestras]  WITH CHECK ADD  CONSTRAINT [FK__muestras__id_emp__25869641] FOREIGN KEY([id_Empleados])
REFERENCES [dbo].[empleados] ([id_Empleados])
GO
ALTER TABLE [dbo].[muestras] CHECK CONSTRAINT [FK__muestras__id_emp__25869641]
GO
/****** Object:  ForeignKey [FK__muestras__idluga__267ABA7A]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[muestras]  WITH CHECK ADD  CONSTRAINT [FK__muestras__idluga__267ABA7A] FOREIGN KEY([id_LugarMuestra])
REFERENCES [dbo].[lugar_muestras] ([id_LugarMuestra])
GO
ALTER TABLE [dbo].[muestras] CHECK CONSTRAINT [FK__muestras__idluga__267ABA7A]
GO
/****** Object:  ForeignKey [FK_muestras_TiposAguas]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[muestras]  WITH CHECK ADD  CONSTRAINT [FK_muestras_TiposAguas] FOREIGN KEY([id_TipoAgua])
REFERENCES [dbo].[TiposAguas] ([id_TipoAgua])
GO
ALTER TABLE [dbo].[muestras] CHECK CONSTRAINT [FK_muestras_TiposAguas]
GO
/****** Object:  ForeignKey [FK_Muestras_Seguimientos_muestras]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[Muestras_Seguimientos]  WITH CHECK ADD  CONSTRAINT [FK_Muestras_Seguimientos_muestras] FOREIGN KEY([id_Muestra])
REFERENCES [dbo].[muestras] ([id_Muestra])
GO
ALTER TABLE [dbo].[Muestras_Seguimientos] CHECK CONSTRAINT [FK_Muestras_Seguimientos_muestras]
GO
/****** Object:  ForeignKey [FK_Muestras_Seguimientos_seguimientos]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[Muestras_Seguimientos]  WITH CHECK ADD  CONSTRAINT [FK_Muestras_Seguimientos_seguimientos] FOREIGN KEY([id_Seguimiento])
REFERENCES [dbo].[seguimientos] ([id_Seguimiento])
GO
ALTER TABLE [dbo].[Muestras_Seguimientos] CHECK CONSTRAINT [FK_Muestras_Seguimientos_seguimientos]
GO
/****** Object:  ForeignKey [FK_NombreAnalisis_tipos_analisis]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[NombreAnalisis]  WITH CHECK ADD  CONSTRAINT [FK_NombreAnalisis_tipos_analisis] FOREIGN KEY([id_TipoAnalisis])
REFERENCES [dbo].[tipos_analisis] ([id_TipoAnalisis])
GO
ALTER TABLE [dbo].[NombreAnalisis] CHECK CONSTRAINT [FK_NombreAnalisis_tipos_analisis]
GO
/****** Object:  ForeignKey [FK_parametros_NombreAnalisis]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[parametros]  WITH CHECK ADD  CONSTRAINT [FK_parametros_NombreAnalisis] FOREIGN KEY([id_NombreAnalisis])
REFERENCES [dbo].[NombreAnalisis] ([id_NombreAnalisis])
GO
ALTER TABLE [dbo].[parametros] CHECK CONSTRAINT [FK_parametros_NombreAnalisis]
GO
/****** Object:  ForeignKey [FK_reclamos_tipos_reclamo]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[reclamos]  WITH CHECK ADD  CONSTRAINT [FK_reclamos_tipos_reclamo] FOREIGN KEY([id_TipoReclamo])
REFERENCES [dbo].[tipos_reclamo] ([id_TipoReclamo])
GO
ALTER TABLE [dbo].[reclamos] CHECK CONSTRAINT [FK_reclamos_tipos_reclamo]
GO
/****** Object:  ForeignKey [FK_resultadosanalisis_NombreAnalisis]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[resultadosanalisis]  WITH CHECK ADD  CONSTRAINT [FK_resultadosanalisis_NombreAnalisis] FOREIGN KEY([id_NombreAnalisis])
REFERENCES [dbo].[NombreAnalisis] ([id_NombreAnalisis])
GO
ALTER TABLE [dbo].[resultadosanalisis] CHECK CONSTRAINT [FK_resultadosanalisis_NombreAnalisis]
GO
/****** Object:  ForeignKey [FK__tecnicola__idlab__300424B4]    Script Date: 07/30/2024 11:05:16 ******/
ALTER TABLE [dbo].[tecnicolaboratorio]  WITH CHECK ADD FOREIGN KEY([id_Laboratorio])
REFERENCES [dbo].[laboratorios] ([id_Laboratorio])
GO
