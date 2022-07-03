Console.Write("Введите пожалуйста целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = 1;
Console.Write("Числа от 1 до " + number + " в кубе : ");

while (num <= number)
{
    int cube = num * num * num;
    Console.Write("| " + cube + " |");
    num++;
}