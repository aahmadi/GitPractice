using System;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hey dude, wus yo name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}");

            Console.WriteLine($"{name} do you know how git works?");
            var answer = Console.ReadLine();
            if(answer == "yes"){
                Console.WriteLine("greate! this session is over");
                return;
            }
            Console.WriteLine("Dont worry. you will learn soon.");

            Console.WriteLine("Lesson 1: How to create git repository");
            Console.WriteLine(">git init");
            Console.WriteLine("This command initializes a git repository locally");
            Console.WriteLine("\b>git add <file name(s)>");
            Console.WriteLine("This command stages the changes.");

        }
    }
}
