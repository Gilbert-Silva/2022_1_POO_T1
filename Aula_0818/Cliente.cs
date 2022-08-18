using System;
using System.Collections.Generic;

public class Cliente : IComparable<Cliente> {
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