using System;

class Program {
  public static void Main() {
    Frete f = new Frete();
    Console.WriteLine(f);
    f.Distancia = 10;
    f.Peso = 50;
    Console.WriteLine(f);
    double valor = f.ValorFrete;
    Console.WriteLine($"Valor do frete = R$ {valor:0.00}");
  }
}
class Frete {
  private double distancia, peso;
  public double Distancia {
    get { return distancia; }    
    set { if (value > 0) distancia = value; }
  }
  public double Peso {
    get => peso;
    set => peso = value > 0 ? value : 0;
  }
  public double ValorFrete {
    get { return 0.01 * distancia * peso; }    
  }
  public override string ToString() {
    return $"Distancia = {distancia}, Peso = {peso}";
  }
}