using System;

class Program
{
    const int MAX_RESULTS = 20;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your search query:");
        var qry = Console.ReadLine();
        var results = Everything.Search(qry);

        var resultCount = 0;
        foreach(var result in results)
        {
            resultCount++;
            if (resultCount > MAX_RESULTS)
                break;

            Console.WriteLine($"{resultCount:D2}. {result.ToString()}");
        }
    }
}
