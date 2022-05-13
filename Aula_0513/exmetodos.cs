using System;

class Program {
  public static void Main() {
    int x = MenorValor(4, 5);
    Console.WriteLine(x);
    Console.WriteLine(Program.MenorValor(8, 1, 5));
    int[] w = {10,5,6,3,7};
    Console.WriteLine(MenorValor(w));
    Console.WriteLine(MenorValor(8.1, 5.4));
    int y = MenorValor(
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine()));
    Console.WriteLine(y);
  }
  public static double MenorValor(double a, double b, double c = 5) {
    double menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    return menor;
  }
  public static int MenorValor(int a, int b) {
    int menor = a;
    if (b < menor) menor = b;
    return menor;
  }
  public static int MenorValor(int a, int b, int c) {
    int menor = a;
    if (b < menor) menor = b;
    if (c < menor) menor = c;
    return menor;
  }
  public static int MenorValor(int[] v) {
    int menor = v[0];
    foreach(int i in v)
      if (i < menor) menor = i;
    return menor;
  }
  // def menor_valor(a, b, c)  // snake_case
  
}