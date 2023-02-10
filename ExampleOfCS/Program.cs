using ExampleOfCS.AbstractExamples;
using ExampleOfCS.EnumExamples;
using ExampleOfCS.ExtensionMetExamples;
using ExampleOfCS.GenericExamples;
using ExampleOfCS.InheritanceExamples;
using ExampleOfCS.LinqExamples;
using ExampleOfCS.OopExamples;
using System.Diagnostics.Metrics;
using System;
using ExampleOfCS.FileExamples;
using ExampleOfCS.InterfaceExamples;
using ExampleOfCS.AsyncExamples;

Menu();

#region Menu stuff
static async void Menu()
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
            case (int)MenuList.Files:
                FileExamples();
                break;
            case (int)MenuList.Interface:
                InterfaceExamples();
                break;
            case (int)MenuList.AsyncMethods:
                AsyncExample();
                Console.WriteLine("Now Sync Example");
                SyncExample();
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

    Console.WriteLine("Same list with indexers:");
    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Index: [{i}] Value: [{list[i]}]");
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

static void FileExamples()
{
    FileCreate fileCreate = new FileCreate();

    Console.WriteLine("1.Create a Folder/File\n2.Write into a file\n3.Read from a file\n4.Exit");

    var input = Console.ReadLine();

    if (int.TryParse(input, out int choice))
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter a folder name: ");
                fileCreate.Folder = Console.ReadLine();
                fileCreate.CreateDir();

                Console.WriteLine("Enter a file name");
                fileCreate.FileName = Console.ReadLine();

                Console.WriteLine("Enter a extension without dot (.): ");
                fileCreate.FileExt = Console.ReadLine();

                fileCreate.CreateFile();
                break;

            case 2:
                fileCreate.WriteToAFile();
                break;

            case 3:
                fileCreate.ReadFromAFile();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Enter a valid input!");
                break;
        }
    }

    var readFiles = new ListCFiles();
    readFiles.Example();
}



static void InterfaceExamples() 
{
    Square square = new(7);
    Rectangle rectangle = new(5, 3);
    Triangle triangle = new Triangle(3,3,3);

    Console.WriteLine($"{square.GetColor()} with area: {square.CalculateArea()} cm and perimiter {square.CalculatePerimiter()} cm.");
    Console.WriteLine($"{rectangle.GetColor()} with area: {rectangle.CalculateArea()} cm and perimiter {rectangle.CalculatePerimiter()} cm.");
    Console.WriteLine($"{triangle.GetColor()} with area: {triangle.CalculateArea():F1} cm and perimiter {triangle.CalculatePerimiter():F1} cm.");
}

static void AsyncExample()
{
    AsyncAwait aws = new();
    aws.RunAsyncTasks();

    Console.WriteLine("The program has Started,input your name while your waiting for your tasks");
    string input = Console.ReadLine();

    Console.WriteLine($"Hello {input}, please wait while the tasks are finishing");
    Console.ReadLine();
}

static void SyncExample()
{
    SyncExample aws = new();

    aws.RunTasks();
    Console.WriteLine("You couldn't input your name while the tasks were running, input your name now");
    string input = Console.ReadLine();

    Console.WriteLine($"Hello {input}, your tasks have finished, but it took longer");
    Console.ReadLine();
}

#endregion