using System;

namespace dinnerParty
{
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }

        public void Description()
        {
            Console.WriteLine($"{Name} ({Occupation}) {Bio}");
        }

    }
}