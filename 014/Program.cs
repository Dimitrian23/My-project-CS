// Задача_№14 С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

int a,b,s,e;
       System.Console.WriteLine("Введите значение для переменной делимого (a):");
            a=Convert.ToInt32(Console.ReadLine());

       System.Console.WriteLine("Введите значение для переменной делителя (b):");
            b=Convert.ToInt32(Console.ReadLine());

s= a%b;
e= a/b;
 if(s==0)
    {
        System.Console.WriteLine($"Делимое ({a}) кратно делителю ({b}), а их частное равно ({e})");
    }
 if(s!=0)
    {
        System.Console.WriteLine($"Остаток от деления делимого {a} на делитель {b} равен числу-------> {s}");
    }

    System.Console.WriteLine("Учение свет! Дерзай, повтори ещё раз, только уже с другими данными))");