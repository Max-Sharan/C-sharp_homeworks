Console.Clear();

Console.WriteLine("Вы доверяете компьютеру выбрать число?");
Console.Write("Введите да или нет: ");
string userAnswer = Console.ReadLine();

int x = 0;

if (userAnswer.ToLower() == "да")
{
    x = new Random().Next(-100000,100000);
}
else 
{
    Console.Write("Введите своё число: ");
    x = Convert.ToInt32(Console.ReadLine());
}

if(x % 2 == 0) 
{
   Console.WriteLine("Число: " + x + " - чётное");
}
else 
{
    Console.WriteLine("Число: " + x + " - нечётное");
}