using System;
using System.Collections.Generic;

class Produto : IComparable<Produto> {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public double Preco { get; set; }
  public int Estoque { get; set; }
  public int IdCategoria { get; set; }
  public int CompareTo(Produto obj) {
    return Descricao.CompareTo(obj.Descricao);
  }
  public override string ToString() {
    return $"{Id} - {Descricao} - R$ {Preco:0.00} - Estoque: {Estoque}";
  }
}