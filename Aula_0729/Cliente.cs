using System;
using System.Collections.Generic;

class Cliente : IComparable<Cliente> {
  public int Id { get; set; }
  public string Nome { get; set; }
  public int IdUsuario { get; set; }
  public int CompareTo(Cliente obj) {
    return Nome.CompareTo(obj.Nome);
  }
  public override string ToString() {
    return $"{Id} - {Nome}";
  }
}