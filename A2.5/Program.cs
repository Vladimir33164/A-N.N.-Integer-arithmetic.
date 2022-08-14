//A2.5 Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце.
//Найти полученное число.

int x;
int y;
int z;
int a;
Console.Write("Enter a three-digit number: ");
a = Convert.ToInt32(Console.ReadLine());
while ((a > 999) | (a < 100))
{
   Console.Write("Error! Enter a number from 100 to 999: ");
   a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}
x = (a / 10) % 10;
y = a % 10;
z = a / 100;
Console.WriteLine($"If you cross out the left digit and add it at the end, you will get: {x}{y}{z}");
