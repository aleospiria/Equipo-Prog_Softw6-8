﻿using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class AsignaturasPruebasUnitarias
    {
        private IAsignaturasRepositorio? iRepositorio = null;
        private Asignaturas? entidad = null;
        public AsignaturasPruebasUnitarias()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=EvilCC\\ACOSTA;database=bd_catalogo; TrustServerCertificate = true; ";
            iRepositorio = new AsignaturasRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }
        private void Guardar()
        {
            entidad = new Asignaturas()
            {
                NombreAsignatura = "Prueba",
                Duracion = "tiempo prueba"
            };
            entidad = iRepositorio!.Guardar(entidad);
            Assert.IsTrue(entidad.Id != 0);
        }
        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
        private void Buscar()
        {
            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Modificar()
        {
            entidad!.NombreAsignatura = "Prueba Modificada";
            entidad = iRepositorio!.Modificar(entidad);
            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }
        private void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);
            var lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}
