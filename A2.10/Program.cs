//A2.10. Дано четырехзначное число. Найти:
//а) сумму его цифр;
//б) произведение его цифр.

int num, sum = 0, pro = 1;
Console.WriteLine("Enter a four-digit number!");
num = Convert.ToInt32(Console.ReadLine());
while (num > 0)
{
sum += num % 10;
pro *= num % 10;
num = (num - num % 10) / 10;
}
Console.WriteLine($"Sum {sum}, composition {pro}");