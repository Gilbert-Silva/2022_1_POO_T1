using System;

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria();
    Console.WriteLine("Após criar a conta");
    Console.WriteLine(x.GetTitular());
    Console.WriteLine(x.GetNumero());
    Console.Write("Saldo inicial: ");
    Console.WriteLine(x.GetSaldo());

    Console.WriteLine("Após definir os atributos");
    x.SetTitular("Eduardo Neto");
    x.SetNumero("123-X");
    Console.WriteLine(x.GetTitular());
    Console.WriteLine(x.GetNumero());
    Console.Write("Saldo inicial: ");
    Console.WriteLine(x.GetSaldo());

    Console.Write("Saldo após o depósito: ");
    x.Depositar(200);
    Console.WriteLine(x.GetSaldo());

    Console.Write("Saldo após o saque: ");
    x.Sacar(320);
    Console.WriteLine(x.GetSaldo());
    Console.WriteLine(x);
    //Console.WriteLine(x.ToString());

    Console.WriteLine();
    ContaBancaria y = 
      new ContaBancaria("Gilbert Azevedo", "321-0");
    Console.WriteLine("Após criar a conta");
    Console.WriteLine(y.GetTitular());
    Console.WriteLine(y.GetNumero());
    Console.Write("Saldo inicial: ");
    Console.WriteLine(y.GetSaldo());
    Console.WriteLine(y);
    //Console.WriteLine(y.ToString());
  }
}
/*
class String {
  public int IndexOf(char c) {
    .....
  }
}
*/
class ContaBancaria {
  private string titular = "Nome do cliente";
  private string numero = "Número da conta";
  private double saldo;

  public ContaBancaria() { } // Padrão - deixa de existir qdo outro construtor é definido
  public ContaBancaria(string t, string n) {
    if (t.IndexOf(' ') != -1) this.titular = t;
    if (n.IndexOf('-') != -1) this.numero = n;
  }
  
  public void SetTitular(string titular) { 
    if (titular.IndexOf(' ') != -1) this.titular = titular;
  }
  public string GetTitular() {
    return titular;
  }
  public void SetNumero(string s) { 
    if (s.IndexOf('-') != -1) this.numero = s;
  }
  public string GetNumero() {
    return this.numero;
  }
  public void Depositar(double valor) {
    this.saldo += valor;
  }
  public void Sacar(double valor) {
    if (this.saldo >= valor) this.saldo -= valor;
  }
  public double GetSaldo() {
    return saldo;
  }
  public override string ToString() {
    //return "Olá, eu sou um objeto ContaBancaria";
    return $"Cliente = {titular}\nNº = {numero}\nSaldo = R${saldo:0.00}";
  }
}