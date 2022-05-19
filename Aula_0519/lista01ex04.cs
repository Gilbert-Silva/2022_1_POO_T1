using System;

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria();
    x.titular = "Eduardo";
    x.numero = "123-X";
    // x.saldo = 1000;
    x.Depositar(200);
    Console.WriteLine("Dados da conta");
    Console.WriteLine(x.titular);
    Console.WriteLine(x.numero);
    Console.WriteLine("Saldo após o depósito");
    Console.WriteLine(x.saldo);
    x.Sacar(320);
    Console.WriteLine("Saldo após o saque");
    Console.WriteLine(x.saldo);

    ContaBancaria y = new ContaBancaria();
    y.titular = "Gilbert";
    y.numero = "321-6";
    y.Depositar(200);
    Console.WriteLine(y.titular);
    Console.WriteLine(y.numero);
    Console.WriteLine(y.saldo);
  }
}

class ContaBancaria {
  public string titular, numero;
  public double saldo;
  public void Depositar(double valor) {
    saldo += valor;
  }
  public void Sacar(double valor) {
    saldo -= valor;
  }
}