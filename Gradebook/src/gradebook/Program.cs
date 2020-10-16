using System;

namespace Gradebook {

    class Program {

        static void OnGradeAdded(object sender, EventArgs e) {

            Console.WriteLine("A grade was added");

        }

        static void Main(string[] args)
        {


            IBook book = new DiskBook("Scott's Grade Book");

            book.GradeAdded += OnGradeAdded;

            var done = false;

            EnterGrade(book, done);

            var stats = book.GetStatistics();


            Console.WriteLine($"For the bokk named: {book.Name}");
            Console.WriteLine($"The highgrade is: {stats.High}\nThe lowest Grade is: {stats.Low}");
            Console.WriteLine($"The average in the grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }

        private static bool EnterGrade(IBook book, bool done) {
            while (!done) {

                Console.WriteLine("Enter a grade or enter char q to quit: ");
                var input = Console.ReadLine();
                if (input == "q") {
                    done = true;
                    continue;
                }

                try {

                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException err) {

                    Console.WriteLine(err.Message);

                }
                catch (FormatException err) {

                    Console.WriteLine(err.Message);
                }
                finally {
                    Console.WriteLine("**");
                }
            }

            return done;
        }
    }
}