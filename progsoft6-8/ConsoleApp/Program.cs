﻿using ConsoleApp.Clases.Definicion;
using ConsoleApp.Clases.Entidades;
using ConsoleApp.Conexion;

/*
var clases = new Clases();
clases.Ejecutar();

var modelo = new Modelos();
modelo.Ejecutar();

var modeloComplejo = new ModeloComplejo();
modeloComplejo.Ejecutar();

var conexion = new ConexionBasica();
conexion.NonQueryPeliculas();
conexion.ObtenerPeliculas_Procedimiento();
*/

var conexionEF = new ConsoleApp.Conexion.ConexionEF();
//conexionEF.NonQueryPeliculas();
conexionEF.ObtenerPeliculas();

var conexionPro = new ConsoleApp.Proyecto.ConexionEF();
  conexionPro.ObtenerEstudiantes();
