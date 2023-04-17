 
// czy ta klasa jest potrzebana? byłaby potrzebna gdyby były rózne typy firm,a tak to chyba nie jest wykorzystywana

namespace CarrierRating
{
    public abstract class Company
    {
        public  Company(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }


    }
}
