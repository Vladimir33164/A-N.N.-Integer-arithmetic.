//A2.1 Дано двузначное число. Найти:
//а) число десятков в нем;
//б) число единиц в нем;
//в) сумму его цифр;
//г) произведение его цифр.

Console.WriteLine("Enter integer: ");
      string count = Console.ReadLine();
      int number = int.Parse(count);
      int index;
      int units = 0;
      int decades = 0;
      int centuries = 0;
      int sum = 0;
      int multiply = 1;
      for (int i = 0; i < count.Length; i++)
      {
        index = number % 10;
        switch (i)
        {
          case 0:
            units = index;
            break;
          case 1:
            decades = index;
            break;
          case 2:
            centuries = index;
            break;
          default:
            break;
        }
        sum += index;
        multiply *= index;
        number /= 10;
      }
      Console.WriteLine($"units = {units}");
      Console.WriteLine($"decimals = {decades}");
      Console.WriteLine($"centuries = {centuries}");

      Console.WriteLine($"sum of numbers: {sum}");
      Console.WriteLine($"multiplying of numbers: {multiply}");


int des;
int ed;
int summ;
Console.Write("x=");
byte x = byte.Parse(Console.ReadLine());
des = x / 10;
ed = x - (des * 10);
Console.WriteLine($"Number of tens {des:f0}");
Console.WriteLine($"Number of units {ed:f0}");
summ = des + ed;
Console.WriteLine($"The sum of all two-digit numbers {summ:f0}");