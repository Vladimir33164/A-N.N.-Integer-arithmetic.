//A2.14. Дано натуральное число n (n > 999). Найти:
//а) число сотен в нем;
//б) число тысяч в нем.

Console.WriteLine("Enter a natural number that is greater than 999");
string? s = Console.ReadLine();
double n = Convert.ToDouble(s);
int l = s.Length;
int l2 = l;
int l3 = l;
double t = n % Math.Pow(10, l - 1);
double h = n % Math.Pow(10, l - 1);
while (h > 999)
{
   l2--;
   h = h % Math.Pow(10, l2 - 1);
}
h = Math.Truncate(h / 100);
if (l == 4)
{
   t = Math.Truncate(n / 1000);
}
else
{
   while (t > 9999)
   {
      l3--;
      t = t % Math.Pow(10, l3 - 1);
   }
   t = Math.Truncate(t / 1000);
}
Console.WriteLine($"Number of hundreds in a number: {h}");
Console.WriteLine($"The number of thousands in a number: {t}");
