CREATE DATABASE bd_Universidad
GO
USE bd_Universidad
GO

CREATE TABLE [Estudiantes] (
    [Matricula] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nombre] NVARCHAR(50) NOT NULL,
	[Edad] INT NOT NULL
);
GO

CREATE TABLE [Profesores] (
    [Cedula] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nombre] NVARCHAR(50) NOT NULL,
	[Departamento] NVARCHAR(30) NOT NULL,
	[Salario] MONEY,
);
GO


CREATE TABLE [Asignaturas] (
    [CodigoAsignatura] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[NombreAsignatura] NVARCHAR(50) NOT NULL,
    [Duracion] NVARCHAR(50) NOT NULL,
	[Curso] INT NOT NULL,
	CONSTRAINT [FK_Curso] FOREIGN KEY ([Curso]) REFERENCES [Cursos] ([CodigoCurso]) ON DELETE No Action ON UPDATE No Action,
);
GO

CREATE TABLE [Departamentos] (
    [CodigoDepartamento] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [NombreDepartamento] NVARCHAR(50) NOT NULL,
	[Facultad] INT NOT NULL,
	[Curso] INT NOT NULL,
	CONSTRAINT [FK_Facultad] FOREIGN KEY ([Facultad]) REFERENCES [Facultades] ([CodigoFacultad]) ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT [FK_CursoDep] FOREIGN KEY ([Curso]) REFERENCES [Cursos] ([CodigoCurso]) ON DELETE No Action ON UPDATE No Action,
);
GO

CREATE TABLE [Facultades] (
    [CodigoFacultad] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [NombreFacultad] NVARCHAR(50) NOT NULL,
);
GO

CREATE TABLE [Cursos] (
    [CodigoCurso] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [NombreCurso] NVARCHAR(50) NOT NULL,
	[Creditos] INT NOT NULL,
	[Profesor] INT NOT NULL,
	CONSTRAINT [FK_Profesor] FOREIGN KEY ([Profesor]) REFERENCES [Profesores] ([Cedula]) ON DELETE No Action ON UPDATE No Action
);
GO
ALTER TABLE [Cursos]
ADD [Estudiante] INT NOT NULL
ALTER TABLE [Cursos]
ADD CONSTRAINT [FK_Estudiante] FOREIGN KEY ([Estudiante]) REFERENCES [Estudiantes] ([Matricula]) ON DELETE No Action ON UPDATE No Action

ALTER TABLE [Cursos]
ADD [Departamento] INT NOT NULL
ALTER TABLE [Cursos]
ADD CONSTRAINT [FK_Departamento] FOREIGN KEY ([Departamento]) REFERENCES [Departamentos] ([CodigoDepartamento]) ON DELETE No Action ON UPDATE No Action


-- Insertar datos en la tabla Estudiantes
INSERT INTO Estudiantes ([Nombre],[Edad] ) VALUES ('Juan Perez',23);
INSERT INTO Estudiantes ([Nombre],[Edad]) VALUES ('Sandra Garcia',34);
INSERT INTO Estudiantes ([Nombre],[Edad]) VALUES ('Pablo Lima',26);
INSERT INTO Estudiantes ([Nombre],[Edad]) VALUES ('Luisa Estrada',28);
GO

-- Insertar datos en la tabla Profesores
INSERT INTO Profesores ([Nombre],[Departamento],[Salario]) VALUES ('Gustavo Cuello',1,1300000);
INSERT INTO Profesores ([Nombre],[Departamento],[Salario]) VALUES ('Armando Segura',3,1400000);
INSERT INTO Profesores ([Nombre],[Departamento],[Salario]) VALUES ('Luis Aragon',2,1200000);
INSERT INTO Profesores ([Nombre],[Departamento],[Salario]) VALUES ('Cristina Cardenas',1,1500000);
GO

-- Insertar datos en la tabla Cursos
INSERT INTO Cursos ([NombreCurso], [Creditos],[Profesor],[Estudiante],[Departamento]) VALUES ('Bases de Datos', 2, 1, 1, 1);
INSERT INTO Cursos ([NombreCurso], [Creditos],[Profesor],[Estudiante],[Departamento]) VALUES ('Primeros Auxilios', 4, 2, 4, 3);
INSERT INTO Cursos ([NombreCurso], [Creditos],[Profesor],[Estudiante],[Departamento]) VALUES ('Enfermeria II', 4, 2, 2, 3);
INSERT INTO Cursos ([NombreCurso], [Creditos],[Profesor],[Estudiante],[Departamento]) VALUES ('Calculo Integral', 2, 1, 1, 1);
GO

-- Insertar datos en la tabla Asignaturas
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Enfermeria II', 34, 3);
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Bases de Datos', 68, 1);
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Primeros Auxilios', 75, 2);
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Calculo Integral', 68, 4);
GO

-- Insertar datos en la tabla Facultades
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Medicina');
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Ingenieria');
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Artes');
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Ciencias Exactas');
GO

-- Insertar datos en la tabla Departamentos
INSERT INTO Departamentos ([NombreDepartamento], [Facultad], [Curso]) VALUES ('Boston', 2, 1);
INSERT INTO Departamentos ([NombreDepartamento], [Facultad], [Curso]) VALUES ('Robledo', 2, 2);
INSERT INTO Departamentos ([NombreDepartamento], [Facultad], [Curso]) VALUES ('Floresta', 1, 3);
GO