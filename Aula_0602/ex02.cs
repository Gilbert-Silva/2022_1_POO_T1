using System;

class CartaBaralho {
  private int numero = 1;
  private string naipe = "ouro";
  public CartaBaralho(int numero, string naipe) {
    if (numero >= 1 && numero <= 13) this.numero = numero;
    if (naipe == "ouro" || naipe == "copas" || 
        naipe == "espadas" || naipe == "paus") this.naipe = naipe;
  }
  public void SetNumero(int numero) {
    if (numero >= 1 && numero <= 13) this.numero = numero;
  }
  public void SetNaipe(string naipe) {
    if (naipe == "ouro" || naipe == "copas" || 
        naipe == "espadas" || naipe == "paus") this.naipe = naipe;
  }
  public int GetNumero() {
    return numero;
  }
  public string GetNaipe() {
    return naipe;
  }
  public override string ToString() {
    return $"{numero} - {naipe}";
  }
  public bool EhIgual(CartaBaralho x) {
    return this.numero == x.numero && this.naipe == x.naipe;
  }
  public static bool EhIgual(CartaBaralho x, CartaBaralho y) {
    return x.numero == y.numero && x.naipe == y.naipe;
  }
  /*
  public static bool operator ==(CartaBaralho x, CartaBaralho y) {
    return x.numero == y.numero && x.naipe == y.naipe;
  }
  public static bool operator !=(CartaBaralho x, CartaBaralho y) {
    return !(x.numero == y.numero && x.naipe == y.naipe);
  }
  */
}
class Program {
  public static void Main() {
    CartaBaralho a = new CartaBaralho(3, "espadas");
    CartaBaralho b = new CartaBaralho(5, "ouro");
    CartaBaralho c = new CartaBaralho(3, "espadas");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(a.EhIgual(b));
    Console.WriteLine(a.EhIgual(c));
    Console.WriteLine(b.EhIgual(c));
    Console.WriteLine(CartaBaralho.EhIgual(a, b));
    // Console.WriteLine(CartaBaralho.operator ==(a, b));    
    // Console.WriteLine(a == c);    
    Console.WriteLine("Naipes: ouro, copas, espadas, paus");
    Console.WriteLine("Informe o número da 1ª carta e o naipe");
    CartaBaralho x = new CartaBaralho(int.Parse(Console.ReadLine()), Console.ReadLine());
    Console.WriteLine("Informe o número da 2ª carta e o naipe");
    CartaBaralho y = new CartaBaralho(int.Parse(Console.ReadLine()), Console.ReadLine());
    Console.WriteLine(x);
    Console.WriteLine(y);
    if (x.EhIgual(y)) Console.WriteLine("As cartas são iguais");
    else Console.WriteLine("As cartas são diferentes");
  }
}