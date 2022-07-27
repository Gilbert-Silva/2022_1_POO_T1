using System;
using System.Collections.Generic;

static class NCliente {
  private static List<Cliente> clientes = new List<Cliente>();
  public static bool Autenticar(ref Cliente c) {
    foreach(Cliente obj in clientes)
      if(obj.Nome == c.Nome && obj.Senha == c.Senha) {
        c = obj;
        return true;
      }
    c = null;
    return false;
  }
  public static void Inserir(Cliente c) {
    int id = 0;
    foreach(Cliente obj in clientes)
      if(obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    clientes.Add(c);
  }
  
}