
namespace CarrierRating
{
    public interface ICompany
    {
        string Name { get; }
    //    int CountOfCars { get; }

        void AddGrade(int grade);
        void AddGrade(float grade);

        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();

    }
}
