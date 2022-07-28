using System;
using System.Collections.Generic;

static class NCliente {
  private static List<Cliente> clientes = new List<Cliente>();
  public static void Inserir(Cliente c) {
    int id = 0;
    foreach(Cliente obj in clientes)
      if(obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    clientes.Add(c);
  }
  public static Cliente Listar(int idUsuario) {
    foreach(Cliente obj in clientes)
      if (obj.IdUsuario == idUsuario) return obj;
    return null;
  }  
}