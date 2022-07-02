// -------------- Вывод выходного дня недели по номеру ------------- //
Console.Clear();

Console.Write("Введите номер дня недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
int count = 7;

while (day > count)
{
    Console.WriteLine("Прости, друг! В неделе только 7 дней!");
    Console.WriteLine();
    Console.Write("Введите номер дня недели (от 1 до 7): ");
    day = Convert.ToInt32(Console.ReadLine());
}
count -=2;
if (day <= count)
{
    Console.WriteLine("Ещё не выходной день,- трудимся дальше!");
    count +=2;
}
else
{
    Console.WriteLine("УРА! Выходной день,- отдыхаем!");
}
