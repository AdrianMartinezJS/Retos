using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;
using StringAssert = NUnit.Framework.StringAssert;

namespace Retos_Moure.UnitTests
{
    [TestFixture]
    public class RockPaperScissorsGameTests
    {
        /*
         * Crea un programa que calcule quien gana más partidas al piedra,
         * papel, tijera, lagarto, spock.
         * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
         * - La función recibe un listado que contiene pares, representando cada jugada.
         * - El par puede contener combinaciones de "🗿" (piedra), "📄" (papel),
         *   "✂️" (tijera), "🦎" (lagarto) o "🖖" (spock).
         * - Ejemplo. Entrada: [("🗿","✂️"), ("✂️","🗿"), ("📄","✂️")]. Resultado: "Player 2".
         * - Debes buscar información sobre cómo se juega con estas 5 posibilidades.
         */
        /* Reglas
         * Tijera corta papel y lagarto
         * Papel tapa piedra y a spock
         * Piedra aplasta tijera y lagarto
         * Lagarto come papel y a spock
         * Spock rompe tijera y piedra
         * */

        private RockPaperScissorsGame _game;
        private List<KeyValuePair<string, string>> _resultsOfGame;

        [SetUp]
        public void SetUp()
        {
            _game = new RockPaperScissorsGame();
            _resultsOfGame = new List<KeyValuePair<string, string>>();
        }

        [Test]
        public void playGame_player1Winns_returnPlayer1Winns()
        {

            _resultsOfGame.Add(new KeyValuePair<string, string>("tijera", "papel"));
            var result = _game.playGame(_resultsOfGame);
            StringAssert.AreEqualIgnoringCase(result, "Player 1");
        }

        [Test]
        public void playGame_player2Winns_returnPlayer2Winns()
        {

            _resultsOfGame.Add(new KeyValuePair<string, string>("spock", "lagarto"));
            var result = _game.playGame(_resultsOfGame);
            StringAssert.AreEqualIgnoringCase(result, "Player 2");
        }

        [Test]
        public void playGame_Tie_returnTie()
        {

            _resultsOfGame.Add(new KeyValuePair<string, string>("spock", "lagarto"));
            _resultsOfGame.Add(new KeyValuePair<string, string>("tijera", "papel"));
            var result = _game.playGame(_resultsOfGame);
            StringAssert.AreEqualIgnoringCase(result, "Tie");
        }

    }

}
