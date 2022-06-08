using System;

class Paciente {
  private string nome;
  private DateTime nascimento;
  public Paciente(string nome, DateTime nascimento) {
    this.nome = nome;
    this.nascimento = nascimento;
  }
  public override string ToString() {
    return $"{nome} {nascimento:dd/MM/yyyy}";
  }
  public string Idade() {
    DateTime hoje = DateTime.Now;
    int anos = hoje.Year - nascimento.Year;
    int meses = hoje.Month - nascimento.Month;
    if (meses < 0) {
      meses += 12;
      anos--;
    }
    return $"{anos} ano(s) e {meses} mes(es)";
  }
}

class Program {
  public static void Main() {
    Console.WriteLine("Informe seu nome");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe sua data de nascimento");
    string data = Console.ReadLine();
    Paciente p = new Paciente(nome, DateTime.Parse(data));
    Console.WriteLine(p);
    Console.WriteLine(p.Idade());
  }
}


