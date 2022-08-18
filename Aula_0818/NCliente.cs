using System;
using System.Collections.Generic;
using System.IO;

static class NCliente {
  private static List<Cliente> clientes;// = new List<Cliente>();
  public static void Inserir(Cliente c) {
    clientes = Abrir();
    int id = 0;
    foreach(Cliente obj in clientes)
      if(obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    clientes.Add(c);
    Salvar(clientes);
  }
  public static Cliente Listar(int id) {
    clientes = Abrir();
    foreach(Cliente obj in clientes)
      if (obj.Id == id) return obj;
    return null;
  }  
  public static Cliente ListarUsuario(int idUsuario) {
    clientes = Abrir();
    foreach(Cliente obj in clientes)
      if (obj.IdUsuario == idUsuario) return obj;
    return null;
  }  
  private static string arquivo = "./clientes.xml";
  private static List<Cliente> Abrir() {
    try {
      return Arquivo< List<Cliente> >.Abrir(arquivo);
    }
    catch (FileNotFoundException) {
      return new List<Cliente>();
    }
  }
  private static void Salvar(List<Cliente> obj) {
    Arquivo< List<Cliente> >.Salvar(arquivo, obj);
  }
}