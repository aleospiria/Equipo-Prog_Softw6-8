CREATE DATABASE DB_Universidad;
GO
USE DB_Universidad;
GO

CREATE TABLE [Estudiantes]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1),
    [Carnet] VARCHAR(50) NOT NULL,
    [Nombre] VARCHAR(100) NOT NULL,
    [Apellido] VARCHAR(100) NOT NULL,
    [Direccion] VARCHAR(255),
    [Celular] VARCHAR(15),
    [Estado] BIT NOT NULL 
)
GO


CREATE TABLE [Materias]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1), 
    [Nombre] VARCHAR(100) NOT NULL,
    [Facultad] VARCHAR(100)
)
GO

CREATE TABLE [Profesores]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1),
    [Nombre] VARCHAR(100) NOT NULL,
    [Apellido] VARCHAR(100) NOT NULL,
    [Direccion] VARCHAR(255),
    [Celular] VARCHAR(15)
)
GO

CREATE TABLE [Salones]
(
	[Id] VARCHAR(50) PRIMARY KEY,
    [TipoSalon] VARCHAR(50) NOT NULL
)
GO

CREATE TABLE [Grupos]
(
	[Id] INT PRIMARY KEY IDENTITY(1,1), 
    [MateriaId] INT FOREIGN KEY REFERENCES Materias(Id),
    [Capacidad] INT NOT NULL,
    [NumSalon] VARCHAR(50) FOREIGN KEY REFERENCES Salones(Id)
)
GO