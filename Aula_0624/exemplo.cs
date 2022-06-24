using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Aluno a1 = new Aluno("Gilbert", "1234", 
                         DateTime.Parse("24/06/2002"));
    Aluno a2 = new Aluno("Eduardo", "4321", 
                         DateTime.Parse("23/06/2000"));
    Aluno a3 = new Aluno("Jorgiano", "5678", 
                         DateTime.Parse("24/05/2000"));
    Aluno a4 = new Aluno("Lucena", "8765", 
                         DateTime.Parse("24/05/1990"));
    Aluno a5 = new Aluno("Minora", "1212", 
                         DateTime.Parse("24/06/1992"));
    Aluno[] v = { a1, a2, a3, a4, a5 };
    // foreach (Aluno a in v) Console.WriteLine(a);
    Relatorio.Aniversariantes(v, 6);

    Professor p1 = new Professor("Sales", "1234", 
                         DateTime.Parse("24/06/2002"));
    Professor p2 = new Professor("Assis", "4321", 
                         DateTime.Parse("23/06/2000"));
    Professor p3 = new Professor("Teobaldo", "5678", 
                         DateTime.Parse("23/05/2000"));
    Professor[] w = { p1, p2, p3 };
    Console.WriteLine();
    Relatorio.Aniversariantes(w, 6);
    IAniversariante[] z = { a1, a2, a3, a4, a5, p1, p2, p3 };
    Console.WriteLine();
    Relatorio.Aniversariantes(z, 6);
  }
} 

interface IAniversariante {
  string GetNome();
  DateTime GetNascimento();
  string Nome { get; }
}

class Relatorio {  // Array
  public static void Aniversariantes(IAniversariante[] v, int mes) { // Sort
    Array.Sort(v);
    foreach (IAniversariante a in v)               // IComparable
      if (a.GetNascimento().Month == mes)
        Console.WriteLine($"{a.Nome} - " +
                          $"{a.GetNascimento():dd/MM}");
  }
  /*
  public static void Aniversariantes(Aluno[] v, int mes) {
    foreach (Aluno a in v) 
      if (a.GetNascimento().Month == mes)
        Console.WriteLine($"{a.GetNome()} - " +
                          $"{a.GetNascimento():dd/MM}");
  }
  public static void Aniversariantes(Professor[] v, int mes) {
    foreach (Professor a in v) 
      if (a.GetNascimento().Month == mes)
        Console.WriteLine($"{a.GetNome()} - " +
                          $"{a.GetNascimento():dd/MM}");
  }
  */
}

class Professor : IAniversariante, IComparable {
  private string nome, curso;
  private DateTime nascimento;
  public Professor(string nome, string curso, DateTime nascimento) {
    this.nome = nome;
    this.curso = curso;
    this.nascimento = nascimento;
  }
  public int CompareTo(object obj) {
    IAniversariante p = (IAniversariante) obj;
    return this.nome.CompareTo(p.GetNome());
  }
  public string Nome { get { return nome; } }
  public string GetNome() {
    return nome;
  }
  public DateTime GetNascimento() {
    return nascimento;
  }
  public override string ToString() {
    return $"{nome} - {curso} - {nascimento:dd/MM/yyyy}";
  }  
}

class Aluno : IAniversariante, IComparable {
  private string nome, matricula;
  private DateTime nascimento;
  public Aluno(string nome, string matricula, DateTime nascimento) {
    this.nome = nome;
    this.matricula = matricula;
    this.nascimento = nascimento;
  }
  public int CompareTo(object obj) {
    IAniversariante p = (IAniversariante) obj;
    return this.nome.CompareTo(p.GetNome());
  }
  public string Nome { get { return nome; } }
  public string GetNome() {
    return nome;
  }
  public DateTime GetNascimento() {
    return nascimento;
  }
  public override string ToString() {
    return $"{nome} - {matricula} - {nascimento:dd/MM/yyyy}";
  }
}