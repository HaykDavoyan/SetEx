using System;
namespace SetEx;
class Program
{
    static void Main(string[] args)
    {
        MySet<int> firstBazm = new MySet<int>();
        MySet<int> secBazm = new MySet<int>();

        firstBazm.Add(2);
        firstBazm.Add(1);
        firstBazm.Add(4);
        firstBazm.Add(22);
        firstBazm.Add(6);
        firstBazm.Add(2004);

        secBazm.Add(4);
        secBazm.Add(2);
        secBazm.Add(1);
        secBazm.Add(23);
        secBazm.Add(8);
        secBazm.Add(2004);

        var firstResult = firstBazm.Union(secBazm);
        var secondResult = firstBazm.Intersection(secBazm);
        var thirdResult = firstBazm.Difference(secBazm);
        var fourthResult = firstBazm.SymmetricDifference(secBazm);

        Console.WriteLine("Union numbers");
        foreach (var item in firstResult)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine("\nIntersection numbers");
        foreach (var item in secondResult)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine("\nDifference numbers");
        foreach (var item in thirdResult)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine("\nSymmetricDifference numbers");
        foreach (var item in fourthResult)
        {
            Console.Write(item + ", ");
        }
    }
}
