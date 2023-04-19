// Напишите программу, которая принимает на вход трехзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string text = Console.ReadLine();
int chislo = Convert.ToInt32(text);

if (chislo < 100 || chislo > 999)
{
    Console.WriteLine("Переписывайте, здесь не трехзначное число ");
}
else
{
    int middle = (chislo / 10) % 10;
    Console.WriteLine("Средняя цифра числа " + middle);
}

