﻿using System;
using System.Collections.Generic;

namespace WeirdlyExcessiveExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create 1D string[], ask user to input text, Create a loop that goes through eachstring in the array
            //   adding the user's text to the string. Then create a loop that prints each string on a separate line

            //Console.WriteLine("Type any singular noun:");
            //string noun1 = Console.ReadLine();

            //Console.WriteLine("Type any plural noun:");
            //string noun2 = Console.ReadLine();

            //Console.WriteLine("Type any amount of time:");
            //string time1 = Console.ReadLine();

            //Console.WriteLine("Type any abstract concept:");
            //string concept1 = Console.ReadLine();

            //string[] wannabe = { "If you wanna be my " + noun1, "You gotta get with my " + noun2, "Make it last " + time1, "Cause " + concept1 + " never ends!", };

            //for (int j = 0; j < wannabe.Length; j++)
            //{
            //    Console.WriteLine(wannabe[j]);
            //}
            //Console.ReadLine();

            //2. Create an infinite loop

            //Console.WriteLine("Insult me:");
            //string insult = Console.ReadLine();

            //while (true)
            //{
            //    switch (insult)
            //    {
            //        default:
            //            Console.WriteLine("No u");
            //            Console.WriteLine("Insult me:");
            //            insult = Console.ReadLine();
            //            break;
            //    }

            //}

            //3. Fix the infinite loop so it will execute

            //Console.WriteLine("Insult me:");
            //string insult = Console.ReadLine();

            //while (insult != "Cats don't like you")
            //{
            //    switch (insult)
            //    {
            //        default:
            //            Console.WriteLine("No u");
            //            Console.WriteLine("Insult me:");
            //            insult = Console.ReadLine();
            //            break;
            //    }

            //}
            //Console.WriteLine("How Dare You");
            //Console.ReadLine();

            //4. Create a loop where the comparison used to determine whether to continue iterating is "<"

            //Console.WriteLine("Write a number greater than 7");
            //int number = Convert.ToInt16(Console.ReadLine());

            //while (number < 7)
            //{
            //    switch (number)
            //    {
            //        default:
            //            Console.WriteLine("I mean im not saying that " + number + " isn't a great number, it's just not greater than 7...");
            //            Console.WriteLine("Write a number greater than 7");
            //            number = Convert.ToInt16(Console.ReadLine());
            //            break;
            //    }
            //}
            //Console.WriteLine("Cool");
            //Console.ReadLine();

            //5. like the same thing as 4 but with <=

            //Console.WriteLine("Write a number greater than or equal to 7");
            //int number = Convert.ToInt16(Console.ReadLine());

            //while (number <= 6)
            //{
            //    switch (number)
            //    {
            //        default:
            //            Console.WriteLine("I mean im not saying that " + number + " isn't a great number, it's just not greater than or equal to 7...");
            //            Console.WriteLine("Write a number greater than or equal to 7");
            //            number = Convert.ToInt16(Console.ReadLine());
            //            break;
            //    }
            //}
            //Console.WriteLine("Cool");
            //Console.ReadLine();

            //6. create a list of strings where each string is unique. ask user to select text to search for in the list
            //   create a loop that iterates through the list then displays the indecies that contain the matching text

            //List<string> items = new List<string>() { "sunscreen", "drinking water", "a towel", "mask and snorkel", "snacks", "shoes", "an umbrella", "s'mores supplies", "ants", "candles" };

            //Console.WriteLine("I made a list of 10 things I could bring with me to the beach, with 1 being the most important\nitem and 10 being the least.");
            //Console.WriteLine("Some of the items on my list are: shoes, ants, a towel, s'mores supplies, sunscreen, and snacks");
            //Console.WriteLine("Out of those items, which do you think is most important on my list?");
            //string guess = Console.ReadLine();
            //int index = items.IndexOf(guess);

            //foreach (string item in items)
            //{
            //    if (guess != "sunscreen")
            //    {
            //        Console.WriteLine("Nope! Guess again! On my list, " + guess + " is number " + index);
            //        guess = Console.ReadLine();
            //        index = items.IndexOf(guess);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yes! the sun is the most important enemy!");
            //        break;
            //    }
            //}
            //Console.Read();

            //7. add code to the above loop that tells user if they put in text that wasnt on the list

            //List<string> items = new List<string>() { "sunscreen", "drinking water", "a towel", "mask and snorkel", "snacks", "shoes", "an umbrella", "s'mores supplies", "ants", "candles" };

            //Console.WriteLine("I made a list of 10 things I could bring with me to the beach, with 1 being the most important\nitem and 10 being the least.");
            //Console.WriteLine("Some of the items on my list are: shoes, ants, a towel, s'mores supplies, sunscreen, and snacks");
            //Console.WriteLine("Out of those items, which do you think is most important on my list?");
            //string guess = Console.ReadLine();
            //int index = items.IndexOf(guess);

            //foreach (string item in items)
            //{
            //    if (index >= 1)
            //    {
            //        Console.WriteLine("Nope! Guess again! On my list, " + guess + " is number " + index);
            //        guess = Console.ReadLine();
            //        index = items.IndexOf(guess);
            //    }
            //    else
            //    {
            //        if (index == 0)
            //        {
            //            Console.WriteLine("Yes! the sun is the most important enemy!");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("What? That's not even on my list! Try again!");
            //            guess = Console.ReadLine();
            //            index = items.IndexOf(guess);
            //        }
            //    }
            //}
            //Console.Read();

            //8.  Add code to that above loop that stops it from executing once a match has been found

            // my code already does that though?

            //9. create a list of strings that has at least 2 identical strings. ask the user to select
            //   text to search for on the list. create a loop that iterates thru the list then desplays
            //   the indices of the array that contain matching text on the screen.

            //List<string> items = new List<string>() { "sunscreen", "sunscreen", "a towel", "mask and snorkel", "snacks", "shoes", "an umbrella", "s'mores supplies", "ants", "candles" };

            //Console.WriteLine("I made a list of 10 things I could bring with me to the beach, with 1 being the most important\nitem and 10 being the least.");
            //Console.WriteLine("Some of the items on my list are: shoes, ants, a towel, s'mores supplies, sunscreen, and snacks");
            //Console.WriteLine("Out of those items, which do you think is most important on my list?");
            //string guess = Console.ReadLine();
            //int index = items.IndexOf(guess);
            //int index2 = items.LastIndexOf(guess);

            //foreach (string item in items)
            //{
            //    if (guess != "sunscreen")
            //    {
            //        Console.WriteLine("Nope! Guess again! On my list, " + guess + " is number " + index);
            //        guess = Console.ReadLine();
            //        index = items.IndexOf(guess);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yes! the sun is the most important enemy!\nThat's why sunscreen is numbers " + index + " and " + index2 + " on my list!");
            //        break;
            //    }
            //}
            //Console.Read();

            //10. add code to the list that tells a user if they input text not from the list.

            //List<string> items = new List<string>() { "sunscreen", "sunscreen", "a towel", "mask and snorkel", "snacks", "shoes", "an umbrella", "s'mores supplies", "ants", "candles" };

            //Console.WriteLine("I made a list of 10 things I could bring with me to the beach, with 1 being the most important\nitem and 10 being the least.");
            //Console.WriteLine("Some of the items on my list are: shoes, ants, a towel, s'mores supplies, sunscreen, and snacks");
            //Console.WriteLine("Out of those items, which do you think is most important on my list?");
            //string guess = Console.ReadLine();

            //foreach (string item in items)
            //{
            //    if (items.Contains(guess) == false)
            //    {
            //        Console.WriteLine("What? That's not even on my list! Try again!");
            //        guess = Console.ReadLine();

            //    }
            //    else
            //    {
            //        if (guess == "sunscreen")
            //        {
            //            int index2 = items.LastIndexOf(guess);
            //            Console.WriteLine("Yes! the sun is the most important enemy!\nThat's why sunscreen is numbers " + items.IndexOf(guess) +" and " + index2 + " on my list!");
            //            break;
            //        }
            //        else
            //        {
            //            int index = items.IndexOf(guess);
            //            Console.WriteLine("Nope! Guess again! On my list, " + guess + " is number " + index);
            //            guess = Console.ReadLine();
            //        }
            //    }
            //}
            //Console.Read();

            //11. Create a list of strings that has at least 2 identical strings in the list. create a 
            //    foreach loop that evaluates each item on the list and displays a message showing the
            //    string and whether or not it has already appeared on the list.

            List<string> items = new List<string>() { "fire alarm", "head phones", "pen", "ants", "toothpaste", "ants", "small hammer", "sunscreen" };
            foreach (string item in items)
            { 
                Console.WriteLine(item);

                if (items.IndexOf(item) != items.LastIndexOf(item)) //comparing the index of each item to every other item to identify duplicate strings
                {
                    Console.WriteLine("^^^^^^^This is a duplicate!");
                }

            }
            Console.Read(); //moved out of foreach loop so it shows the whole list at once instead of 3 at a time for some reason
        }
    }
}
