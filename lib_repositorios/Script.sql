CREATE DATABASE db_universidades;
GO
USE db_universidades
GO

CREATE TABLE Universidades (
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Nombre] NVARCHAR(100) NOT NULL,
	[Direccion] NVARCHAR(250) NOT NULL,
	[Telefono] NVARCHAR(10) NOT NULL,
	[Fecha] SMALLDATETIME NOT NULL,
	[Cant_est] int(250) NOT NULL,
	[Cant_profes] int(250) NOT NULL,
	[Cant_carreras] int(250) NOT NULL,
	[Activa] BIT NOT NULL,
);
INSERT INTO Universidades (Nombre, Direccion, Telefono, Fecha, Cant_est, Cant_profes, Cant_carreras, Activa)
VALUES ('Universidad de antioquia', 'Avenida del Mar 123, Playa del Carmen', '5551234567', '2023-10-01 10:00:00', 2000, 40, 25, 1);

INSERT INTO Universidades (Nombre, Direccion, Telefono, Fecha, Cant_est, Cant_profes, Cant_carreras, Activa)
VALUES ('ITM', 'Camino de la Sierra 456, Valle de Bravo', '5559876543', '2023-10-02 12:30:00', 3000, 38, 32, 1);

INSERT INTO Universidades (Nombre, Direccion, Telefono, Fecha, Cant_est, Cant_profes, Cant_carreras, Activa)
VALUES ('Universidad nacional', 'Calle Principal 789, Ciudad de México', '5556543210', '2023-10-03 15:45:00', 2104, 42, 50, 0);

SELECT * FROM Universidades