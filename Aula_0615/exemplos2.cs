using System;

class Program {
  public static void MainSemTurma() {
    Console.WriteLine("Informe a quantidade de alunos");
    int n = int.Parse(Console.ReadLine()); 
    Aluno[] v = new Aluno[n];
    for (int i = 0; i < n; i++) {
      Console.WriteLine($"Informe nome e matrícula do {i+1}º aluno");
      string nome = Console.ReadLine();
      string mat = Console.ReadLine();
      Aluno a = new Aluno(nome, mat);
      v[i] = a;
    }
    foreach(Aluno x in v)
      Console.WriteLine(x);
  }
  public static void Main() {
    Console.WriteLine("Informe a disciplina");
    string d = Console.ReadLine(); 
    Console.WriteLine("Informe a quantidade de alunos");
    int n = int.Parse(Console.ReadLine()); 
    Turma t = new Turma(d, n);
    for (int i = 0; i < n; i++) {
      Console.WriteLine($"Informe nome e matrícula do {i+1}º aluno");
      string nome = Console.ReadLine();
      string mat = Console.ReadLine();
      Aluno a = new Aluno(nome, mat);
      t.Inserir(a);
    }
    Console.WriteLine(t);
    foreach(Aluno x in t.GetAlunos())
      Console.WriteLine(x);
  }
}

class Aluno {
  private string nome, matricula;
  public Aluno(string nome, string matricula) {
    this.nome = nome;
    this.matricula = matricula;
  }
  public override string ToString() {
    return $"{nome} - {matricula}";
  }
}

class Turma {
  private string disciplina;
  private Aluno[] v;
  private int i;
  public Turma(string disciplina, int n) {
    this.disciplina = disciplina;
    v = new Aluno[n];
  }
  public void Inserir(Aluno a) {
    v[i] = a;
    i++;
  }
  public Aluno[] GetAlunos() {
    return v;
  }
  public override string ToString() {
    return $"{disciplina} - {i} aluno(s)";
  }
}