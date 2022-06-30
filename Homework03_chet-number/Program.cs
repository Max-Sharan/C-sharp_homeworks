Console.Clear();

int x = new Random().Next(-1000,1000);

if(x % 2 == 0) 
{
   Console.WriteLine("Число: " + x + ", - чётное");
}
else 
{
    Console.WriteLine("Число: " + x + ", - нечётное");
}