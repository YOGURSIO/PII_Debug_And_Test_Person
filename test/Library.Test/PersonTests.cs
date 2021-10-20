using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Gonzalo", "2.686.797-9", 1994);
            int expected = 1994;
            Assert.AreEqual(expected, p.Age);

            
        }
    }
}