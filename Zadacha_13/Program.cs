// Напишите программу, которая выводит третью цифру заданного числа или  
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6.

Console.WriteLine("Введите любое число, чтобы узнать его третью цифру: ");
string text = Console.ReadLine();
int chislo = Convert.ToInt32(text);

if (chislo < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
while (chislo > 999)
{
    chislo = chislo / 10;
}
int third_cifra = (chislo % 100) % 10;

Console.WriteLine(third_cifra);
