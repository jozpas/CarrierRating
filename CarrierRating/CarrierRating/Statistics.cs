
namespace CarrierRating
{
    public class Statistics
    {

        public float Sum { get; private set; }
        public int Count { get; private set; }

        public float Avarage
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public string Description
        {
            get
            {
                switch (this.Avarage)
                {
                    case var avarage when avarage >= 5:
                        return "Przewoźnik osiągnał poziom docelowy";
                    case var avarage when avarage >= 4:
                        return "Przewoźnik osiągnał poziom akceptowalny, wymagający delikatnej poprawy";
                    case var avarage when avarage >= 3:
                        return "Przewoźnik osiągnał poziom akceptowalny, wymagający znacznej poprawy";
                    default:
                        return "Przewoźnik nie osiągnał poziomu akceptowalnego!";
                }
            }
        }

        public void AddGrade (float grade)
        {
            this.Count++;
            this.Sum += grade ;
        }
        
    }
}
