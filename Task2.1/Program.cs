using System;
using System.Reflection;
class Point
{
    private int[] coordinates = new int[3];
    private double mass;
    public int X
    {
        get { return coordinates[0]; }
        set { coordinates[0] = value; }
    }
    public int Y
    {
        get { return coordinates[1]; }
        set { coordinates[1] = value; }
    }
    public int Z
    {
        get { return coordinates[2]; }
        set { coordinates[2] = value; }
    }
    public double Mass
    {
        get { return mass; }
        set
        {
            if (value >= 0)
            {
                mass = value;
            }
            else
            {
                mass = 0;
            }
        }
    }
    public Point(int x, int y, int z, double mass)
    {
        X = x;
        Y = y;
        Z = z;
        Mass = mass;
    }
    public bool isZero()
    {
            return X == 0 && Y == 0 && Z == 0;
       
    }
    public double Distance(Point other)
    {
        return Math.Sqrt((X - other.X)^2 + (Y - other.Y)^2 + (Z - other.Z)^2);
    }
}
    class Program
    {
        public static void Main(string[] args)
        {

        Point point1 = new Point(5, 6, 4, -5.65);
        Point point2 = new Point(0, 0, 0, 5.75);


        Console.WriteLine($"Point 1: X = {point1.X}, Y = {point1.Y}, Z = {point1.Z}, Mass = {point1.Mass}");
        Console.WriteLine($"Point 2: X = {point2.X}, Y = {point2.Y}, Z = {point2.Z}, Mass = {point2.Mass}");



        Console.WriteLine($"If Point 1 have 0 values? {point1.isZero()}");
        Console.WriteLine($"If Point 2 have 0 values? {point2.isZero()}");



        Console.WriteLine($"Distance between Point 1 and Point 2: {point1.Distance(point2)}");

    }
    }

