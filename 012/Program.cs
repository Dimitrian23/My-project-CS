﻿//Задача_№12 С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int n;
int d0,d1,max=0;

       System.Console.Write("Введите с клавиатуры число от 10 до 99___________ :");
            n=Convert.ToInt32(Console.ReadLine());

if(n<10)
  {
        System.Console.WriteLine("Вы нарушили правила! Ещё раз прочитайте условие и повторите попытку!");
        System.Console.WriteLine("Несмотря на это я всё равно определила максимальную цифру......");
  }
if(n>99)
  {
       System.Console.WriteLine("Вы нарушили правила! Ещё раз прочитайте условие и повторите попытку!");
       System.Console.WriteLine("Несмотря на это я всё равно определила максимальную цифру......");
  }

d0=n%10;
d1=n/10%10;  
if(d0>d1)          
  {
       max=d0;
       System.Console.Write($"Максимальная цифра в ведённом вами числе = {max}");
  }
if(d1>d0)
  {
        max=d1;
        System.Console.Write($"Максимальная цифра в введённом вами числе = {max}");
  }
if(d1==d0)
  {
        max=d1;
        System.Console.Write($"Максимальная цифра в введённом вами числе = {max}");
  }



