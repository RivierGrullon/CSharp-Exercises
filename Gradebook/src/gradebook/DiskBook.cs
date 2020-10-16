using System.IO;

namespace Gradebook
{
    public class DiskBook : Book {

        public DiskBook(string name) : base(name) {

        }

        public override event GradeAddedDelagate GradeAdded;

        public override void AddGrade(double grade) {

            using( var writer = File.AppendText($"{this.Name}.txt")) {
                writer.WriteLine(grade);
                if(GradeAdded != null) {
                    GradeAdded(this, new System.EventArgs());
                }
            }
        }

        public override Statistics GetStatistics() {
            var result = new Statistics();

            using(var reader = File.OpenText($"{Name}.txt")) {
                var line = reader.ReadLine();
                while(line != null) {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}