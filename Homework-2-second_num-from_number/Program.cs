// -------------- Вывод второй цифры терхзначного числа ------------- //
Console.Clear();

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < -999 || number > 999)
{
    Console.WriteLine();
    Console.WriteLine("Надо было ввести трехзначное число");
    Console.Write("Повторите ввод числа (от 100 до 999 или от -999 до -100): ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number < 100 && number > -100)
{
    Console.WriteLine();
    Console.WriteLine("Надо было ввести трехзначное число");
    Console.Write("Повторите ввод числа (от 100 до 999 или от -999 до -100): ");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number > -1000 && number < -99)
{
    Console.WriteLine();
    int secondNumber = -number % 100 / 10;
    Console.WriteLine("Вторая цифра числа " + number + " - это " + secondNumber);
    Console.WriteLine();
}
else if (number > 99 && number < 1000)
{
    Console.WriteLine();
    int secondNumber = number % 100 / 10;
    Console.WriteLine("Вторая цифра числа " + number + " - это " + secondNumber);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Упс! Надо было ввести ТрехЗначное число! :-)");
}