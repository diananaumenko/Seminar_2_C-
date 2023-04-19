// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет.

Console.Write("Введите цифру дня недели: ");
string text = Console.ReadLine();
int dataDayOfWeek = Convert.ToInt32(text);

if (dataDayOfWeek >= 6 && dataDayOfWeek <= 7)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}