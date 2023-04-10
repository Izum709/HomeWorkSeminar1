 //Напишите программу, которая на вход принимает число (N), а на 
 //выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введи число ");
int a = int.Parse(Console.ReadLine());
int min = 1;
Console.Write("А вот и четенькие числа =) ");
while(min <= a)
{
    if (min % 2 == 0) 
    {
        
        Console.Write($" {min} ");
    } 
      min++;
    
} 