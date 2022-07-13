using System;
using System.IO;

class Aluno { }
class Professor { }
class Triangulo {
  private double b, h;
  public void SetBase(double v) {
    if (v < 0)
      throw new ArgumentOutOfRangeException();
    b = v;
  }
  public void SetAltura(double v) {
    if (v < 0)
      throw new ArgumentOutOfRangeException();
    h = v;
  }
  public override string ToString() {
    return $"{b} {h}";
  }
}

class Program {
  public static void Main() {
    Triangulo t = new Triangulo();
    try {
      t.SetBase(-10);
    }
    catch (ArgumentOutOfRangeException) {
      Console.WriteLine("Valor não pode ser negativo");
    }
    //string s = "Teste";
    // Console.WriteLine(s[10]);
    //s = null;
    // Console.WriteLine(s.Length);
    //object a = new Aluno();
    //Professor p = (Professor) a;
    
    try {
    foreach (string line in File.ReadLines("./Aula_0713/exemplo2.py"))
        Console.WriteLine(line);
    }
    catch (FileNotFoundException erro) {
      Console.WriteLine("Arquivo não encontrado");
      Console.WriteLine(erro.Message);
    }
   
    try {
      //int.Parse(null);
      Console.WriteLine("Digite dois valores inteiros");
      int x = int.Parse(Console.ReadLine());
      int y = int.Parse(Console.ReadLine());
      int z = x / y;
      Console.WriteLine(z);
    }
    catch (FormatException erro) {
      Console.WriteLine("Valor informado não é um número válido.");
      Console.WriteLine(erro.Message);
      //Main();
    }
    catch (DivideByZeroException) {
      Console.WriteLine("Não pode dividir por zero");
    }
    catch (ArithmeticException) {
      Console.WriteLine("Erro de aritmética");
    }
    catch (Exception) {
      Console.WriteLine("Deu algum erro");
    }
    finally {
      Console.WriteLine("Sempre feito");
    }
    //catch {

    Console.WriteLine("Cheguei Aqui!");
  }
}