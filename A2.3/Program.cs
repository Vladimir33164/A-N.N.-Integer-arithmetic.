//А2.3. Дано трехзначное число. Найти:
//а) число единиц в нем;
//б) число десятков в нем;
//в) сумму его цифр;
//г) произведение его цифр.

int x;
int y;
int z,k;
int a;
int sum;
int prod;
Console.Write("Enter a three-digit number: ");
a = Convert.ToInt32(Console.ReadLine());
while ((a > 999) | (a < 100))
{
   Console.Write("Error! Enter a number from 100 to 999: ");
   a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine();
}
x = a / 10;
y = a % 10;
z = a / 100;
k = x % 10;
sum = k + y + z;
prod = k * y * z;
Console.WriteLine("А) Number of tens: " + z, y);
Console.WriteLine("Б) Number of units:" + y);
Console.WriteLine("В) The sum of the digits of the number: " + sum);
Console.WriteLine("Г) The product of the digits of a number: " + prod);
