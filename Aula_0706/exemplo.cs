using System;

class ContaPagar : IComparable {
  public string Fornecedor { get; set; }
  public DateTime Vencimento { get; set; }
  public double Valor { get; set; }
  public int CompareTo(object obj) {
    ContaPagar r = (ContaPagar) obj;
    if (this.Vencimento == r.Vencimento) {
      return this.Fornecedor.CompareTo(r.Fornecedor);
    }
    return this.Vencimento.CompareTo(r.Vencimento);
  } 
  public override string ToString() {
    return $"{Fornecedor} - {Vencimento:dd/MM/yy} - {Valor:0.00}";
  }
}

class Empresa {
  private ContaPagar[] contas = new ContaPagar[2];
  private int k = 0;
  public string Nome { get; set; }
  public int Qtd { get { return k; } }
  public void Inserir(ContaPagar conta) {
    // Solução aumentando o tamanho do vetor
    if (k == contas.Length)
      Array.Resize(ref contas, 2 * contas.Length);
    contas[k++] = conta;  
    // Solução sem aumentar o tamanho do vetor
    // if (k < 10) contas[k++] = conta;
  }
  public ContaPagar[] Listar() {
    ContaPagar[] aux = new ContaPagar[k];
    Array.Copy(contas, aux, k);
    Array.Sort(aux);
    return aux;
//    return contas;
  }
  public ContaPagar[] Pesquisar(int mes, int ano) {
    int cont = 0;
    // Contar quantas contas satisfazem ao critério de pesquisa
    foreach(ContaPagar c in Listar())
      if (c.Vencimento.Month == mes && 
          c.Vencimento.Year == ano) cont++;
    ContaPagar[] aux = new ContaPagar[cont];
    int i = 0;
    foreach(ContaPagar c in Listar())
      if (c.Vencimento.Month == mes && 
          c.Vencimento.Year == ano) aux[i++] = c;
    return aux;
  }
  public double Total(int mes, int ano) {
    double total = 0;
    foreach(ContaPagar c in Listar())
      if (c.Vencimento.Month == mes && 
          c.Vencimento.Year == ano) total += c.Valor;
    return total;
  }
}

class Program {
  public static void Main() {
    ContaPagar c1 = new ContaPagar {
      Fornecedor = "Energia",
      Vencimento = DateTime.Parse("2022-07-06"),
      Valor = 100
    };
    ContaPagar c2 = new ContaPagar {
      Fornecedor = "Energia",
      Vencimento = DateTime.Parse("2022-06-06"),
      Valor = 120
    };
    ContaPagar c3 = new ContaPagar {
      Fornecedor = "Água",
      Vencimento = DateTime.Parse("2022-07-06"),
      Valor = 200
    };
    Console.WriteLine(c1.CompareTo(c2));
    Console.WriteLine(c1.CompareTo(c3));
    Console.WriteLine(c2.CompareTo(c3));

    Empresa e = new Empresa { Nome = "IF" };
    Console.WriteLine(e.Nome);
    e.Inserir(c1);    
    e.Inserir(c2);    
    e.Inserir(c3);    
    Console.WriteLine(e.Qtd);
    foreach(ContaPagar c in e.Listar())
      Console.WriteLine(c);
    foreach(ContaPagar c in e.Pesquisar(7, 2022))
      Console.WriteLine(c);
    Console.WriteLine(e.Total(7, 2022));
  }
}