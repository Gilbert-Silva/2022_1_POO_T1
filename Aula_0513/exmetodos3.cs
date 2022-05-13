using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor inteiro");
    int x;
    while(!int.TryParse(Console.ReadLine(), out x))
      Console.WriteLine("Erro, digite de novo");
    Console.WriteLine(x);
  }
}
