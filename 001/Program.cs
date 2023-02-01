//Задача_№1 С клавиатуры вводится целое число. Вывести квадрат числа.
checked
{
string? s;
int a; 
System.Console.WriteLine("Введите c клавиатуры число, а затем нажмите Enter)");
     s=Console.ReadLine();
     a=Convert.ToInt32(s);
System.Console.WriteLine("Возводим введённое число в квадрат!");
System.Console.WriteLine("Получаем число:");
       Console.WriteLine (a*a);
System.Console.WriteLine("Задача решена!Троекратное Ура!");
}