class Frete {
  private double distancia, peso;
  public Frete(double distancia, double peso) {
    this.distancia = distancia;
    this.peso = peso;
  }
  public double GetDistancia() {
    return distancia;
  }
  public double GetPeso() {
    return peso;
  }
  public String toString() {
    return String.format("Distancia = %f km, Peso = %f kg", distancia, peso);
  }
  public void SetDistancia(double distancia) {
    this.distancia = distancia;
  }
  public void SetPeso(double peso) {
    this.peso = peso;
  }
  public double CalcFrete() {
    return 0.01 * distancia * peso;
  }
}

class Program {
  public static void main(String[] args) {
    Frete f = new Frete(100, 10);
    System.out.println(f);
    System.out.println(f.GetDistancia());
    System.out.println(f.GetPeso());
    System.out.println(f.CalcFrete());
    f.SetDistancia(150);
    System.out.println(f);
    System.out.println(f.CalcFrete());
  }
}
