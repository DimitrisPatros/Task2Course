using System;
using Task2Course.Models;

namespace Task2Course
{
    class Program
    {

        static void Main()
        {
            bool doContinue;
            //Create new course                
            Course course = new Course("quantom physics", "ghrt156", "lahanas");
            //Create new student
            Student student = new Student("Dimitris", 20, 1);
            do
            {
                char action;

                Console.WriteLine("press 'e' for enroll to class, 'w' for withdraw from class, 'a' to assign grade");
                action = char.Parse(Console.ReadLine());
                if (action == 'e')
                {
                    bool success = student.Enroll(course);
                    if (success) Console.WriteLine("Enroll successfull :)");
                }
                else if (action == 'w')
                {
                    bool success = student.Withdraw();
                    if (success) { Console.WriteLine("Withdraw successfull :)"); }
                    else
                    {
                        Console.WriteLine("Student is not enrolled in a class");
                    }

                }
                else if (action == 'a')
                {
                    if (!student.IsEnrolled())
                    {
                        Console.WriteLine("Please enroll in a course first");

                    }
                    else
                    {
                        bool canContinue = false;
                        do
                        {
                            Console.WriteLine("Enter the Mark of the studen from 0 to 100 : ");
                            string userInput = Console.ReadLine();
                            if (int.TryParse(userInput, out int mark))
                            {
                                student.AssignGrade(mark);
                                canContinue = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a numeric value");
                            }
                        } while (!canContinue);
                    }

                }
                else
                {
                    Console.WriteLine("Wrong answer");
                }


                Console.WriteLine(student.ToString());

                Console.WriteLine("Do you want to do another job (y/n)");
                char response = char.Parse(Console.ReadLine());
                if (response == 'y')
                {
                    doContinue = true;
                }
                else
                {
                    doContinue = false;
                    Console.WriteLine("Goodbye");
                }

            } while (doContinue);
        }


    }//end of class Program   

}
