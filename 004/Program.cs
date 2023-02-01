// Задача_№4 По заданому с клавиатуры номеру дня недели вывести его на экран.

string? s;
int a;
        System.Console.WriteLine("Спорим я отгадаю день недели по заданному его порядковому номеру!?");
        System.Console.WriteLine("Введите c клавиатуры число от (1) до (7), а затем нажмите Enter)");
             s=Console.ReadLine();
             a=Convert.ToInt32(s);

    if (a==1)
       {
        System.Console.Write("Это порядковый номер данного дня недели : Понедельник/Monday");
       }
    
    if (a==2) 
       {
        System.Console.Write("Это порядковый номер данного дня недели : Вторник/Tuesday");
       }
   
    if (a==3)
       {
        System.Console.Write("Это порядковый номер данного дня недели : Среда/Wednesday");
       }
   
    if (a==4)
       {   
         System.Console.Write("Это порядковый номер данного дня недели : Четверг/Thursday");
       }
   
    if (a==5)
        {
         System.Console.Write("Это порядковый номер данного дня недели : Пятница/Friday");
        }
    
    if (a==6)
        {
           System.Console.Write("Это порядковый номер данного дня недели : Суббота/Saturday");
        }
    
     if (a==7)
        {
           System.Console.Write("Это порядковый номер данного дня недели : Воскресенье/Sunday");
        }
     
     if(a<1)
        {
           System.Console.Write(":( Неверное значение, попробуй ещё раз! :(");
        }
     
     if(a>7)
        {
        System.Console.Write(":( Неверное значение, попробуй ещё раз! :(");
        }