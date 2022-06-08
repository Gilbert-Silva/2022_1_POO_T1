using System;
using System.Threading;
using System.Globalization;

enum Estacao { Verão, Inverno, Outono, Primavera }

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

    Estacao w = Estacao.Inverno;
    Console.WriteLine(w);
    
    DateTime d1 = DateTime.Parse("1/1/2022");
    Console.WriteLine(d1.DayOfWeek);
    DateTime d2 = DateTime.Now;
    Console.WriteLine(d2);
    // d = DateTime.Today;
    // Console.WriteLine(d);
    Console.WriteLine(d2.Day);
    Console.WriteLine(d2.Month);
    Console.WriteLine(d2.Year);
    Console.WriteLine(d2.DayOfWeek);
    TimeSpan intervalo = d2 - d1;
    Console.WriteLine(intervalo);
    Console.WriteLine(intervalo.Days);


    double x = 1.5;
    Console.WriteLine(x);
    Console.WriteLine($"{x:c2}");
    
  }
}