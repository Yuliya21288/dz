//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5 78 -> третьей цифры нет 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num >= 100 && num <1000)
{
    Console.WriteLine(num % 10);
}
else if (num >= 1000 && num < 10000)
{
    Console.WriteLine((num / 10)%10);
}
else if (num >= 10000 && num <100000)
{
    Console.WriteLine((num / 100)%10);
}
else
{
    Console.WriteLine("Ошибка");
}