USE [db_universidades]
GO
/****** Object:  Table [dbo].[Asignaturas]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaturas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
	[Semestre] [int] NOT NULL,
	[DepartamentosId] [int] NOT NULL,
	[ProfesoresId] [int] NULL,
 CONSTRAINT [PK_Asignaturas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsignaturasCursos]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignaturasCursos](
	[AsignaturasId] [int] NOT NULL,
	[CursosId] [int] NOT NULL,
 CONSTRAINT [PK_AsignaturasCursos] PRIMARY KEY CLUSTERED 
(
	[AsignaturasId] ASC,
	[CursosId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Fecha_Inicio] [datetime2](7) NOT NULL,
	[FacultadesId] [int] NOT NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursosEstudiantes]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursosEstudiantes](
	[CursosId] [int] NOT NULL,
	[EstudiantesId] [int] NOT NULL,
 CONSTRAINT [PK_CursosEstudiantes] PRIMARY KEY CLUSTERED 
(
	[CursosId] ASC,
	[EstudiantesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Descipcion] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[FacultadesId] [int] NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Numero_de_Contacto] [int] NOT NULL,
 CONSTRAINT [PK_Estudiantes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facultades]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facultades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Decano] [nvarchar](max) NULL,
 CONSTRAINT [PK_Facultades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 10/11/2024 14:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[Contacto] [int] NOT NULL,
	[FechaContratacion] [datetime2](7) NOT NULL,
	[Salario] [float] NOT NULL,
	[DepartamentosId] [int] NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asignaturas]  WITH CHECK ADD  CONSTRAINT [FK_Asignaturas_Departamentos_DepartamentosId] FOREIGN KEY([DepartamentosId])
REFERENCES [dbo].[Departamentos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Asignaturas] CHECK CONSTRAINT [FK_Asignaturas_Departamentos_DepartamentosId]
GO
ALTER TABLE [dbo].[Asignaturas]  WITH CHECK ADD  CONSTRAINT [FK_Asignaturas_Profesores_ProfesoresId] FOREIGN KEY([ProfesoresId])
REFERENCES [dbo].[Profesores] ([Id])
GO
ALTER TABLE [dbo].[Asignaturas] CHECK CONSTRAINT [FK_Asignaturas_Profesores_ProfesoresId]
GO
ALTER TABLE [dbo].[AsignaturasCursos]  WITH CHECK ADD  CONSTRAINT [FK_AsignaturasCursos_Asignaturas_AsignaturasId] FOREIGN KEY([AsignaturasId])
REFERENCES [dbo].[Asignaturas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AsignaturasCursos] CHECK CONSTRAINT [FK_AsignaturasCursos_Asignaturas_AsignaturasId]
GO
ALTER TABLE [dbo].[AsignaturasCursos]  WITH CHECK ADD  CONSTRAINT [FK_AsignaturasCursos_Cursos_CursosId] FOREIGN KEY([CursosId])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[AsignaturasCursos] CHECK CONSTRAINT [FK_AsignaturasCursos_Cursos_CursosId]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Facultades_FacultadesId] FOREIGN KEY([FacultadesId])
REFERENCES [dbo].[Facultades] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Facultades_FacultadesId]
GO
ALTER TABLE [dbo].[CursosEstudiantes]  WITH CHECK ADD  CONSTRAINT [FK_CursosEstudiantes_Cursos_CursosId] FOREIGN KEY([CursosId])
REFERENCES [dbo].[Cursos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CursosEstudiantes] CHECK CONSTRAINT [FK_CursosEstudiantes_Cursos_CursosId]
GO
ALTER TABLE [dbo].[CursosEstudiantes]  WITH CHECK ADD  CONSTRAINT [FK_CursosEstudiantes_Estudiantes_EstudiantesId] FOREIGN KEY([EstudiantesId])
REFERENCES [dbo].[Estudiantes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CursosEstudiantes] CHECK CONSTRAINT [FK_CursosEstudiantes_Estudiantes_EstudiantesId]
GO
ALTER TABLE [dbo].[Departamentos]  WITH CHECK ADD  CONSTRAINT [FK_Departamentos_Facultades_FacultadesId] FOREIGN KEY([FacultadesId])
REFERENCES [dbo].[Facultades] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Departamentos] CHECK CONSTRAINT [FK_Departamentos_Facultades_FacultadesId]
GO
ALTER TABLE [dbo].[Profesores]  WITH CHECK ADD  CONSTRAINT [FK_Profesores_Departamentos_DepartamentosId] FOREIGN KEY([DepartamentosId])
REFERENCES [dbo].[Departamentos] ([Id])
GO
ALTER TABLE [dbo].[Profesores] CHECK CONSTRAINT [FK_Profesores_Departamentos_DepartamentosId]
GO
