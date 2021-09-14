/*
Red->
Green->
Refactor ->


(-)
1.DONE Manejo de valores null
2.DONE Manejo de valor Invalido
3.DONE "12345" -> {}

(+)
P4 "hola@mundo" -> {'a': 1, 'o': 3, 'u' : 1} 

*/

using System.Collections.Generic;
using NUnit.Framework;
using vowelCounter;

namespace vowelCounter.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_Validator()
        {
            Assert.That(() => vowelCounter.Counter(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Empty_String()
        {
            Assert.That(() => vowelCounter.Counter(""), Is.Empty);
        }

        [Test]
        public void nUMBER()
        {
            Assert.That(() => vowelCounter.Counter("123456"), Is.Empty);
        }

        [Test]
        public void Hola_mundo()
        {
            Dictionary<char, int> rest = new Dictionary<char, int>
            {
                ['i'] = 1,
                ['o'] = 3,
                ['u'] = 1
            };
            Assert.That(() => vowelCounter.Counter("hola@mundo.com"), Is.EquivalentTo(rest));
        }
    }

}