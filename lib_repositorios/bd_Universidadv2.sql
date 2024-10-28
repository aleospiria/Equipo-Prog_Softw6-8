CREATE DATABASE bd_Universidad
GO
USE bd_Universidad
GO

-- Tabla Estudiantes
CREATE TABLE [Estudiantes] (
    [Matricula] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nombre] NVARCHAR(50) NOT NULL,
	[Edad] INT NOT NULL
);
GO
-- Tabla Facultades
CREATE TABLE [Facultades] (
    [CodigoFacultad] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [NombreFacultad] NVARCHAR(50) NOT NULL
);
GO
-- Tabla Departamentos
CREATE TABLE [Departamentos] (
    [CodigoDepartamento] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [NombreDepartamento] NVARCHAR(50) NOT NULL,
	[Facultad] INT NOT NULL,
	CONSTRAINT [FK_Facultad] FOREIGN KEY ([Facultad]) REFERENCES [Facultades] ([CodigoFacultad]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO

-- Tabla Profesores
CREATE TABLE [Profesores] (
    [Cedula] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nombre] NVARCHAR(50) NOT NULL,
	[Departamento] NVARCHAR(30) NOT NULL,
	[Salario] MONEY
);
GO



-- Tabla Cursos
CREATE TABLE [Cursos] (
    [CodigoCurso] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [NombreCurso] NVARCHAR(50) NOT NULL,
	[Creditos] INT NOT NULL,
	[Profesor] INT NOT NULL,
	[Departamento] INT NOT NULL,
	CONSTRAINT [FK_Profesor] FOREIGN KEY ([Profesor]) REFERENCES [Profesores] ([Cedula]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [FK_Departamento] FOREIGN KEY ([Departamento]) REFERENCES [Departamentos] ([CodigoDepartamento]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO

-- Tabla Asignaturas
CREATE TABLE [Asignaturas] (
    [CodigoAsignatura] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[NombreAsignatura] NVARCHAR(50) NOT NULL,
    [Duracion] NVARCHAR(50) NOT NULL,
	[Curso] INT NOT NULL,
	CONSTRAINT [FK_CursoA] FOREIGN KEY ([Curso]) REFERENCES [Cursos] ([CodigoCurso]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO



-- Tabla intermedia Estudiantes_Cursos
CREATE TABLE [Estudiantes_Cursos] (
    [Estudiante] INT NOT NULL,
    [Curso] INT NOT NULL,
    CONSTRAINT [PK_Estudiantes_Cursos] PRIMARY KEY ([Estudiante], [Curso]),
    CONSTRAINT [FK_Estudiante] FOREIGN KEY ([Estudiante]) REFERENCES [Estudiantes] ([Matricula]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    CONSTRAINT [FK_Curso] FOREIGN KEY ([Curso]) REFERENCES [Cursos] ([CodigoCurso]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO

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

-- Insertar departamentos
INSERT INTO Departamentos ([NombreDepartamento], [Facultad]) VALUES ('Ciencias de la Computación', 2);  -- Facultad de Ingeniería
INSERT INTO Departamentos ([NombreDepartamento], [Facultad]) VALUES ('Biología', 1);                    -- Facultad de Ciencias
INSERT INTO Departamentos ([NombreDepartamento], [Facultad]) VALUES ('Ingeniería Electrónica', 2);     -- Facultad de Ingeniería
INSERT INTO Departamentos ([NombreDepartamento], [Facultad]) VALUES ('Medicina General', 3);            -- Facultad de Medicina
GO


-- Insertar los cursos con el contexto correcto

INSERT INTO Cursos ([NombreCurso], [Creditos], [Profesor], [Departamento]) 
VALUES ('Bases de Datos', 2, 1, 1);
INSERT INTO Cursos ([NombreCurso], [Creditos], [Profesor], [Departamento]) 
VALUES ('Primeros Auxilios', 4, 2, 3);
INSERT INTO Cursos ([NombreCurso], [Creditos], [Profesor], [Departamento]) 
VALUES ('Enfermería II', 4, 2, 3);
INSERT INTO Cursos ([NombreCurso], [Creditos], [Profesor], [Departamento]) 
VALUES ('Cálculo Integral', 2, 1, 1);

GO

-- Insertar datos en la tabla Asignaturas
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Enfermeria II', '34 horas', 9);
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Bases de Datos', '68 horas', 10);
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Primeros Auxilios', '75 horas', 11);
INSERT INTO Asignaturas ([NombreAsignatura], [Duracion], [Curso]) VALUES ('Calculo Integral', '68 horas', 12);
GO


-- Insertar datos en la tabla Facultades
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Medicina');
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Ingenieria');
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Artes');
INSERT INTO Facultades ([NombreFacultad]) VALUES ('Facultad de Ciencias Exactas');
GO

-- Insertar datos en tabla Estudiantes_cursos
INSERT INTO Estudiantes_Cursos ([Estudiante], [Curso]) VALUES (1, 9);
INSERT INTO Estudiantes_Cursos ([Estudiante], [Curso]) VALUES (3, 11);
INSERT INTO Estudiantes_Cursos ([Estudiante], [Curso]) VALUES (2, 12);
INSERT INTO Estudiantes_Cursos ([Estudiante], [Curso]) VALUES (4, 10);
GO


