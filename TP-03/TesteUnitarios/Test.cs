using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exepciones;
using EntidadesAbstractas;
using ClasesInstanciables;

namespace TesteUnitarios
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Testea que la funcion lanza la excepcion correspondiente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidExeptionn()
        {
            Alumno invalida = new Alumno(1,"Carolina", "Stomboli", "bscedsse" , Persona.ENacionalidad.Argentino,Universidad.EClases.Laboratorio);           
        }

        /// <summary>
        /// Testea que la funcion lanza la excepcion correspondiente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void testAlumnoRepetidoException()
        {
            Alumno invalida = new Alumno(1, "Carolina", "Stomboli", "34998577", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno invalida1 = new Alumno(1, "Carolina", "Stomboli", "34998577", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Universidad uni = new Universidad();

            uni += invalida;
            uni += invalida1;
        }

        /// <summary>
        /// Testea que la funcion reciba el dni correctamente.
        /// </summary>
        [TestMethod]       
        public void TestValorNumerico()
        {
            int expected = 33210120;

            Alumno pro = new Alumno(5,"Juan","Benitez", "33210120",Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

            Assert.AreEqual(expected, pro.DNI);            
        }

        /// <summary>
        /// Testea que la funcion no reciba un alumno null.
        /// </summary>
        [TestMethod]
        public void TestNotNull()
        {           
            Alumno pro = new Alumno(2, "Michael", "Jackson", "99120250", Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);

            Assert.IsNotNull(pro);
        }




    }
}
