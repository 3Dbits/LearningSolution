using ExampleOfCS.InheritanceExamples;
using ExampleOfCS.OopExamples;

Console.WriteLine("Hello, World!");

OopExample();

static void OopExample()
{
    // OOP Example
    Clock clock = new Clock();
    int count = 0;

    while (count < 3602)
    {
        Console.WriteLine(clock);
        clock.Advance();
        count++;
    }
}

InheritanceExample();

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

