// A2.2. Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.

Console.WriteLine($"Enter integer");
      string digit = Console.ReadLine();
      for (int i = digit.Length; i > 0; i--)
      {
         Console.Write(digit[i-1]);
      }
Console.Write("Enter a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number % 10;
int n2 = number / 10;
int su = n1 + n2;
int pr = n1 * n2;
int revers = n1 * 10 + n2;
Console.WriteLine($"Dozens: {n2}, units: {n1},");
Console.WriteLine($"sum: {su}, product: {pr},");
Console.WriteLine($"rearrangement {revers}");
