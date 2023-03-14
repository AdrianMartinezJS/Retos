using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retos_Moure
{
    public class HogwartsHut
    {
        private string[] _questions = new string[5] { "Wich of the next options, would you rather hate more to be called", "Wich potion would you rather make?", "How would you prefer to be known in history?","The teacher ask a question to the class. How do you react, if you know the answer?","Two wizards are coming to fight you. What do you do?" };
        private string[] _answers = new string[5] { "Coward,Ignorant,Selfish,Ordinary", "Glory,Wisdom,Love,Power", "The Great,The Bold,The Kind,The Powerfull", "I raise my hand up,I wait to see if somebody else knows it and after raise my hand up,I'm too shy to answer,I say it out laud", "I fight with both without doubt,I call for help,I ran away,I tell them if they don't know who I am!" };
        private Player _Gryffindor;
        private Player _Raivenclaw;
        private Player _Huffelpuff;
        private Player _Slythering;
        public HogwartsHut() 
        {
            _Gryffindor = new Player(); // Answer 1
            _Raivenclaw = new Player(); // Answer 2
            _Huffelpuff = new Player(); // Answer 3
            _Slythering = new Player(); // Answer 4
        }

        public string[] getQuestionAnswer(int index)
        {
            var separatedAnswers = _answers[index].Split(",");
            var questionAndPosibleAnswer = new string[5] { _questions[index], separatedAnswers[0], separatedAnswers[1], separatedAnswers[2], separatedAnswers[3] };
            return questionAndPosibleAnswer;
        }

        public string selectProperHouse(List<string> answers)
        {
            foreach (var answer in answers)
            {
                switch(answer)
                {
                    case "1":
                        _Gryffindor.incrementPoints();
                        break;
                    case "2":
                        _Raivenclaw.incrementPoints();
                        break;
                    case "3":
                        _Huffelpuff.incrementPoints();
                        break;
                    case "4":
                        _Slythering.incrementPoints();
                        break;
                    default:
                        Console.WriteLine("No such case!");
                        break;
                }
            }
            if (_Gryffindor.Points > _Raivenclaw.Points && _Gryffindor.Points > _Huffelpuff.Points && _Gryffindor.Points > _Slythering.Points)
            {
                return "Gryffindor!";
            }
            if (_Raivenclaw.Points > _Gryffindor.Points && _Raivenclaw.Points > _Huffelpuff.Points && _Raivenclaw.Points > _Slythering.Points)
            {
                return "Raivenclaw!";
            }
            if (_Huffelpuff.Points > _Gryffindor.Points && _Huffelpuff.Points > _Raivenclaw.Points && _Huffelpuff.Points > _Slythering.Points)
            {
                return "Huffelpuff!";
            }
            return "Slythering!";
        }
    }
}
