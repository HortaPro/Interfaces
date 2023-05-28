using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25;
public class Equilateral : ITriangle
{
    private double a;

    public double A
    {
        get { return a; }
        set
        {
            if (value > 0) a = value;
        }
    }

    public Equilateral(double a)
    {
        A = a;
    }

    public double Area()
    {
        return a * a * Math.Sqrt(3) / 4;
    }

    public double Perimeter()
    {
        return 3 * a;
    }
}