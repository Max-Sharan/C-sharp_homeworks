int InputInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void CountNumbers(int count, int num)
{
    for (int i = 0; i < num; i++)
    {
        int number = InputInt("Вводите любые целые числа: ");
        if (number > 0)
            count++;
    }
    Console.WriteLine($"Кол-во чисел больше 0 = {count}");
}

int num = InputInt("Какое кол-во чисел хотите ввести? ");
CountNumbers(0, num);