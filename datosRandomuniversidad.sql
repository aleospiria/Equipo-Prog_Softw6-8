--Estudiantesdatos
INSERT INTO Estudiantes (Nombre, Apellido, FechaNacimiento, Edad, Direccion, Numero_de_Contacto) VALUES
('Juan', 'Perez', '1995-05-15', 27, '123 Main St', 1234567890),
('Maria', 'Garcia', '1998-07-21', 24, '456 Maple Ave', 1234567891),
('Pedro', 'Lopez', '1997-12-11', 25, '789 Oak Blvd', 1234567892),
('Luisa', 'Martinez', '2000-03-18', 22, '101 Pine St', 1234567893),
('Ana', 'Hernandez', '1999-01-25', 23, '202 Birch Rd', 1234567894);
--FacultadDatos
INSERT INTO Facultades (Nombre, Telefono, Email, Descripcion, Decano) VALUES
('Ingenier�a', '555-1234', 'ingenieria@universidad.edu', 'Facultad de Ingenier�a', 'Dr. Fernando Torres'),
('Medicina', '555-5678', 'medicina@universidad.edu', 'Facultad de Medicina', 'Dra. Claudia Rojas'),
('Derecho', '555-8765', 'derecho@universidad.edu', 'Facultad de Derecho', 'Dr. Luis Paredes'),
('Ciencias', '555-4321', 'ciencias@universidad.edu', 'Facultad de Ciencias', 'Dra. Teresa Ram�rez'),
('Artes', '555-6789', 'artes@universidad.edu', 'Facultad de Artes', 'Dr. Jorge Molina');
--ProfesoresDatos
INSERT INTO Profesores (Nombres, Apellidos, Contacto, FechaContratacion, Salario, DepartamentosId) VALUES
('Carlos', 'Ramirez', 1234567895, '2021-05-12', 50000, 1),
('Laura', 'Gomez', 1234567896, '2019-07-22', 55000, 2),
('Jorge', 'Martinez', 1234567897, '2020-08-30', 60000, 3),
('Sofia', 'Lopez', 1234567898, '2018-10-11', 52000, 4),
('Daniel', 'Perez', 1234567899, '2017-11-23', 58000, 5);
--DepartamentosDatos
INSERT INTO Departamentos (Nombre, Descipcion, Telefono, Email, FacultadesId) VALUES
('Matem�ticas', 'Departamento de Matem�ticas', '555-0001', 'matematicas@universidad.edu', 1),
('Anatom�a', 'Departamento de Anatom�a', '555-0002', 'anatomia@universidad.edu', 2),
('Civil', 'Departamento de Derecho Civil', '555-0003', 'civil@universidad.edu', 3),
('Qu�mica', 'Departamento de Qu�mica', '555-0004', 'quimica@universidad.edu', 4),
('Escultura', 'Departamento de Escultura', '555-0005', 'escultura@universidad.edu', 5);
--AsignaturasDatos
INSERT INTO Asignaturas (Nombre, Codigo, Semestre, DepartamentosId, ProfesoresId) VALUES
('�lgebra', 'MAT101', 1, 1, 1),
('Anatom�a Humana', 'BIO102', 2, 2, 2),
('Derecho Constitucional', 'LAW103', 3, 3, 3),
('Qu�mica Org�nica', 'CHE104', 2, 4, 4),
('Escultura Moderna', 'ART105', 1, 5, 5);
--CursosDatos
INSERT INTO Cursos (Nombre, Descripcion, Fecha_Inicio, FacultadesId) VALUES
('Matem�ticas', 'Curso de matem�ticas avanzadas', '2023-01-10', 1),
('Biolog�a', 'Curso de biolog�a general', '2023-02-14', 2),
('Derecho Civil', 'Introducci�n al derecho civil', '2023-03-18', 3),
('F�sica', 'Curso de f�sica te�rica', '2023-04-20', 4),
('Pintura', 'Curso de t�cnicas de pintura', '2023-05-22', 5);
--AsignaturasCursos
INSERT INTO AsignaturasCursos (AsignaturasId, CursosId) VALUES
(4, 1),
(5, 2),
(3, 3),
(7, 4),
(6, 5);

--CrusosEstudiantesDatos
INSERT INTO CursosEstudiantes (CursosId, EstudiantesId) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

