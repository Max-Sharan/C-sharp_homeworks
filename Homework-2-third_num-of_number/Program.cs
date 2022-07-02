// -------------- Вывод третьей цифры любого целого числа, если она есть ------------- //
Console.Clear();

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNum = 0;
int count = 1;

if(number < count * 100)
{
    Console.WriteLine();
    Console.WriteLine("Третьей цифры у числа " + number + " нет!");
}    
else
{   while(number > count * 100)
    {
        thirdNum = number / count % 10;
        count *= 10;
    }
    Console.WriteLine();
    Console.WriteLine("Третья цифра у числа " + number + " - это " + thirdNum);
}   
