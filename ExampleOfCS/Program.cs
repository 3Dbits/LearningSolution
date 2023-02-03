using ExampleOfCS.EnumExamples;
using ExampleOfCS.GenericExamples;
using ExampleOfCS.InheritanceExamples;
using ExampleOfCS.OopExamples;

Menu();

static void Menu()
{
    do
    {
        StartMenu();
    } while (ReadMenuInput());
    
}

static void StartMenu()
{
    Console.WriteLine("\nEnter number from a list:");
    foreach (var e in Enum.GetValues(typeof(MenuList)))
    {
        Console.WriteLine($"{e:D}. {e}");
    }
}

static bool ReadMenuInput()
{
    var input = Console.ReadLine();

    if(Int32.TryParse(input, out int choice))
    {
        switch (choice)
        {
            case (int)MenuList.OOP:
                OopExample();
                break;
            case (int)MenuList.Inheritance:
                InheritanceExample();
                break;
            case (int)MenuList.Generic:
                GenericExample();
                break;
            case (int)MenuList.Enum:
                Console.WriteLine("This menu is using Enums ^^"); ;
                break;
            case (int)MenuList.Exit:
                return false;
        };

        return true;
    }
        
    return true;
}

static void OopExample()
{
    // OOP Example
    Console.WriteLine("Press enter to start the clock!");
    Console.ReadLine();

    Clock clock = new Clock();
    int count = 0;

    while (count < 3602)
    {
        Console.WriteLine(clock);
        clock.Advance();
        count++;
    }
}

static void InheritanceExample()
{
    // Inheritance Example
    List<Point> points = new List<Point>();
    points.Add(new Point(4, 8));
    points.Add(new ColorPoint(1, 1, "green"));
    points.Add(new ColorPoint(2, 5, "blue"));
    points.Add(new Point3D(5, 2, 8));
    points.Add(new Point(0, 0));

    foreach (var p in points)
    {
        Console.WriteLine(p);
    }
}

static void GenericExample()
{
    // Generic Exaple with int
    GenericList<int> list = new GenericList<int>();

    for (int x = 0; x < 10; x++)
    {
        list.AddHead(x);
    }

    foreach (int i in list)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();

    // Generic Exaple with string
    GenericList<string> list2 = new GenericList<string>();

    list2.AddHead("A");
    list2.AddHead("B");
    list2.AddHead("C");
    list2.AddHead("D");
    list2.AddHead("E");

    foreach (var i in list2)
    {
        Console.Write(i + " ");
    }
}
