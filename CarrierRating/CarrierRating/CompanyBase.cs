
namespace CarrierRating
{
    internal abstract class CompanyBase : ICompany
    {

        public CompanyBase(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public abstract void AddCarrier(string name);

        public abstract void AddGrade(int grade);


        public abstract void AddGrade(float grade);


        public abstract void AddGrade(char grade);


        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistics();

        
    }
}
