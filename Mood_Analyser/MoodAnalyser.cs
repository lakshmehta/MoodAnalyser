using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {

        public string analyseMood(string message)
        {
            if (message.Equals("I am in sad Mood"))
                return "SAD";
            else
                return "HAPPY";
        }


    }
}
