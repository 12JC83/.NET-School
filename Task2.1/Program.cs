using System;
using System.Drawing;

public class Pointin3DSpace
{
    private int[] coordinates = new int[3];
    private double mass;
    public Pointin3DSpace(int x, int y, int z, double mass)
    {
        X = x;
        Y = y;
        Z = z;
        Mass = mass;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public double Mass
    {
        get { return mass; }
        set
        {
            if (mass < 0)
            {
                mass = 0;
            }
            else
            {
                mass = value;
            }

        }

    }
    public bool isZero()
    {
        if (X == 0 && Y == 0 && Z == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public double PointsDistance(Pointin3DSpace other)
    {
        return Math.Sqrt((X - other.X) ^ 2 + (Y - other.Y) ^ 2 + (Z - other.Z) ^ 2);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Pointin3DSpace point1 = new Pointin3DSpace(5, 6, 4, -5.65);
        Pointin3DSpace point2 = new Pointin3DSpace(0, 0, 0, 5.75);


        Console.WriteLine($"Point 1: X = {point1.X}, Y = {point1.Y}, Z = {point1.Z}, Mass = {point1.Mass}");
        Console.WriteLine($"Point 2: X = {point2.X}, Y = {point2.Y}, Z = {point2.Z}, Mass = {point2.Mass}");



        Console.WriteLine($"If Point 1 have 0 values? {point1.isZero()}");
        Console.WriteLine($"If Point 2 have 0 values? {point2.isZero()}");



        Console.WriteLine($"Distance between Point 1 and Point 2: {point1.PointsDistance(point2)}");

    }
}





