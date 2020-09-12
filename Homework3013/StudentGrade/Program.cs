using System;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string studentId = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double hw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participation = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for final?");
            double final = Convert.ToDouble(Console.ReadLine());

            double finalGrade = ((hw + participation + quizzes + midterm + final)/5)/100;
           // finalGrade.ToString("P2");

            Console.WriteLine(firstName + " " + lastName + " (" + studentId + "), your final grade is " + finalGrade.ToString("P2") + ".");

        }
    }
}
