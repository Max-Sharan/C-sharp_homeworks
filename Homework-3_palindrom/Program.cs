Console.Write("Введите пожалуйста 5-и значное число (от 10000 до 99999): ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (num > 99999 || num < 10000)
{
    Console.WriteLine("Вы ввели не 5-и значное число!");
    Console.Write("Пожалуйста повторите ввод 5и значного числа (от 10000 до 99999): ");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}
int first = num / 10000;
int second = num / 1000 % 10;
int four = num % 100 / 10;
int five = num % 10;

if (first == five && second == four)
{
    Console.WriteLine("Отлично! Ваше число - это палиндром!");
    Console.WriteLine(first + " " + second + " " + num / 100 % 10 + " " + four + " " + five);
}
else
{
    Console.WriteLine("Сожалеем! Ваше число не является палиндром!");
}
