using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wish> wishes = new List<Wish>();
            Wish one = new Wish("An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'");
            Wish two = new Wish("The ability to think of interesting wishes on short notice");
            Wish three = new Wish("A washtub full of skittles");
            Wish four = new Wish("World peace, but not the kind of world peace where all the humans are removed from existence");
            Wish five = new Wish("A TV that is not internet capable");
            Wish six = new Wish("The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?");
            wishes.Add(one);
            wishes.Add(two);
            wishes.Add(three);
            wishes.Add(four);
            wishes.Add(five);
            wishes.Add(six);

            Console.WriteLine("My wishes....");
            foreach (Wish wish in wishes)
            {
                Console.WriteLine(wish.Description);
            }


        }

    }
}
