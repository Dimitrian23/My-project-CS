// Задача_№2 С клавиатуры вводятся два вещественных числа.Проверить является ли одно из них квадротом второго.
double a,b;

System.Console.Write("Введите значение переменной (a):");
     a=Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите значение переменной (b):");
     b=Convert.ToInt32(Console.ReadLine());


          if (a*a==b) 
                  System.Console.WriteLine("Число переменной(b) является квадратом числа переменной(a)");
        
          if (b*b==a)   
                  System.Console.WriteLine("Число переменной(a) является квадратом  числа переменной(b)");

          if (a*a!=b)
                   System.Console.WriteLine("Число переменной(b) не является квадратом числа переменной(a)");
      
          if(b*b!=a)
                   System.Console.WriteLine("Число переменной(a) не является квадратом числа переменной(b)");


System.Console.WriteLine("Попробуйте ещё раз! Запустите команду dotnet run и введите новые данные!");



      