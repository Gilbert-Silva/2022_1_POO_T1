using System;
using System.Collections.Generic;
using System.IO;

class Professor {
  public string Nome { get;set; }
  public string Curso { get;set; }
  public string ToCSV() {
    return $"{Nome},{Curso}";
  }
  public void FromCSV(string s) {
    string[] v = s.Split(',');
    Nome = v[0];
    Curso = v[1];
  }
  public override string ToString() {
    return $"{Nome} - {Curso}";
  }
}

class Program {
  public static void Main() {
    Professor p1 = new Professor();
    p1.FromCSV("Gilbert,TADS");
    Professor p2 = new Professor();
    p2.FromCSV("Eduardo,TADS");
    List<Professor> l = new List<Professor>();
    l.Add(p1);
    l.Add(p2);
    foreach(Professor prof in l) Console.WriteLine(prof);
    StreamWriter f = new StreamWriter("arquivo.txt");
    foreach(Professor prof in l) f.WriteLine(prof.ToCSV());
    f.Close();
    //Escrever();
    //Ler();
    // foreach(Professor prof in LerCSV()) Console.WriteLine(prof);
    //List<Professor> l = new List<Professor>();
    //l.Add(new Professor { Nome = "Janser", Curso = "Gestão" });
    //l.Add(new Professor { Nome = "Minora", Curso = "TADS"});
    //l.Add(new Professor { Nome = "Ronaldo", Curso = "Redes"});
    //List<Professor> l = LerCSV("profs.txt");
    //foreach(Professor prof in l) Console.WriteLine(prof);
    // EscreverCSV(l, "profs.txt"); 
  }
  public static List<Professor> LerCSV(string arquivo) {
    List<Professor> lista = new List<Professor>();
    StreamReader f = new StreamReader(arquivo);
    string s = f.ReadLine();
    while (s != null) {
      Professor prof = new Professor();
      prof.FromCSV(s);
      lista.Add(prof);
      s = f.ReadLine();
    }
    f.Close();
    return lista;
  }
  public static void EscreverCSV(List<Professor> l, string arquivo) {
    StreamWriter f = new StreamWriter(arquivo);
    foreach(Professor prof in l) f.WriteLine(prof.ToCSV());
    f.Close();
  }
  public static void Ler() {
    StreamReader f = new StreamReader("contato.txt");
    string s = f.ReadLine();
    while (s != null) {
      Console.WriteLine(s);
      s = f.ReadLine();
    }
    f.Close();
  }

  public static void Escrever() {
    StreamWriter f = new StreamWriter("contato.txt");
    f.WriteLine("Gilbert,TADS");
    f.WriteLine("Eduardo,TADS");
    f.WriteLine("Carlos,Redes");
    f.WriteLine("Moisés,Redes");
    f.Close();
  }
}
