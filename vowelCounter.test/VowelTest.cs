/*
Red->
Green->
Refactor ->


(-)
1.DONE Manejo de valores null
2.DONE Manejo de valor Invalido
3.DONE "12345" -> {}

(+)
P4.DONE "hola@mundo" -> {'a': 1, 'o': 3, 'u' : 1} 
P5.DONE Murcielago x MURCIELAGO = mUrciElagO cuadrado -> {'a' : 5, 'e' : 3, 'i' : 3, 'o' : 4, 'u' : 4}

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
                ['a'] = 1,
                ['o'] = 3,
                ['u'] = 1
            };
            Assert.That(() => vowelCounter.Counter("hola@mundo.com"), Is.EquivalentTo(rest));
        }

        [Test]
        public void Case_Insensitive()
        {
            Dictionary<char, int> rest = new Dictionary<char, int>
            {
                ['a'] = 5,
                ['e'] = 3,
                ['i'] = 3,
                ['o'] = 4,
                ['u'] = 4
            };
            Assert.That(() => vowelCounter.Counter("Murcielago x MURCIELAGO = mUrciElagO cuadrado"), 
            Is.EquivalentTo(rest));
        }
    }

}