using Homework_5;

class Program
{
    static void Main(string[] args)
    {
        List<IDeveloper> developers = new List<IDeveloper>
        {
            new Programmer { Language = "C#", Tool = "Visual Studio" },
            new Builder { Equipment = "Hammer", Tool = "Construction site tool" }
        };

        foreach (var developer in developers)
        {
            developer.Create();
            developer.Destroy();
        }

        Dictionary<uint, string> idNameDictionary = new Dictionary<uint, string>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter ID: ");
            uint id = uint.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            idNameDictionary[id] = name;
        }

        Console.Write("Enter ID to find corresponding name: ");
        uint userInputId = uint.Parse(Console.ReadLine());

        if (idNameDictionary.ContainsKey(userInputId))
            Console.WriteLine($"Name for ID {userInputId}: {idNameDictionary[userInputId]}");
        else
            Console.WriteLine("No name found for the given ID.");

        developers.Sort((dev1, dev2) => String.Compare(dev1.Tool, dev2.Tool, StringComparison.Ordinal));
    }
}