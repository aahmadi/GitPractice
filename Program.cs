using System;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, My name is Git. what is your name?");
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
        }
    }
}
