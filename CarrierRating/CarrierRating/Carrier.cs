
namespace CarrierRating
{
    internal class Carrier : CompanyBase, ICompany
    {

        public List<float> grades = new List<float>();

        public List<string> carriers = new List<string>();
        public const string carriersList = "carriers.txt";

        public Carrier(string name) : base(name)
        {
        }

        //poniższa metoda działa w pamięci, nie na pliku, który jeszcze nie powstał!!
        public override void AddCarrier(string name)
        {
            using (var writerCarrier = File.AppendText(carriersList))
            {
                writerCarrier.WriteLine(name);
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade <= 6 && grade >= 0)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Nie prawidłowa wartość. Wybierz wartość od 0 do 6");
            }
        }
        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }


        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(6);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(5);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(4);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(3);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(2);
                    break;
                case 'F':
                case 'f':
                    this.AddGrade(1);
                    break;
                default: throw new Exception("Błędna ocena. wybierz literę od A do E, gdzie A jest najwyższą oceną");

            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resoult))
            {
                this.AddGrade(resoult);
            }
            else if (char.TryParse(grade, out char charToString))
            {
                this.AddGrade(charToString);
            }
            else
            {
                throw new Exception("Błędna wartość. Wprowadż ocenę dla przewoźnika od 0 do 6");
            }
        }


        //poniższa metoda działa w pamięci, nie na pliku, który jeszcze nie powstał!!
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }

        //public List<string> ReadCarriersFromFile()
        //{
        //    var carriers = new List<string>();
        //    if (File.Exists($"{carriersList}"))
        //    {
        //        using (var reader = File.OpenText($"{carriersList}"))
        //        {
        //            var line = reader.ReadLine();
        //            while (line != null)
        //            {
        //                carriers.Add(line);
        //                line = reader.ReadLine();
        //            }
        //        }
        //    }
        //    return carriers;
        //}


    }
}
