using System;
using System.Collections.Generic;
using System.Linq;

namespace dinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = new List<Guest>();
            List<Guest> table1 = new List<Guest>();
            List<Guest> table2 = new List<Guest>();


            var marilyn = new Guest
            {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
            };

            var abraham = new Guest
            {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
            };

            var martin = new Guest
            {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
            };

            var rosa = new Guest
            {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
            };
            var peter = new Guest
            {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
            };
            var alan = new Guest
            {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world",
            };
            var grace = new Guest
            {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
            };
            var ghandi = new Guest
            {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
            };

            guests.Add(peter);
            guests.Add(ghandi);
            guests.Add(marilyn);
            guests.Add(abraham);
            guests.Add(alan);
            guests.Add(grace);
            guests.Add(martin);
            guests.Add(rosa);

            foreach (Guest guest in guests)
            {
                bool isAnyoneSittingHere = table1.Any(p => p.Occupation == guest.Occupation);
                if (!isAnyoneSittingHere)
                {
                    table1.Add(guest);
                }
                else
                {
                    if (isAnyoneSittingHere)
                    {

                        table2.Add(guest);
                    }
                }
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Table 1");
            Console.WriteLine("--------------");
            foreach (Guest guest in table1)
            {
                guest.Description();
            };
            Console.WriteLine("--------------");
            Console.WriteLine("Table 2");
            Console.WriteLine("--------------");
            foreach (Guest guest in table2)
            {
                guest.Description();
            };
        }
    }
}

