using System.Collections.Generic;
using System;

namespace Gradebook
{


    public delegate void GradeAddedDelagate(object sender, EventArgs args);


    public class InMemoryBook : Book {

        //* fields and abstration
        public override event GradeAddedDelagate  GradeAdded;

        private List<double> grades;

        public const string CATEGORY = "science";

        // * Constructor
        public InMemoryBook(string name) : base(name) {
            this.Name = name;
            grades = new List<double>();
        }

        public override void AddGrade(double grade) {

            if (grade <= 100 && grade >= 0) {

                this.grades.Add(grade);

                if(GradeAdded != null) {

                    GradeAdded(this, new EventArgs());

                }

            }
            else {

                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddGrade(char letter) {

            switch(letter) {

                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public override Statistics GetStatistics() {

            var results = new Statistics();



            for(var index = 0; index < grades.Count; index++) {
                results.Add(grades[index]);

            }




            return results;
        }
    }
}