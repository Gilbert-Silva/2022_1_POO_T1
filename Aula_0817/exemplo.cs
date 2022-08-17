using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    int i = 20;
    var x = 40;
    Console.WriteLine(i.GetType());
    Console.WriteLine(x.GetType());
    var v1 = new
      { modelo="Gol", marca="VW", ano=2010, preco=30000.0 };
    var v2 = new
      { modelo="Corsa", marca="GM", ano=2010, preco=35000.0 };
    var c1 = new
      { nome="a", email="a@email.com", fone="1234-5678" };
    Console.WriteLine(v1.GetType());
    Console.WriteLine(v2.GetType());
    Console.WriteLine(c1.GetType());
    Console.WriteLine(v1);
    Console.WriteLine(v2);
    Console.WriteLine(c1);
    Console.WriteLine(v1.modelo);
    Console.WriteLine(v1.marca);
    Console.WriteLine(v1.ano);
    Console.WriteLine(v1.preco);

    List<string> l1 = new List<string> {
      "Tecnologia",
      "Análise e Desenvolvimento",
      "Sistemas"
    };
    
    List<string> l2 = new List<string>();
    l2.Add("Tecnologia");
    l2.Add("Análise e Desenvolvimento");
    l2.Add("Sistemas");

    foreach(string s in l1)
      Console.WriteLine(s);
    foreach(string s in l2)
      Console.WriteLine(s);
  }
}