//A2.13. Дано натуральное число n (n > 99). Найти:
//а) число десятков в нем;
//б) число сотен в нем.

static void Main(string[] args)
{
    Console.WriteLine("Enter a natural number that is greater than 99");
    string? s = Console.ReadLine();
    double n = Convert.ToDouble(s);
    if (n < 99)
    {
        Console.WriteLine("Incorrect input");
    }
    else
    {
        int l = s.Length;
        int l1 = l;
        int l2 = l;
        double d = n % Math.Pow(10, l - 1);
        double h = n % Math.Pow(10, l - 1);
        while (d > 99)
        {

            l1--;
            d = d % Math.Pow(10, l1 - 1);

        }
        d = Math.Truncate(d / 10);
        if (l == 3)
        {
            h = Math.Truncate(n / 100);
        }
        else
        {
            while (h > 999)
            {
                l2--;
                h = h % Math.Pow(10, l2 - 1);
            }
            h = Math.Truncate(h / 100);
        }

        Console.WriteLine($"The number of tens in the number: {d}");
        Console.WriteLine($"Number of hundreds in a number: {h}");
    }
}
