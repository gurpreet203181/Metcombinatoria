using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
	[DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(50)]
        public void TestMethod1(long numero)
        {
            long fattoriale;

            fattoriale = EquazioniLibrary.CalcoliCombinatori.Fattoriale(numero);

            Console.WriteLine("{0}!={1} ", numero,  fattoriale);
        }
    }
}
