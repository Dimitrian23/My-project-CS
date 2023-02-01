// Задача_№8 Вывести на экран чётные числа от 1 до N.
int i=2;
int N;

       System.Console.Write("Введите пожалуйста число для переменной(N):");
            N=Convert.ToInt32(Console.ReadLine());

while(i<=N)
     { 
       System.Console.WriteLine($"Чётное число ------> {i}");
            i=i+2;
     }
       System.Console.WriteLine("А у нас отлично получается) Попробуй ещё раз!))");
