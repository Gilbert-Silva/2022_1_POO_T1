using System;
using System.Collections.Generic;

class Venda : IComparable<Venda> {
  public int Id { get; set; }
  public DateTime Data { get; set; }
  public bool Carrinho { get; set; }
  public double Total { get; set; }
  public int IdCliente { get; set; }
  public int CompareTo(Venda obj) {
    return Data.CompareTo(obj.Data);
  }
  public override string ToString() {
      return $"{Id} - {Data:dd/MM/yyyy} - R$ {Total:0.00} - Carrinho: {Carrinho}";
  }
}