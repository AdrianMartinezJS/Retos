using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retos_Moure
{
    /* Reglas
    * Tijera corta papel y lagarto
    * Papel tapa piedra y a spock
    * Piedra aplasta tijera y lagarto
    * Lagarto come papel y a spock
    * Spock rompe tijera y piedra
    * */
    public class RockPaperScissorsGame
    {
        private string _result = String.Empty;
        
        
        private string[] _ScissorsWinnsAgainst = new string[2] { "papel", "lagarto" };
        private string[] _papelWinnsAgainst = new string[2] { "piedra", "spock" };
        private string[] _RockWinnsAgainst = new string[2] { "tijera", "lagarto" };
        private string[] _SpockWinnsAgainst = new string[2] { "tijera", "piedra" };
        private string[] _lizardWinnsAgainst = new string[2] { "papel", "spock" };
        private Dictionary<string, string[]> _rules= new Dictionary<string, string[]>();
        
        public RockPaperScissorsGame()
        {
            _rules.Add("piedra", _RockWinnsAgainst);
            _rules.Add("papel", _papelWinnsAgainst);
            _rules.Add("tijera", _ScissorsWinnsAgainst);
            _rules.Add("lagarto", _lizardWinnsAgainst);
            _rules.Add("spock", _SpockWinnsAgainst);
        }
        public string playGame(List<KeyValuePair<string, string>> game)
        {
            var _player1 = new Player();
            var _player2 = new Player();

            foreach (var round in game)
            {
                if (round.Key == round.Value)
                    Console.WriteLine("Tie");
                else
                {
                    if (round.Value == _rules[round.Key][0] || round.Value == _rules[round.Key][1])
                        _player1.incrementPoints();
                    if (round.Key == _rules[round.Value][0] || round.Key == _rules[round.Value][1])
                        _player2.incrementPoints();
                }
            }
            if (_player1.Points > _player2.Points)
                _result = "Player 1";
            else if (_player1.Points < _player2.Points)
                _result = "Player 2";
            else
                _result = "Tie";
            return String.Format("{0}", _result);
        }
    }
}
