using System;

class Pais {
  private string nome = "Nome do país";
  private int populacao = 1;
  // public Pais() { }
  public Pais(string nome, int populacao) {
    // SetNome(nome);
    // SetPopulacao(populacao);
    if (nome != "") this.nome = nome;
    if (populacao > 0) this.populacao = populacao;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) this.populacao = populacao;
  }
  public string GetNome() {
    return this.nome;
  }
  public int GetPopulacao() {
    return this.populacao;
  }
  public override string ToString() {
    return $"Nome: {nome} - {populacao} habitante(s)";
  }
}

class Program {
  public static void Main() {
    Console.WriteLine("Informe o nome do 1º país e sua população");
    string nome = Console.ReadLine();
    int pop = int.Parse(Console.ReadLine());
    Pais maispop = new Pais(nome, pop);
    Console.WriteLine(maispop);
    for (int i = 2; i <= 10; i++) {
      Console.WriteLine($"Informe o nome do {i}º país e sua população");
      nome = Console.ReadLine();
      pop = int.Parse(Console.ReadLine());
      Pais p = new Pais(nome, pop);
      Console.WriteLine(p);
      if (p.GetPopulacao() > maispop.GetPopulacao()) maispop = p;
    }
    Console.WriteLine($"País mais populoso: {maispop}");
  }
}



