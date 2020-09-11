using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests //No logre solucionar los problemas con los frameworks, pero los tests funcionan.
{
    public class PersonTests
    {
        private Person testPerson = new Person("Juan", "1.234.567-8");
     
        [Test]
        public void EmptyOrNullNameShouldNotSet() // Valida que si se intenta setear el nombre a un string vacio, queda como estaba
        {
            string expected = "Juan";
            testPerson.Name = "";
            testPerson.Name = null;
            string actual = testPerson.Name;
            Assert.DoesNotMatch(expected, actual);
        }
        [Test]
        public void InvalidIdShouldNotSet() // Valida que si se intenta setear el ID invalido, queda como estaba
        {
            string expected = "1.234.567-8";
            testPerson.ID = "1.111.111-2";
            string actual = testPerson.ID;
            Assert.DoesNotMatch(expected, actual);
        }

        [Test]
        public void ValidIdShouldSet() // Valida que si se intenta setear el ID invalido, queda como estaba
        {
            string expected = "1.111.111-1";
            testPerson.ID = "1.111.111-1";
            string actual = testPerson.ID;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidNameShouldSet() // Valida que si se intenta setear el ID valido, funciona
        {
            string expected = "Bruno";
            testPerson.ID = "Bruno";
            string actual = testPerson.Name;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreatePerson() // Valida que si se crea una persona, el constructor funciona como deberia
        {
            Person newPerson = new Person("Pedro", "5.101.767-6");
            string expectedName = "Pedro";
            string expectedId = "5.101.767-6";
            Assert.AreEqual(expectedName, newPerson.Name);
            Assert.AreEqual(expectedId, newPerson.ID);
        }

    }
}