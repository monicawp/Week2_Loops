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

            string[] favFoods = { "Pasta", "Lobster", "French Toast", "Peanut Butter", "Avacado", "Tomatoes" };
            foreach(string food in favFoods)
            {
                Console.WriteLine(food);
            }

            //int[] luckyNum = { 7, 21, 10, 17 }; 
            //foreach(int num in luckyNum)
            //{
            //    Console.WriteLine("Your lucky number is " + num);
            //}





        }
    }
}
