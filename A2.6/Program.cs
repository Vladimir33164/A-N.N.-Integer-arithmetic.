//A2.6. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.
//A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.
//A2.8. Дано трехзначное число. Найти число, полученное при перестановке второй и третьей цифр заданного числа.

int x;
int y;
int z;
int a;
Console.Write("Enter a three-digit number: ");
a = Convert.ToInt32(Console.ReadLine());
while ((a > 999) | (a < 100))
{
    Console.Write("Error!Enter a number from 100 to 999: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}
z = a / 100;
x = (a / 10) % 10;
y = a % 10;
Console.WriteLine($"A 2.6) If you cross out the right digit and add it at the beginning, you will get:{y}{z}{x}");
Console.WriteLine($"A 2.7) If you rearrange the first and second digits in places, you will get: {x}{z}{y}");
Console.WriteLine($"А 2.8) If you rearrange the second and third digits in places, you will get: {z}{y}{x}");
