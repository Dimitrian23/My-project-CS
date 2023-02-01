// Зфдача_№7 Выяснить является ли число чётным.

int n;
    System.Console.Write("Введите пожалуйста любое число, а я определю чётное оно или нет)):");
         n=Convert.ToInt32(Console.ReadLine());

bool odd=n%2==0;

if (odd)
   {
    System.Console.WriteLine($"Введённое вами число :{n} является чётным)");
   }
else
   {
    System.Console.WriteLine($"Введённое вами число :{n} является не чётным)");
   }
    System.Console.WriteLine("Это так весело, попробуй ещё раз!))");