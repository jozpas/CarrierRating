using CarrierRating;

Console.WriteLine();
Console.WriteLine("=============================================================================");
Console.WriteLine();
Console.WriteLine("SYSTEM OCENY PRZEWOŹNIKÓW");
Console.WriteLine();
Console.WriteLine("=============================================================================");
Console.WriteLine();
Console.WriteLine();

bool CloseApp = false;
do
{
    Console.WriteLine("Wybierz co chcesz zrobić\n" +
        "1 - Jeśli chcesz wyświetlić Twoich przewoźników\n" +
        "2 - jeśli chcesz wprowadzić nowego przewoźnika\n" +
        "3 - jeśli chcesz dodać ocenę przewoźnikowi\n" +
        "Q - jeśli chcesz zamknąć program");
    var activity = Console.ReadLine();
    if (activity == "1")
    {
        Console.WriteLine("Będzie się wywietlała lista przewoźników");

        List<string> ReadCarriersFromFile()
        {
            var carriers = new List<string>();
            if (File.Exists($"{Carrier.carriersList}"))
            {
                using (var reader = File.OpenText($"{Carrier.carriersList}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        carriers.Add(line);
                        line = reader.ReadLine();
                    }
                }
            }
            return carriers;
        }

        var i = 1;
        foreach (var car in ReadCarriersFromFile())
        {
            Console.WriteLine($"[{i}] - {car}");
            i++;
        }
        Console.WriteLine("teraz powienen móc wrócić do menu lub wybrać numer przewoźnika i dodać mu ocenę");

    }
    else if (activity == "2")
    {
        Console.WriteLine("Wprowadź nazwę przewoźnika");
        var name = Console.ReadLine();
        var carrier = new Carrier(name);
        carrier.AddCarrier(name);
    }
    else if (activity == "3")
    {
        Console.WriteLine("Tu musi się wyświetliść lista wprowadzonych przewoźników i możliwość wybrania, któremu chcę dodać ocenę");
        Console.WriteLine("- - - ");



        //poniższ linia jest tymczasowa do momentu wgrania listy przewoźników
        var carrier2 = new Carrier("4WARD");


        var i = 0;
        while (true)
        {

            Console.WriteLine($"Dodaj ocenę dla przewoźnika {carrier2.Name}");
            var input = Console.ReadLine();

            try
            {
                carrier2.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catch: {e.Message}");
            }

            Console.WriteLine("Podaj kolejną ocene przewoźnika lub wpisz 'Q', żeby wrócić do MENU");
            var input1 = Console.ReadLine();
            if (input1 == "Q" || input1 == "q")
            {
                break;
            }
            try
            {
                carrier2.AddGrade(input1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catch: {e.Message}");
            }
        }
        var statistics = carrier2.GetStatistics();
        Console.WriteLine($"Przewoźnik {carrier2.Name}\n        wykonał {statistics.Count} zlecenia\n       ma średnią ocen {statistics.Avarage},\n        co oznacza, że {statistics.Description}");

    }
    else if (activity == "Q" || activity == "q")
    {
        CloseApp = true;
    }
} while (CloseApp == false);








//Console.WriteLine($"Przewoźnik {carrier.Name} ma {carrier.CountOfCars} aut.");
//Console.WriteLine($"Przewoźnik {carrier.Name} zdobył poniższe oceny {carrier.grades}");
