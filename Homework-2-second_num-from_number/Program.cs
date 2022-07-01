// -------------- Вывод второй цифры терхзначного числа ------------- //
Console.Clear();

Console.Write("Введите целое трехзначное число (от 100 до 999): ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 999 || number < 100)
{
    Console.WriteLine();
    Console.WriteLine("Надо было ввести число (от 100 до 999)");
    Console.Write("Повторите ввод числа (от 100 до 999): ");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int secondNumber = number % 100 / 10;
Console.WriteLine("Вторая цифра числа " + number + " - это " + secondNumber);
Console.WriteLine();