namespace Gradebook
{
    public abstract class Book : NameObject, IBook  {
        protected Book(string name) : base(name) {

        }

        public abstract event GradeAddedDelagate GradeAdded;

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }
}