using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---------Question 1-----------");
            Console.WriteLine("-----------------------------");


            Console.WriteLine(" Please enter a letter and I will tell you whether its a vowel or not");
            string letter = Console.ReadLine();



            switch (letter)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":



                    
                    Console.WriteLine("That is a vowel");
                    break;
                default:
                    Console.WriteLine("{0} is a consonant");
                    break; }

            Console.WriteLine("Please press enter to exit");
        

        
         Console.WriteLine("------------Question 2-----------");
         Console.WriteLine("This app will calculate your BMI (Body mass index)");
            Console.WriteLine("Please enter your weight in Kg's:");
            int weight = int.Parse(Console.ReadLine());





                       
                    
         
        

   

        

        

           
        }
    }
}
