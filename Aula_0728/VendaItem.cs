using System;
using System.Collections.Generic;

class VendaItem : IComparable<VendaItem> {
  public int Id { get; set; }
  public int Qtd { get; set; }
  public double Preco { get; set; }
  public int IdProduto { get; set; }
  public int IdVenda { get; set; }
  public int CompareTo(VendaItem obj) {
    return Id.CompareTo(obj.Id);
  }
  public override string ToString() {
      return $"Qtd: {Qtd} - R$ {Preco:0.00}";
  }
}