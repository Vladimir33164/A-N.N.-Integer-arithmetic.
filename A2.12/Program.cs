//A2.12. Дано натуральное число n (n > 9). Найти:
//а) число единиц в нем;
//б) число десятков в нем.

static void Main(string[] args)
{
   Console.WriteLine("Enter a natural number that is greater than 9");
   string s = Console.ReadLine();
   double n = Convert.ToDouble(s);
   int l = s.Length;
   double e = n % Math.Pow(10, l - 1);
   double d = n % Math.Pow(10, l - 1);
   int l1 = l;
   if (l == 2)
   {
      d = Math.Truncate(n / 10);
   }
   else
   {
      while (d > 99)
      {
         l1--;
         d = d % Math.Pow(10, l1 - 1);
      }
      d = Math.Truncate(d / 10);
   }
   while (e > 9)
   {
      l--;
      e = e % Math.Pow(10, l - 1);
   }
   Console.WriteLine($"Number of units in a number: {e}");
   Console.WriteLine($"The number of tens in the number: {d}");
}