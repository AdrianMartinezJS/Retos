using NUnit.Framework;
using StringAssert = NUnit.Framework.StringAssert;

namespace Retos_Moure.UnitTests
{
    [TestFixture]
    public class HogwartsHutTests
    {
        /*
         * Crea un programa que simule el comportamiento del sombrero selccionador del
         * universo mágico de Harry Potter.
         * - De ser posible realizará 5 preguntas (como mínimo) a través de la terminal.
         * - Cada pregunta tendrá 4 respuestas posibles (también a selecciona una a través de terminal).
         * - En función de las respuestas a las 5 preguntas deberás diseñar un algoritmo que
         *   coloque al alumno en una de las 4 casas de Hogwarts (Gryffindor, Slytherin , Hufflepuff y Ravenclaw)
         * - Ten en cuenta los rasgos de cada casa para hacer las preguntas y crear el algoritmo seleccionador.
         *   Por ejemplo, en Slytherin se premia la ambición y la astucia.
         */

        private HogwartsHut _hogwartsHut;

        [SetUp]
        public void SetUp()
        {
            _hogwartsHut = new HogwartsHut();
        }

        [Test]
        public void selectProperHouse_whenMostAnswersForGryffindor_selectsGryffinfor()
        {
            var result = _hogwartsHut.selectProperHouse(new List<string> { "1", "1", "2" });
            StringAssert.AreEqualIgnoringCase(result, "Gryffindor!");
        }

        [Test]
        public void selectProperHouse_whenMostAnswersForHuffelpuff_selectHuffelpuff()
        {
            var result = _hogwartsHut.selectProperHouse(new List<string> { "1", "3", "3" });
            StringAssert.AreEqualIgnoringCase(result, "Huffelpuff!");
        }

        [Test]
        public void selectProperHouse_whenMostAnswersForRaiwenclaw_selectRaivenclaw()
        {
            var result = _hogwartsHut.selectProperHouse(new List<string> { "1", "2", "2" });
            StringAssert.AreEqualIgnoringCase(result, "Raivenclaw!");
        }

        [Test]
        public void selectProperHouse_whenMostAnswersForSlythering_selectSlythering()
        {
            var result = _hogwartsHut.selectProperHouse(new List<string> { "1", "4", "4" });
            StringAssert.AreEqualIgnoringCase(result, "Slythering!");
        }
    }
}
