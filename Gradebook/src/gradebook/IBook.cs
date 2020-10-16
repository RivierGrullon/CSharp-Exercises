namespace Gradebook
{
    public interface IBook
    {
         void AddGrade(double grade);
         Statistics GetStatistics();
         string Name { get; }
         event GradeAddedDelagate GradeAdded;

    }
}