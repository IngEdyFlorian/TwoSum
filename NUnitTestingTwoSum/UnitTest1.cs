using NUnit.Framework;
using Lib_TwoSum;

namespace NUnitTestingTwoSum
{
    public class Tests
    {        
        ITwoSum sums;

        [SetUp]
        public void Setup()
        {
            sums = new TwoSum();
        }

        [Test]
        public void Test1()
        {
            //parametros
            int[] arr = { 1, 5, 7, -1, 5 };
            int sum = 6;

            //resultado esperado
            int[] resExptected = { 0, 1 };

            //ejecucion de la prueba (se espera que sean iguales) AreEqual
            Assert.AreEqual(expected: resExptected, sums.GetPair(arr, sum));
        }

        [Test]
        public void Test2()
        {
            //parametros
            int[] arr = { 1, 5, 7, -1, 5 };
            int sum = 6;

            //resultado esperado
            int[] resExptected = { 1, 1 };

            //ejecucion de la prueba (se espera que no sean iguales) AreNotEqual
            Assert.AreNotEqual(expected: resExptected, sums.GetPair(arr, sum));
        }
    }
}