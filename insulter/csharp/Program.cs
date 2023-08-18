using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> insults = new List<string>() {
            "Your mother doesn't even like you.",
            "Have to tie a bone around your neck so the dog will play with you.",
            "This doesn't even compare to when you are not here.",
            "I would really like to know how this ends.",
             "You look like what morning breath smells like.",
            "If you tried to give me cpr I would probably throw myself back under water",
            "I am not a fan of you",
            "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
            "I'd rather walk than be on the same plane as you"
           };

            int GetRandom()
            {
                int RandomValue = new Random().Next(0, 8);
                return RandomValue;
            }

            List<int> index = new List<int>();
            while (index.Count < 3)
            {
                int next = GetRandom();
                bool isNext = index.Any(p => p == next);
                if (!isNext)
                {
                    index.Add(next);
                }
            }
            foreach (int indice in index)
            {

                Console.WriteLine(insults[indice]);
            }






        }
    }
}
