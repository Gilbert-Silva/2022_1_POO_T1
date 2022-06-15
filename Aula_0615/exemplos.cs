using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe a quantidade de nomes");
    int n = int.Parse(Console.ReadLine()); // n = 10
    string[] v = new string[n];
    for (int i = 0; i < n; i++) {
      Console.WriteLine($"Informe o {i+1}º nome");
      v[i] = Console.ReadLine();
    }
    Array.Sort(v);
    for (int i = n - 1; i >= 0; i--) {
      Console.WriteLine(v[i]);
    }
  }
}

    /* Console.WriteLine("Informe o 1º nome");
    v[0] = Console.ReadLine();
    Console.WriteLine("Informe o 2º nome");
    v[1] = Console.ReadLine();
     ....
    Console.WriteLine("Informe o nº nome");
    v[n-1] = Console.ReadLine(); */