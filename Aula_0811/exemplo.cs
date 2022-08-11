using System;

class Program {
  public static void Main() {
    Aluno a = new Aluno();
    a.Cpf = "123";
    Console.WriteLine(a.ToString());
    Console.WriteLine(a.GetType());
    Aluno b = new Aluno();
    b.Cpf = "123";
    Console.WriteLine(a.Equals(b));
  }
}

class Aluno : object { // Herança 
  public string Cpf {get;set;}
  public override string ToString() {
    return "Eu sou o aluno com cpf = " + Cpf;
  }
  public override bool Equals(object obj) {
    Aluno x = (Aluno)obj;
    return this.Cpf == x.Cpf;
  }
}

abstract class Item {
  private string descricao;
  public abstract double GetPreco();
}

class Produto : Item {
  private double preco;
  public override double GetPreco() {
    return preco;
  }
}

class Servico : Item {
  private int tempo;
  public override double GetPreco() {
    return tempo * 2; // dois reais por minuto
  }
}


