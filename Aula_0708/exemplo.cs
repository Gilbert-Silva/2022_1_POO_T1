using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    // Vetor dinâmico
    List<int> lista = new List<int>();
    // Dicionário não ordenado
    // Dictionary<int, int> dic = new Dictionary<int, int>();
    // Dicionário ordenado
    SortedList<int, int> dic = new SortedList<int, int>();
    // Dicionário ordenado sem valor (apenas a chave)
    SortedSet<int> s = new SortedSet<int>();
    int x = 0;
    do {
      x = int.Parse(Console.ReadLine());
      lista.Add(x);
      dic.Add(x, 0); // Valor sempre está com 0
      s.Add(x);
    } while (x != 0);
    Console.WriteLine("Lista");
    foreach(int i in lista)
      Console.WriteLine(i);
    Console.WriteLine("Dicionário");
    foreach(KeyValuePair<int, int> i in dic)
      Console.WriteLine(i.Key);
    Console.WriteLine("Set");
    foreach(int i in s)
      Console.WriteLine(i);
  }
}