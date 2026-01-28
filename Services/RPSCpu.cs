using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//create api for Rock Paper Scissors lizard spock CPU logic
namespace RPSAPI.Services
{
    public class RPSCpu
    {
        private readonly Random _random = new Random();
        private  readonly string[] _choices = { "rock", "paper", "scissors" };

        public string GetCpuChoice()
        {
            int index = _random.Next(_choices.Length);
            return _choices[index];
        }
    }
    }

