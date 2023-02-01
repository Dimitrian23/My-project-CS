// Задача_№8 Вывести на экран числа от -N до N.

int n;
       System.Console.Write("Введите пожалуйста отрицательное число для переменной(-N):");
            n=Convert.ToInt32(Console.ReadLine());
int i=n;
int N;

       System.Console.Write("Введите пожалуйста положительное число для переменной(N):");
            N=Convert.ToInt32(Console.ReadLine());

while(i<=N)
     { 
       System.Console.WriteLine($" ------> {i}");
            i=i+1;
     }
       System.Console.WriteLine("Отлично,попробуй ещё раз!))");   