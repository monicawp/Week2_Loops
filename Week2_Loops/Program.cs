using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split(); 

            //for(int i=0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //string days = "Monday Tuesday Wednesday";
            //string[] week = days.Split();
            //for(int i=0; i < week.Length; i++)
            //{
            //    Console.WriteLine(week[i]);
            //}

            //string story = "Once apon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);

            //  for(int i=0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}


            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach(string month in months)
            //{
            //    Console.WriteLine(month);
            //}



            //string[] artists = { "Travis Scott", "The Weeknd", "Rihanna", "SZA", "Ed Sheeran" };

            //foreach(string artist in artists)
            //{
            //    Console.WriteLine(artist);
            //}

            //string[] favFoods = { "Pasta", "Lobster", "French Toast", "Peanut Butter", "Avacado", "Tomatoes" };
            //foreach(string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //int[] luckyNum = { 7, 21, 10, 17 }; 
            //foreach(int num in luckyNum)
            //{
            //    Console.WriteLine("Your lucky number is " + num);
            //}

            // decdending from 10 
            //for (int i = 10; i >= 0; i --) 
            //{
            //    Console.WriteLine(i);
            //}

            // you could not do this with a foreach loop because foreach loops only go from begining to end

            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //        playAgain = Console.ReadLine();
            //}

            //Console.WriteLine("Would you like to check in?(YES/NO)");
            //string checkIn = Console.ReadLine().ToUpper();

            //while (checkIn == "YES")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please enter your full name");
            //    checkIn = Console.ReadLine();
            //    Console.WriteLine("Please enter your 6 digit patient ID");
            //    checkIn = Console.ReadLine();
            //    Console.WriteLine("What time is your apt?");
            //    checkIn = Console.ReadLine();
            //    Console.WriteLine("You are now checked in!");
            //}

            string playAgain;
            do
            {
                Console.WriteLine("Great game!");
                Console.WriteLine("Do you want to play again? (YES/NO)");
                playAgain = Console.ReadLine().ToUpper();
            }
            while (playAgain == "YES");

            Console.WriteLine("Thanks for playing again!");






        }
    }
}
