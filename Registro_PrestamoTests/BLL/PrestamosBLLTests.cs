using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro_Prestamo.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using Registro_Prestamo.Models;

namespace Registro_Prestamo.BLL.Tests
{
    [TestClass()]
    public class PrestamosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            decimal BalanceActual;
            Personas persona;
            bool paso;
            Prestamos prestamo = new Prestamos();

            prestamo.PrestamoId = 0;
            prestamo.Fecha = DateTime.Now;
            prestamo.PersonaId = 1;
            prestamo.Concepto = "Motor";
            prestamo.Monto = 5000;
            prestamo.Balance = prestamo.Monto;
            paso = PrestamosBLL.Guardar(prestamo);

            persona = PersonasBLL.Buscar(prestamo.PersonaId);
            BalanceActual = persona.Balance;

            if (0 < BalanceActual)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            decimal BalanceActual;
            Personas persona;
            bool paso;
            Prestamos prestamo = new Prestamos();

            prestamo.PrestamoId = 1;
            prestamo.Fecha = DateTime.Now;
            prestamo.PersonaId = 1;
            prestamo.Concepto = "Motor";
            prestamo.Monto = 6000;
            prestamo.Balance = prestamo.Monto;
            paso = PrestamosBLL.Guardar(prestamo);

            persona = PersonasBLL.Buscar(prestamo.PersonaId);
            BalanceActual = persona.Balance;

            if (5000 < BalanceActual)
                paso = true;
            else
                paso = false;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Prestamos prestamo;
            prestamo = PrestamosBLL.Buscar(1);

            Assert.AreEqual(prestamo, prestamo);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = PrestamosBLL.Eliminar(1,1);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetPrestamosTest()
        {
            var lista = new List<Prestamos>();
            lista = PrestamosBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }
    }
}