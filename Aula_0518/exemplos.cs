using System;

class Program {
  public static void Main() {
    int x = 5;           // struct
    int y = 10; 
    string s = "Texto";  // class
    string r = "123";
    Console.WriteLine(x);
    Console.WriteLine(s);
    Console.WriteLine(x + y);
    Console.WriteLine(s + r);

    Console.WriteLine(x.GetType());
    Console.WriteLine(s.GetType());

    Aluno a1 = new Aluno();
    Aluno a2 = new Aluno();

    a1.nome = "Italo";
    a1.matricula = "20211014040001";
    a1.idade = 20;
    a2.nome = "Ariane";
    a2.matricula = "20211014040002";
    a2.idade = 18;

    Console.WriteLine();
    Console.WriteLine(a1.nome);
    Console.WriteLine(a1.matricula);
    Console.WriteLine(a1.idade);
    Console.WriteLine(a1.GetType());
    Console.WriteLine(a1.DiasVividos());
    a1 = null;
    
    Console.WriteLine();
    Console.WriteLine(a2.nome);
    Console.WriteLine(a2.matricula);
    Console.WriteLine(a2.idade);
    Console.WriteLine(a2.GetType());
    Console.WriteLine(a2.DiasVividos());
    
  }
}

class Aluno {
  public string nome;       // Campo ou atributo
  public string matricula;
  public int idade;

  public int DiasVividos() {
    return idade * 365;
  } 
}


