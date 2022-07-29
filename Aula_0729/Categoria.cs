using System;
using System.Collections.Generic;

class Categoria : IComparable<Categoria> {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public int CompareTo(Categoria obj) {
    return Descricao.CompareTo(obj.Descricao);
  }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}
