//A2.9. Дано трехзначное число, в котором все цифры различны.
//Получить шесть чисел, образованных при перестановке цифр заданного числа.

Console.WriteLine("Enter any integer: ");
      string? digit = Console.ReadLine();
      int number = int.Parse(digit);
      int index;
      int[] numbers = new int[digit.Length];

      for (int i = 0; i < digit.Length; i++)
      {
        index = number % 10;
        numbers[i] = index;
        number /= 10;
      }
      int[] finalArray = new int[numbers.Length * 2];
      Random random = new Random();
      for (int i = 0; i < finalArray.Length; i++)
      {
        finalArray[i] = numbers[random.Next(0, numbers.Length)];
        Console.Write(finalArray[i]);
      }
