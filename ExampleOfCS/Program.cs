using ExampleOfCS.AbstractExamples;
using ExampleOfCS.EnumExamples;
using ExampleOfCS.ExtensionMetExamples;
using ExampleOfCS.GenericExamples;
using ExampleOfCS.InheritanceExamples;
using ExampleOfCS.LinqExamples;
using ExampleOfCS.OopExamples;
using System.Diagnostics.Metrics;
using System;

Menu();

#region Menu stuff
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

    for (int i = 1; i <= (int)MenuList.Exit; i++)
    {
        Console.WriteLine($"[{i}] {((MenuList)i).GetEnumDescription()}");
    }
}

static bool ReadMenuInput()
{
    var input = Console.ReadLine();

    if (Int32.TryParse(input, out int choice))
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
            case (int)MenuList.Abstract:
                AbstractExample();
                break;
            case (int)MenuList.Exit:
                Console.WriteLine("Exiting the application..");
                return false;
            case (int)MenuList.Linq:
                LinqExample();
                break;
        };
    }
    if(choice <= 0 || choice > (int)MenuList.Exit)
    {
        Console.WriteLine("Enter a valid input!");
    }
    return true;
}
#endregion

#region Logic

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
    GenericList<int> list = new();

    for (int x = 0; x < 10; x++)
    {
        list.AddHead(x);
    }

    Console.WriteLine("Use generic metode to print integers =>");
    foreach (int i in list)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();

    // Generic Exaple with string
    GenericList<string> list2 = new();

    list2.AddHead("AA");
    list2.AddHead("B");
    list2.AddHead("CC");
    list2.AddHead("D");
    list2.AddHead("EE");

    Console.WriteLine("Use generic metode to print strings =>");
    foreach (var i in list2)
    {
        Console.Write($"{ i } ");
    }

    Console.WriteLine();
}

static void AbstractExample()
{
    // High level explanation
    var o = new DerivedClass();
    o.AbstractMethod();
    Console.WriteLine($"x = { o.X }, y = { o.Y }");

    // Example
    UserInterface userInterface = new UserInterface();
    userInterface.AddOperation(new PlusOperation());

    userInterface.Start();
}

static void LinqExample()
{
    LinqQueries queries = new();
    Console.WriteLine("Basic LINQ query =>");
    queries.QueryExamples();

    ProgramForStudents objectAndLinq = new();
    Console.WriteLine("Query over object list =>");
    objectAndLinq.StartProgram();
}

#endregion