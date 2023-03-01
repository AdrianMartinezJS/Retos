using NUnit.Framework;
using System.Numerics;
using Assert = NUnit.Framework.Assert;
using IgnoreAttribute = NUnit.Framework.IgnoreAttribute;

namespace Retos_Moure.UnitTests
{
    [TestFixture]
    public class TennisMatchTests
    {
        /*
         * Escribe un programa que muestre cómo transcurre un juego de tenis y quién lo ha ganado.
         * El programa recibirá una secuencia formada por "P1" (Player 1) o "P2" (Player 2), según quien
         * gane cada punto del juego.
         * 
         * - Las puntuaciones de un juego son "Love" (cero), 15, 30, 40, "Deuce" (empate), ventaja.
         * - Ante la secuencia [P1, P1, P2, P2, P1, P2, P1, P1], el programa mostraría lo siguiente:
         *   15 - Love
         *   30 - Love
         *   30 - 15
         *   30 - 30
         *   40 - 30
         *   Deuce
         *   Ventaja P1
         *   Ha ganado el P1
         * - Si quieres, puedes controlar errores en la entrada de datos.   
         * - Consulta las reglas del juego si tienes dudas sobre el sistema de puntos.   
         */

        private TennisMatch? _tennisMatch;
        string[] P1winnsOneGame = new string[1] { "P1" };
        string[] P2winnsTwoGames = new string[2] { "P2", "P2" };
        string[] P1WinnsFiveToThree = new string[8] { "P1", "P1", "P2", "P2", "P1", "P2", "P1", "P1" };
        string[] P2WinnsAfterFiveToThree = new string[10] { "P2", "P1", "P2", "P2", "P1", "P1", "P2", "P2", "P2", "P2" };

        [SetUp] 
        public void SetUp() 
        {
            _tennisMatch = new TennisMatch();
        }

        [Test]
        public void printResult_player1winPoint_incrementPlayer1Counter()
        {
            var result = _tennisMatch.printResult(P1winnsOneGame);

            Assert.That(result, Is.EqualTo("The winner is P1 with a final result from: 1 - 0"));
        }

        [Test]
        public void printResult_player2win2Points_incrementPlayer2CounterTwoTimes()
        {
            var result = _tennisMatch.printResult(P2winnsTwoGames);

            Assert.That(result, Is.EqualTo("The winner is P2 with a final result from: 0 - 2"));
        }

        [Test]
        public void printResult_player1wins_resultFiveToThree()
        {
            var result = _tennisMatch.printResult(P1WinnsFiveToThree);

            Assert.That(result, Is.EqualTo("The winner is P1 with a final result from: 5 - 3"));
        }

        [Test]
        public void printResult_player2wins_breakAfterPlayer2WinnsFiveGamesToThree()
        {
            var result = _tennisMatch.printResult(P2WinnsAfterFiveToThree);

            Assert.That(result, Is.EqualTo("The winner is P2 with a final result from: 3 - 5"));
        }
    }
}
