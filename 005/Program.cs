// Задача_№5 С клавиатуры вводится 3 числа. Найти максимальное из трёх чисел.
double a,b,c,max=0;

System.Console.Write("Введите значение переменной для (a):");
     a=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите значение переменной для (b):");
     b=Convert.ToInt32(Console.ReadLine());


System.Console.Write("Введите значение переменной для (c):");
     c=Convert.ToInt32(Console.ReadLine());
max=a;
if(b>max)
    { 
     max=b;
    }
if(c>max)
    {
     max=c;
    }
 System.Console.Write($"Максимальным значением из трёх чисел является число {max}"); 