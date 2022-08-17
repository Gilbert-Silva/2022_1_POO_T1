using System;
using System.Collections.Generic;
using System.Linq;

class Aluno {
  public string Matricula { get; set; }
  public string Nome { get; set; }
  public int Idade { get; set; }
}

class AlunoDiario {
  public string Matricula { get; set; }
  public string Nome { get; set; }
}

class Program {
  public static void Main() {
    List<Aluno> lista = new List<Aluno>();
    lista.Add(new Aluno 
      { Matricula="1", Nome="Gilbert", Idade=50 });
    lista.Add(new Aluno 
      { Matricula="2", Nome="Eduardo", Idade=51 });
    lista.Add(new Aluno 
      { Matricula="3", Nome="Jorgiano", Idade=3012 });

    foreach(Aluno a in lista) 
      Console.WriteLine(a.Matricula + " " + a.Nome + " " + a.Idade);

    List<string> nomes = new List<string>();
    foreach(Aluno a in lista) 
      nomes.Add(a.Nome);

    List<AlunoDiario> nomes3 = new List<AlunoDiario>();
    foreach(Aluno a in lista) 
      nomes3.Add(
      new AlunoDiario { Nome=a.Nome, Matricula=a.Matricula } );

    IEnumerable<string> nomes2 = lista.Select(x => x.Nome);

    var nomes4 = lista.Select(x => new { x.Nome, x.Idade });
    
    foreach(string s in nomes)
      Console.WriteLine(s);

    foreach(string s in nomes2)
      Console.WriteLine(s);

    foreach(var s in nomes4)
      Console.WriteLine(s.Nome + " " + s.Idade + " " + s.GetType());
    
  }
}
