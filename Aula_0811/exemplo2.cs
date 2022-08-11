using System;

class Program {
  public static void Main() {
    object o = new Funcionario("Jorgiano", 2000);
    Console.WriteLine(o);
    //Console.WriteLine(o.GetNome());
    //Console.WriteLine(o.GetSalario());

    Funcionario f = new Funcionario("Gilbert", 1000);
    Console.WriteLine(f.GetNome());
    Console.WriteLine(f.GetSalario());
    
    Funcionario g = new Gerente("Fellipe", 1000, 1000);
    Console.WriteLine(g.GetNome());
    Console.WriteLine(g.GetSalario());
    //Console.WriteLine(g.GetGratificacao());
  }
}

class Funcionario {
  private string nome;
  private double salarioBase;
  public Funcionario(string n, double s) {
    nome = n;
    salarioBase = s;
  }
  public string GetNome() {
    return nome;
  }
  public virtual double GetSalario() {
    return salarioBase;
  }
  public override string ToString() {
    return nome + " - " + salarioBase;
  }
}

class Gerente : Funcionario {
  private double gratificacao;
  public Gerente(string n, double s, double g) : base(n, s)  {
    gratificacao = g;
  }
  public override double GetSalario() {
    return base.GetSalario() + gratificacao;
  }
  public double GetGratificacao() {
    return gratificacao;
  }
}