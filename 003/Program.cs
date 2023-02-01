// Задача_№3 С клавиатуры вводим два числа a и b. Найти максимальное из них.

double a,b,max=0;

System.Console.Write("Введите значение переменной для (a):");
     a=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите значение переменной для (b):");
     b=Convert.ToInt32(Console.ReadLine());

if (a>b)
    {
     max=a;
      System.Console.Write($"Максимальное значение из двух чисел = {max}");
    }
if(b>a)
    { 
     max=b;
      System.Console.Write($"Максимальное значение из двух чисел = {max}");
    }

