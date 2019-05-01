using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("foo");
            book.GradeAdded += onGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            // System.Console.WriteLine(InMemoryBook.CATEGORY);
            System.Console.WriteLine($"The name of the book {book.Name}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("Enter a grade or enter -1 to quite: ");
                var input = System.Console.ReadLine();
                var grade = double.Parse(input);
                if (grade == -1)
                {
                    break;
                }

                try
                {
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    // .. WHEN WE WANT TO ALWAYS EXECUTE SOME CODE
                    System.Console.WriteLine("**");
                }
            };
        }

        static void onGradeAdded(object sender, EventArgs e)
        {
            System.Console.WriteLine("A GRADE HAS BEEN ADDED!");
        }
    }
}
