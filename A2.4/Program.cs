//А2.4  Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.

static void Main()
{
    System.Console.WriteLine("Enter a three-digit number");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 100 && n <= 999)
    {
        int number = n % 100;
        int n1 = n / 100;
        int n2 = number / 10;
        int n3 = number % 10;
        System.Console.WriteLine($"{n3}{n2}{n1}");
    }
    else
    {
        System.Console.WriteLine("error.");
    }
}
