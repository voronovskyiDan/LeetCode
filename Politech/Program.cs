//using System.Drawing;

//int minimumY(List<Point> points)
//{
//    int minY = 1;
//    int currentMaxY = points[0].Y;

//    for (int i = 0; i < points.Count; i++)
//    {
//        if (points[i].Y > currentMaxY)
//        {
//            currentMaxY = points[i].Y;
//            minY++;
//        }
//    }
//    return minY;
//}
//int minimumX(List<Point> points)
//{
//    int minX = 1;
//    int currentMaxX = points[0].X;

//    for (int i = 0; i < points.Count; i++)
//    {
//        if (points[i].X > currentMaxX)
//        {
//            currentMaxX = points[i].X;
//            minX++;
//        }
//    }
//    return minX;
//}
//int minimumShots(List<Point> points)
//{
//    int minX = minimumX(points);
//    int minY = minimumY(points);

//    if (minX > minY)
//        return minY;
//    return minX;
//}


////int N;
////N = Convert.ToInt16(Console.ReadLine());

//var points = new List<Point>() {
//    new Point() { X = 1, Y = 1 },
//    new Point() { X = 3, Y = 1 },
//    new Point() { X = 1, Y = 3 },
//    new Point() { X = 3, Y = 3 },
//    new Point() { X = 2, Y = 2 },
//};
//Console.WriteLine(minimumShots(points));



using System;
using System.Collections.Generic;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Program
{
    static int ComparePoints(Point a, Point b)
    {
        return a.Y - b.Y;
    }

    static int FindMinimumShots(List<Point> points)
    {
        points.Sort(ComparePoints);

        int numShots = 0;
        while (points.Count > 0)
        {
            int maxY = points.Last().Y;
            points.RemoveAt(points.Count - 1);
            numShots++;

            // Видаляємо всі точки, які перетинають горизонтальний промінь
            points.RemoveAll(p => p.Y <= maxY);
        }

        return numShots;
    }

   

    static void Main()
    {
        Console.Write("Введіть кількість точок: ");
        int n = int.Parse(Console.ReadLine());

        List<Point> points = new List<Point>();
        Console.WriteLine("Введіть координати точок (x y): ");
        for (int i = 0; i < n; i++)
        {
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            points.Add(new Point { X = coordinates[0], Y = coordinates[1] });
        }

        int minShots = FindMinimumShots(points);
        Console.WriteLine("Мінімальна кількість пострілів: " + minShots);
    }
}
