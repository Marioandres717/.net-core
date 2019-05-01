using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jay Lord");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.7);
            book.AddGrade(43.6);
            book.showStatistics();
        }
    }
}
