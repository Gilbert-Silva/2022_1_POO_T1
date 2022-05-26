using System;

class Program {
  public static void Main() {
    Fracao x = new Fracao();
    x.num = 1;
    x.den = 4;
    Fracao y = new Fracao();
    y.num = 2;
    y.den = 3;
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(x * y);
    Console.WriteLine(Fracao.Multiplicar(x, y));
  }
}

class Fracao {
  public int num;
  public int den;
  public override string ToString() {
    return $"{num}/{den}";
  }
  public static Fracao operator *(Fracao a, Fracao b) {
    Fracao r = new Fracao();
    r.num = a.num * b.num;
    r.den = a.den * b.den;
    return r;
  }
  public static Fracao Multiplicar(Fracao a, Fracao b) {
    Fracao r = new Fracao();
    r.num = a.num * b.num;
    r.den = a.den * b.den;
    return r;
  }
}